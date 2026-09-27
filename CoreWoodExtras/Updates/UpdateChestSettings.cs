using System;
using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras.Updates;

internal class UpdateChestSettings
{
	public static void ChestSettingsChanged()
	{
		ApplyToPrefabs(PrefabManager.Instance.GetPrefab);
	}

	internal static void ApplyToPrefabs(Func<string, GameObject> getPrefab)
	{
		ApplySize(getPrefab("mm_corewood_chest_public"), MainConfig.chestColumns.Value, MainConfig.chestRows.Value);
		ApplySize(getPrefab("mm_corewood_chest_private"), MainConfig.chestPrivateColumns.Value, MainConfig.chestPrivateRows.Value);
		ApplySize(getPrefab("mm_corewood_stackable_chest"), MainConfig.chestStackedColumns.Value, MainConfig.chestStackedRows.Value);
	}

	private static void ApplySize(GameObject prefab, int columns, int rows)
	{
		if (!prefab)
		{
			return;
		}
		Container container = prefab.GetComponent<Container>();
		if (!container)
		{
			return;
		}
		container.m_width = columns;
		container.m_height = rows;
	}
}
