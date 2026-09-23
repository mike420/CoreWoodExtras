using UnityEngine;

namespace CoreWoodExtras {

	internal class Shower : MonoBehaviour, Hoverable, Interactable
	{
		public string m_name = "Shower";

		public float m_useDistance = 2f;

		public float m_hoverOffset = 0f;

		public Transform m_attachPoint = null;

        public Vector3 m_detachOffset = new Vector3(0f, 0f, 0f);

		public GameObject m_fxobject = null;

		public EffectList m_showerSFX = null;

		private static string m_attachAnimation = "";

		// Per shower, so one player showering does not lock every other shower.
		private float m_lastShowerTime = -100f;

		public string GetHoverText()
		{
			if (Time.time - m_lastShowerTime < 32f || Player.m_localPlayer == null)
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
			if (Time.time - m_lastShowerTime < 32f)
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
			player.AttachStart(m_attachPoint, null, hideWeapons: true, isBed: false, onShip: false, m_attachAnimation, m_detachOffset);
			m_lastShowerTime = Time.time;
			if (m_fxobject != null)
			{
				// Switched off first so the effect starts over.
				m_fxobject.SetActive(value: false);
				m_fxobject.SetActive(value: true);
			}
			m_showerSFX?.Create(base.transform.position, base.transform.rotation);
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