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

		private static float m_lastUseTime;

		private ZNetView m_nview;

		private void Awake()
		{
			m_nview = base.gameObject.GetComponentInParent<ZNetView>();
			if (!(m_nview == null))
			{
				m_nview.IsValid();
			}
		}

		public string GetHoverText()
		{
			if (Time.time - m_lastUseTime < 6.5f)
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
			if (!InUseDistance(player))
			{
				return false;
			}
			if (Time.time - m_lastUseTime < 6.5f)
			{
				return false;
			}
			Player closestPlayer = Player.GetClosestPlayer(m_attachPoint.position, 0.1f);
			if (closestPlayer != null && closestPlayer != Player.m_localPlayer)
			{
				Player.m_localPlayer.Message(MessageHud.MessageType.Center, "$msg_blocked");
				return false;
			}
			m_disabledObject.SetActive(value: true);
			m_enabledObject.SetActive(value: false);
			if ((bool)player)
			{
				if (player.IsEncumbered())
				{
					return false;
				}
				m_lastUseTime = Time.time;
				m_disabledObject.SetActive(value: false);
				m_enabledObject.SetActive(value: true);
				m_bucketSFX.Create(base.transform.position, base.transform.rotation);
			}
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