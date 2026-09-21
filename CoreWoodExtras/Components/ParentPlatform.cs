using System.Collections.Generic;
using UnityEngine;

public class ParentPlatform : MonoBehaviour
{
	private Piece m_piece;

	// How many colliders of each rider are touching the platform (a player has several); the piece is only removable
	// when nothing is left. [NonSerialized] keeps Jotunn's mock scan from warning about the dictionary.
	[System.NonSerialized]
	private readonly Dictionary<Transform, int> m_riders = new Dictionary<Transform, int>();

	private readonly List<Transform> m_gone = new List<Transform>();

	private void Start()
	{
		m_piece = base.gameObject.GetComponentInParent<Piece>();
	}

	private void OnCollisionEnter(Collision other)
	{
		other.transform.SetParent(base.transform);
		if (other.rigidbody != null)
		{
			other.rigidbody.interpolation = RigidbodyInterpolation.None;
		}
		m_riders.TryGetValue(other.transform, out int touching);
		m_riders[other.transform] = touching + 1;
		UpdateRemovable();
	}

	private void OnCollisionExit(Collision other)
	{
		other.transform.SetParent(null);
		if (other.rigidbody != null)
		{
			other.rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
		}
		if (m_riders.TryGetValue(other.transform, out int touching))
		{
			if (touching <= 1)
			{
				m_riders.Remove(other.transform);
			}
			else
			{
				m_riders[other.transform] = touching - 1;
			}
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
			m_riders.Remove(rider);
		}
		UpdateRemovable();
	}

	private void UpdateRemovable()
	{
		if (m_piece != null)
		{
			m_piece.m_canBeRemoved = m_riders.Count == 0;
		}
	}
}
