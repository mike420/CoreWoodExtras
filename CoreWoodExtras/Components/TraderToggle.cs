using UnityEngine;

namespace CoreWoodExtras
{
	// Shows or hides Burt on the bar to match "Enable Trader". The setting is synced from the server after the bar prefab
	// is set up (and can change while playing), so it is checked here rather than once when the piece is registered.
	internal class TraderToggle : MonoBehaviour
	{
		private const float CheckInterval = 2f;

		public GameObject m_trader;

		// Only a Burt this component hid is shown again, one hidden for another reason (no trader items) stays hidden.
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
