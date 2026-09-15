using UnityEngine;

namespace CoreWoodExtras {

	internal class FishPond : MonoBehaviour, Hoverable, Interactable
	{
		public string m_name = "Fish Pond";

		public float m_useDistance = 4f;

		public float m_hoverOffset = 0f;

		public Transform m_attachPoint = null;

		public GameObject m_fxobject = null;

		private ZNetView m_nview;

		private static readonly int _isFishEnabled = "IsFishEnabled".GetStableHashCode();

		private void Awake()
		{
			m_nview = base.gameObject.GetComponentInParent<ZNetView>();
			if (m_nview == null || !m_nview.IsValid())
			{
				return;
			}
			if (m_nview.GetZDO().GetBool(_isFishEnabled))
			{
				if (!m_fxobject.activeSelf)
				{
					m_fxobject.SetActive(value: true);
				}
			}
			else if (m_fxobject.activeSelf)
			{
				m_fxobject.SetActive(value: false);
			}
		}

		public string GetHoverText()
		{
			if (!InUseDistance(Player.m_localPlayer))
			{
				return Localization.instance.Localize("<color=#888888>$piece_toofar</color>");
			}
			if (!m_fxobject.activeSelf)
			{
				return Localization.instance.Localize(m_name + "\n[<color=yellow><b>$KEY_Use</b></color>] $text_enable_fish");
			}
			return Localization.instance.Localize(m_name + "\n[<color=yellow><b>$KEY_Use</b></color>] $text_disable_fish");
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
			Player human2 = human as Player;
			if (!InUseDistance(human2))
			{
				return false;
			}
			if (m_nview == null || !m_nview.IsValid())
			{
				return false;
			}
			if (!m_fxobject.activeSelf)
			{
				m_nview.GetZDO().Set(_isFishEnabled, value: true);
				m_fxobject.SetActive(value: true);
				ZDOMan.instance.ForceSendZDO(ZNetView.Everybody, m_nview.GetZDO().m_uid);
				return false;
			}
			m_nview.GetZDO().Set(_isFishEnabled, value: false);
			m_fxobject.SetActive(value: false);
			ZDOMan.instance.ForceSendZDO(ZNetView.Everybody, m_nview.GetZDO().m_uid);
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