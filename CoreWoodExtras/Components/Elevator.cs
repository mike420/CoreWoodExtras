using System;
using UnityEngine;

// The elevator state lives in the ZDO so every client sees the same movement:
//   elevatorPosition - index of the point the elevator last rested at
//   elevatorTarget   - index of the point it is travelling to, or -1 when idle
//   elevatorStart    - network time (ticks) the current trip started
//   elevatorSpeed    - speed of the current trip
//   elevatorReverse  - travel direction along the points
//   elevatorSound    - whether the start sound should be played on other clients
// The position is calculated from those values on every client, so nothing is written per frame.
public class Elevator : MonoBehaviour
{
	// True while the elevator is moving. Kept as a field so the prefab's serialized layout stays the same.
	public bool m_canMove = true;

	public float m_speed = 2f;

	public int m_startPoint;

	public Transform[] m_points;

	public static readonly int m_elevatorPosition = "elevatorPosition".GetStableHashCode();

	private static readonly int s_target = "elevatorTarget".GetStableHashCode();

	private static readonly int s_startTime = "elevatorStart".GetStableHashCode();

	private static readonly int s_speed = "elevatorSpeed".GetStableHashCode();

	private static readonly int s_reverse = "elevatorReverse".GetStableHashCode();

	private static readonly int s_sound = "elevatorSound".GetStableHashCode();

	// Only play the start sound for trips that began just now, not for ones already under way when the area loads.
	private const float RemoteSoundWindow = 1.5f;

	private ZNetView m_nview;

	private ElevatorSwitch m_soundSwitch;

	private long m_lastSeenStart;

	private bool IsNetworked => m_nview != null && m_nview.IsValid();

	public bool IsOwner()
	{
		return IsNetworked && m_nview.IsOwner();
	}

	public void RegisterSwitch(ElevatorSwitch elevatorSwitch)
	{
		if (!m_soundSwitch)
		{
			m_soundSwitch = elevatorSwitch;
		}
	}

	public void Start()
	{
		m_nview = base.gameObject.GetComponentInParent<ZNetView>();
		if (m_points == null || m_points.Length == 0)
		{
			return;
		}
		int rest;
		if (IsNetworked)
		{
			ZDO zdo = m_nview.GetZDO();
			rest = Mathf.Clamp(zdo.GetInt(m_elevatorPosition, 0), 0, m_points.Length - 1);
			m_lastSeenStart = zdo.GetLong(s_startTime, 0L);
		}
		else
		{
			// Placement ghost: no ZDO, just show the start point.
			rest = Mathf.Clamp(m_startPoint, 0, m_points.Length - 1);
		}
		base.transform.position = m_points[rest].position;
	}

	public void Update()
	{
		if (m_points == null || m_points.Length == 0 || !IsNetworked || ZNet.instance == null)
		{
			return;
		}
		ZDO zdo = m_nview.GetZDO();
		ReadState(zdo, out int rest, out int target, out float traveled, out float distance);
		PlayRemoteSound(zdo);

		if (target < 0)
		{
			base.transform.position = m_points[rest].position;
			m_canMove = false;
			return;
		}
		if (traveled >= distance)
		{
			base.transform.position = m_points[target].position;
			m_canMove = false;
			if (m_nview.IsOwner())
			{
				// Only the owner writes the arrival back, so peers never fight over the state.
				zdo.Set(m_elevatorPosition, target);
				zdo.Set(s_target, -1);
			}
			return;
		}
		base.transform.position = Vector3.MoveTowards(m_points[rest].position, m_points[target].position, traveled);
		m_canMove = true;
	}

	// Starts a trip to the next point. Returns false if the elevator is already moving or cannot move.
	public bool Activate(float speed = 2f, bool playSound = false)
	{
		if (m_points == null || m_points.Length < 2 || !IsNetworked || ZNet.instance == null)
		{
			return false;
		}
		ZDO zdo = m_nview.GetZDO();
		ReadState(zdo, out int rest, out int target, out float traveled, out float distance);
		if (target >= 0)
		{
			if (traveled < distance)
			{
				return false;
			}
			// Arrived but the owner has not written it back yet.
			rest = target;
		}

		bool reverse = zdo.GetBool(s_reverse, false);
		if (rest >= m_points.Length - 1)
		{
			reverse = true;
		}
		else if (rest <= 0)
		{
			reverse = false;
		}
		int next = reverse ? rest - 1 : rest + 1;
		long start = ZNet.instance.GetTime().Ticks;

		// Only the owner's ZDO changes are kept, so take ownership before writing.
		m_nview.ClaimOwnership();
		zdo.Set(m_elevatorPosition, rest);
		zdo.Set(s_reverse, reverse);
		zdo.Set(s_speed, speed);
		zdo.Set(s_sound, playSound);
		zdo.Set(s_target, next);
		zdo.Set(s_startTime, start);
		m_lastSeenStart = start;
		m_canMove = true;
		return true;
	}

	private void ReadState(ZDO zdo, out int rest, out int target, out float traveled, out float distance)
	{
		rest = Mathf.Clamp(zdo.GetInt(m_elevatorPosition, 0), 0, m_points.Length - 1);
		target = zdo.GetInt(s_target, -1);
		traveled = 0f;
		distance = 0f;
		if (target < 0 || target >= m_points.Length)
		{
			target = -1;
			return;
		}
		double elapsed = (ZNet.instance.GetTime().Ticks - zdo.GetLong(s_startTime, 0L)) / (double)TimeSpan.TicksPerSecond;
		traveled = (float)Math.Max(0.0, elapsed) * zdo.GetFloat(s_speed, 2f);
		distance = Vector3.Distance(m_points[rest].position, m_points[target].position);
	}

	// The player who started the trip plays the sound in ElevatorSwitch; everyone else plays it when they see the new trip.
	private void PlayRemoteSound(ZDO zdo)
	{
		long start = zdo.GetLong(s_startTime, 0L);
		if (start == m_lastSeenStart)
		{
			return;
		}
		m_lastSeenStart = start;
		if (!zdo.GetBool(s_sound, false) || !m_soundSwitch)
		{
			return;
		}
		double age = (ZNet.instance.GetTime().Ticks - start) / (double)TimeSpan.TicksPerSecond;
		if (age < RemoteSoundWindow)
		{
			m_soundSwitch.PlayStartSound();
		}
	}
}
