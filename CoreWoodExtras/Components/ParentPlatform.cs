using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;

public class ParentPlatform : MonoBehaviour
{
	private class Rider
	{
		// How many colliders of the rider are touching the platform (a player has several).
		public int Touching;

		// What the rider was parented to before it got on, so it goes back there when it gets off.
		public Transform OriginalParent;
	}

	private Piece m_piece;

	// The rider is only let go, and the piece only removable, when none of its colliders touch any more.
	// [NonSerialized] keeps Jotunn's mock scan from warning about the dictionary.
	[System.NonSerialized]
	private readonly Dictionary<Transform, Rider> m_riders = new Dictionary<Transform, Rider>();

	private readonly List<Transform> m_gone = new List<Transform>();

	// Every platform in the world, so the destroy hook only has anything to do when a platform is loaded.
	private static readonly HashSet<ParentPlatform> s_platforms = new HashSet<ParentPlatform>();

	private void Start()
	{
		m_piece = base.gameObject.GetComponentInParent<Piece>();
	}

	private void OnEnable()
	{
		s_platforms.Add(this);
	}

	private void OnDisable()
	{
		s_platforms.Remove(this);
	}

	private void OnCollisionEnter(Collision other)
	{
		Transform rider = other.transform;
		if (!m_riders.TryGetValue(rider, out Rider state))
		{
			state = new Rider { OriginalParent = rider.parent };
			m_riders[rider] = state;
			rider.SetParent(base.transform);
			if (other.rigidbody != null)
			{
				other.rigidbody.interpolation = RigidbodyInterpolation.None;
			}
		}
		state.Touching++;
		UpdateRemovable();
	}

	private void OnCollisionExit(Collision other)
	{
		Transform rider = other.transform;
		if (!m_riders.TryGetValue(rider, out Rider state))
		{
			return;
		}
		state.Touching--;
		if (state.Touching <= 0)
		{
			m_riders.Remove(rider);
			Release(rider, state);
		}
		UpdateRemovable();
	}

	// Unity does not send OnCollisionExit when a rider is destroyed or deactivated (a player logging out or dying, an
	// item that is picked up), so riders that are gone are dropped here. A rider that comes back sends a new enter.
	private void FixedUpdate()
	{
		if (m_riders.Count == 0)
		{
			return;
		}
		m_gone.Clear();
		foreach (Transform rider in m_riders.Keys)
		{
			if (rider == null || !rider.gameObject.activeInHierarchy)
			{
				m_gone.Add(rider);
			}
		}
		if (m_gone.Count == 0)
		{
			return;
		}
		foreach (Transform rider in m_gone)
		{
			if (m_riders.TryGetValue(rider, out Rider state))
			{
				m_riders.Remove(rider);
				Release(rider, state);
			}
		}
		UpdateRemovable();
	}

	// Lets go of everyone on the platform. Called before the platform is destroyed, since Unity destroys children with
	// their parent and a player standing on it would be destroyed with it.
	public void DetachAll()
	{
		foreach (KeyValuePair<Transform, Rider> rider in m_riders)
		{
			Release(rider.Key, rider.Value);
		}
		m_riders.Clear();
		UpdateRemovable();
	}

	private void Release(Transform rider, Rider state)
	{
		if (rider == null || rider.parent != base.transform)
		{
			return;
		}
		// The original parent may have gone in the meantime.
		rider.SetParent(state.OriginalParent != null ? state.OriginalParent : null);
		Rigidbody body = rider.GetComponent<Rigidbody>();
		if (body != null)
		{
			body.interpolation = RigidbodyInterpolation.Interpolate;
		}
	}

	private void UpdateRemovable()
	{
		if (m_piece != null)
		{
			m_piece.m_canBeRemoved = m_riders.Count == 0;
		}
	}

	// Every way a networked object is destroyed (removed, broken, unloaded with its zone, the ZDO destroyed by another
	// client) resets its ZDO just before destroying it, so riders are let go there, while they can still be moved out.
	[HarmonyPatch(typeof(ZNetView), nameof(ZNetView.ResetZDO))]
	private static class ZNetView_ResetZDO_Patch
	{
		private static void Prefix(ZNetView __instance)
		{
			if (s_platforms.Count == 0 || !__instance)
			{
				return;
			}
			Transform root = __instance.transform;
			foreach (ParentPlatform platform in s_platforms)
			{
				if (platform && platform.m_riders.Count > 0 && platform.transform.IsChildOf(root))
				{
					platform.DetachAll();
				}
			}
		}
	}
}
