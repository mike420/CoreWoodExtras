using UnityEngine;

namespace CoreWoodExtras {

	internal class WaterWell : MonoBehaviour, Hoverable, Interactable
	{
		public string m_name = "Water Well";

		public float m_useDistance = 3.5f;

		public float m_hoverOffset = 0f;

		public Transform m_attachPoint = null;

		public GameObject m_disabledObject = null;

		public GameObject m_enabledObject = null;

		public EffectList m_bucketSFX = null;

		private float m_lastUseTime = -100f;

		public string GetHoverText()
		{
			if (Time.time - m_lastUseTime < 6.5f || Player.m_localPlayer == null)
			{
				return "";
			}
			if (!InUseDistance(Player.m_localPlayer))
			{
				return Localization.instance.Localize("<color=#888888>$piece_toofar</color>");
			}
			return Localization.instance.Localize(m_name + "\n[<color=yellow><b>$KEY_Use</b></color>] $piece_use");
		}

		public string GetHoverName()
		{
			return m_name;
		}

		public bool Interact(Humanoid human, bool hold, bool alt)
		{
			if (hold)
			{
				return false;
			}
			Player player = human as Player;
			if (player == null || !InUseDistance(player))
			{
				return false;
			}
			if (Time.time - m_lastUseTime < 6.5f)
			{
				return false;
			}
			Player closestPlayer = Player.GetClosestPlayer(m_attachPoint.position, 0.1f);
			if (closestPlayer != null && closestPlayer != player)
			{
				player.Message(MessageHud.MessageType.Center, "$msg_blocked");
				return false;
			}
			if (player.IsEncumbered())
			{
				return false;
			}
			m_lastUseTime = Time.time;
			if (m_enabledObject != null)
			{
				m_enabledObject.SetActive(value: false);
				m_enabledObject.SetActive(value: true);
			}
			if (m_disabledObject != null)
			{
				m_disabledObject.SetActive(value: false);
			}
			m_bucketSFX?.Create(base.transform.position, base.transform.rotation);
			return false;
		}

		public bool UseItem(Humanoid user, ItemDrop.ItemData item)
		{
			return false;
		}

		private bool InUseDistance(Humanoid human)
		{
			return Vector3.Distance(human.transform.position, m_attachPoint.position) < m_useDistance;
		}

		public float GetHoverOffset()
		{
			return m_hoverOffset;
		}
	}
}