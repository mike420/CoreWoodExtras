using UnityEngine;

namespace CoreWoodExtras {

	internal class Inflatable : MonoBehaviour, Hoverable, Interactable
	{
		public string m_name = "Inflatable";

		public float m_useDistance = 1.5f;

		public float m_hoverOffset = 0f;

		public Transform m_attachPoint = null;

        public Vector3 m_detachOffset = new Vector3(0f, 0f, 0f);

		private static string m_attachAnimation = "attach_bed";

		private static readonly int WetHash = "Wet".GetStableHashCode();

		private float m_lastAttachTime = -100f;

		public string GetHoverText()
		{
			if (Time.time - m_lastAttachTime < 2f || Player.m_localPlayer == null)
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
			if (Time.time - m_lastAttachTime < 2f)
			{
				return false;
			}
			Player player = human as Player;
			if (player == null || !InUseDistance(player))
			{
				return false;
			}
			if (player.GetSEMan().HaveStatusEffect(WetHash))
			{
				player.GetSEMan().RemoveStatusEffect(WetHash, quiet: true);
			}
			player.AttachStart(m_attachPoint, base.gameObject, hideWeapons: true, isBed: false, onShip: false, m_attachAnimation, m_detachOffset);
			m_lastAttachTime = Time.time;
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