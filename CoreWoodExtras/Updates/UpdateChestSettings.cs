using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras.Updates;

internal class UpdateChestSettings
{
	public static void ChestSettingsChanged()
	{
		GameObject prefab = PrefabManager.Instance.GetPrefab("mm_corewood_chest_public");
		GameObject prefab2 = PrefabManager.Instance.GetPrefab("mm_corewood_chest_private");
		GameObject prefab3 = PrefabManager.Instance.GetPrefab("mm_corewood_stackable_chest");
		if (prefab != null)
		{
			Container component = prefab.GetComponent<Container>();
			component.m_width = MainConfig.chestColumns.Value;
			component.m_height = MainConfig.chestRows.Value;
		}
		if (prefab2 != null)
		{
			Container component2 = prefab2.GetComponent<Container>();
			component2.m_width = MainConfig.chestPrivateColumns.Value;
			component2.m_height = MainConfig.chestPrivateRows.Value;
		}
		if (prefab3 != null)
		{
			Container component3 = prefab3.GetComponent<Container>();
			component3.m_width = MainConfig.chestStackedColumns.Value;
			component3.m_height = MainConfig.chestStackedRows.Value;
		}
	}
}
