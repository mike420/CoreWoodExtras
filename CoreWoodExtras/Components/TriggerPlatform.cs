using CoreWoodExtras;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
	public Elevator m_platform;

	private void OnTriggerEnter(Collider other)
	{
		if (MainConfig.autoTriggers.Value)
		{
			m_platform.m_speed = 2f;
			m_platform.m_canMove = true;
		}
	}
}
