using CoreWoodExtras;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
	public Elevator m_platform;

	private void OnTriggerEnter(Collider other)
	{
		if (!MainConfig.autoTriggers.Value || m_platform == null)
		{
			return;
		}

		// Every client sees the collider enter, so only one of them may start the trip:
		// players start it on their own client, anything else (creatures, item drops) is handled by the elevator's owner.
		Player player = other.GetComponentInParent<Player>();
		if (player != null)
		{
			if (player != Player.m_localPlayer)
			{
				return;
			}
		}
		else if (!m_platform.IsOwner())
		{
			return;
		}
		m_platform.Activate();
	}
}
