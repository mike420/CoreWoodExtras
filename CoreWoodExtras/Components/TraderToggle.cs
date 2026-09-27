using UnityEngine;

namespace CoreWoodExtras
{
	internal class TraderToggle : MonoBehaviour
	{
		private const float CheckInterval = 2f;

		public GameObject m_trader;

		private bool m_hidden;

		private void Start()
		{
			Apply();
			InvokeRepeating(nameof(Apply), CheckInterval, CheckInterval);
		}

		private void Apply()
		{
			if (m_trader == null)
			{
				return;
			}
			bool enabled = MainConfig.traderEnabled.Value;
			if (!enabled && m_trader.activeSelf)
			{
				m_trader.SetActive(false);
				m_hidden = true;
			}
			else if (enabled && m_hidden)
			{
				m_trader.SetActive(true);
				m_hidden = false;
			}
		}
	}
}
