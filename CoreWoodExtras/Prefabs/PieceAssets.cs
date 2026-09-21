using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras;

internal static class PieceAssets
{
	public static EffectList buildWood;
	public static EffectList breakWood;
	public static EffectList hitWood;
	public static EffectList buildStone;
	public static EffectList breakStone;
	public static EffectList hitStone;
	public static EffectList buildMetal;
	public static EffectList breakMetal;
	public static EffectList hitMetal;
	public static EffectList breakGlass;
	public static EffectList doorOpen;
	public static EffectList doorClose;
	public static EffectList gateOpen;
	public static EffectList gateClose;
	public static EffectList chestOpen;
	public static EffectList chestClose;
	public static EffectList bridgeOC;
	public static EffectList towerOC;
	public static EffectList elevator;
	public static EffectList elevatorLong;
	public static EffectList addFuel;
	public static EffectList m_activateSFX;
	public static EffectList m_deactivateSFX;
	public static EffectList placeWorkbench;
	public static EffectList addEffects;
	public static EffectList harvestEffects;
	public static EffectList spawnEffects;

	public static ItemDrop fuelCoal;
	public static ItemDrop fuelResin;

	private static bool s_built;

	public static void Init()
	{
		if (s_built)
		{
			return;
		}

		buildWood = Effects("sfx_build_hammer_wood");
		breakWood = Effects("sfx_wood_break");
		hitWood = Effects("sfx_wood_hit");

		buildStone = Effects("sfx_build_hammer_stone");
		breakStone = Effects("sfx_rock_destroyed");
		hitStone = Effects("sfx_rock_hit");

		buildMetal = Effects("sfx_build_hammer_metal");
		breakMetal = Effects("sfx_metal_blocked");
		hitMetal = Effects("sfx_metal_blocked");

		breakGlass = Effects("sfx_break_glass_mm");

		doorOpen = Effects("sfx_door_open");
		doorClose = Effects("sfx_door_close");

		gateOpen = Effects("sfx_open_gate_mm");
		gateClose = Effects("sfx_close_gate_mm");

		chestOpen = Effects("sfx_chest_open");
		chestClose = Effects("sfx_chest_close");

		bridgeOC = Effects("sfx_open_bridge_mm");
		towerOC = Effects("sfx_tower_bridge_mm");
		elevator = Effects("sfx_elevator_mm");
		elevatorLong = Effects("sfx_elevator_long_mm");

		addFuel = Effects("vfx_walltorch_addFuel", "sfx_FireAddFuel");

		m_activateSFX = Effects("fx_guardstone_activate");
		m_deactivateSFX = Effects("fx_guardstone_deactivate");
		placeWorkbench = Effects("vfx_Place_workbench");

		addEffects = Effects("vfx_fermenter_add");
		harvestEffects = Effects("sfx_pickable_pick");
		spawnEffects = Effects("vfx_lootspawn", "sfx_lootspawn");

		fuelCoal = PrefabManager.Cache.GetPrefab<GameObject>("Coal").GetComponent<ItemDrop>();
		fuelResin = PrefabManager.Cache.GetPrefab<GameObject>("Resin").GetComponent<ItemDrop>();

		s_built = true;
	}

	public static EffectList Effects(params string[] prefabNames)
	{
		EffectList.EffectData[] effects = new EffectList.EffectData[prefabNames.Length];
		for (int i = 0; i < prefabNames.Length; i++)
		{
			effects[i] = new EffectList.EffectData { m_prefab = PrefabManager.Cache.GetPrefab<GameObject>(prefabNames[i]) };
		}
		return new EffectList { m_effectPrefabs = effects };
	}
}
