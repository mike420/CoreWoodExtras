using BepInEx.Configuration;
using Jotunn.Extensions;
using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras;

internal static class MainConfig
{
	public enum ShadowsType
	{
		None,
		Hard,
		Soft
	}

    // "General Settings";
	public static ConfigEntry<bool> modEnabled;
	public static ConfigEntry<bool> disableHDTextures;
	public static ConfigEntry<bool> toiletEffects;
	public static ConfigEntry<bool> enableElevators;
	public static ConfigEntry<bool> autoTriggers;
    public static ConfigEntry<bool> traderEnabled;

    // "Chest Settings";
    public static ConfigEntry<int> chestColumns;
	public static ConfigEntry<int> chestRows;
	public static ConfigEntry<int> chestPrivateColumns;
	public static ConfigEntry<int> chestPrivateRows;
	public static ConfigEntry<int> chestStackedColumns;
	public static ConfigEntry<int> chestStackedRows;
	public static ConfigEntry<bool> chestStackedHotbar;

	// "Skull Light Settings";
	public static ConfigEntry<float> skullLightIntensity;
	public static ConfigEntry<float> skullLightRange;
	public static ConfigEntry<ShadowsType> skullLightShadows;

	// "Chandelier Light Settings";
	public static ConfigEntry<float> chandelierLightIntensity;
	public static ConfigEntry<float> chandelierLightRange;
	public static ConfigEntry<ShadowsType> chandelierLightShadows;

	// "Wall Light Settings";
	public static ConfigEntry<float> wallLightIntensity;
	public static ConfigEntry<float> wallLightRange;
	public static ConfigEntry<ShadowsType> wallLightShadows;

	// "Surtling Lantern Light Settings";
	public static ConfigEntry<float> surtlingLanternLightIntensity;
	public static ConfigEntry<float> surtlingLanternLightRange;
	public static ConfigEntry<ShadowsType> surtlingLanternLightShadows;

	// "Surtling Single Light Settings";
	public static ConfigEntry<float> surtlingSingleLightIntensity;
	public static ConfigEntry<float> surtlingSingleLightRange;
	public static ConfigEntry<ShadowsType> surtlingSingleLightShadows;

	// "Surtling Double Light Settings";
	public static ConfigEntry<float> surtlingDoubleLightIntensity;
	public static ConfigEntry<float> surtlingDoubleLightRange;
	public static ConfigEntry<ShadowsType> surtlingDoubleLightShadows;

	// "Lava Light Settings";
	public static ConfigEntry<float> lavaLightIntensity;
	public static ConfigEntry<float> lavaLightRange;
	public static ConfigEntry<ShadowsType> lavaLightShadows;

	// "Crystal Light Settings";
	public static ConfigEntry<float> crystalLightIntensity;
	public static ConfigEntry<float> crystalLightRange;
	public static ConfigEntry<ShadowsType> crystalLightShadows;

	// "Rope Light Settings";
	public static ConfigEntry<float> ropeLightIntensity;
	public static ConfigEntry<float> ropeLightRange;
	public static ConfigEntry<ShadowsType> ropeLightShadows;

	// "Brazier Light Settings";
	public static ConfigEntry<float> brazierLightIntensity;
	public static ConfigEntry<float> brazierLightRange;
	public static ConfigEntry<ShadowsType> brazierLightShadows;

	// "Beacon Light Settings";
	public static ConfigEntry<float> beaconLightIntensity;
	public static ConfigEntry<float> beaconLightRange;
	public static ConfigEntry<ShadowsType> beaconLightShadows;

    // "Auto-Feed Settings";
    public static ConfigEntry<float> ContainerRange = null!;
    public static ConfigEntry<float> FeedCheckCooldown = null!;

    // "Scarecrow Settings";
    public static ConfigEntry<bool> EnableProtectionToggle = null!;
    public static ConfigEntry<bool> ShowForcefield = null!;

    // "Seed Bed Settings";
    public static ConfigEntry<float> SeedBedGerminationDuration = null!;
    public static ConfigEntry<bool> SeedBedAutoHarvest = null!;
    public static ConfigEntry<bool> SeedBedAutoStore = null!;
    public static ConfigEntry<bool> SeedBedAutoReplant = null!;
    public static ConfigEntry<float> SeedBedChestRange = null!;
    public static ConfigEntry<float> SeedBedHarvestDelay = null!;
    public static ConfigEntry<float> SeedBedFarmingExp = null!;
    public static ConfigEntry<float> SeedBedHerbalistExp = null!;

    public static void InitConfigs(ConfigFile config)
	{
		modEnabled = config.BindConfigInOrder("General Settings", "Enable Plugin", defaultValue: true, "Enable the CoreWoodExtras plugin.\n");
		disableHDTextures = config.BindConfigInOrder("General Settings", "Disable HD", defaultValue: false, "Enabling this will set the textures look more vanilla like.\n(using point filter instead of trilinear).\n", synced: false);
		disableHDTextures.SettingChanged += CoreWoodPlugin.OnMainConfigChanged;
		toiletEffects = config.BindConfigInOrder("General Settings", "Toilet Effects", defaultValue: true, "Enable the toilet effects.\n", synced: false);
		toiletEffects.SettingChanged += CoreWoodPlugin.OnMainConfigChanged;
		enableElevators = config.BindConfigInOrder("General Settings", "Enable Elevators", defaultValue: true, "If Off, elevators will be disabled.\n(Restart required).\n");
		autoTriggers = config.BindConfigInOrder("General Settings", "Automatic Elevators", defaultValue: true, "If On, elevators will move automatically when a player steps on it.\n", synced: false);
        traderEnabled = config.BindConfigInOrder("General Settings", "Enable Trader", defaultValue: true, "Enable Burt the barman.\n(Restart required).\n");

        chestColumns = config.BindConfigInOrder("Chest Settings", "Chest Columns", 6, "Amount of columns for core wood chest container.\n(Restart or rebuild chest).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 8));
		chestColumns.SettingChanged += CoreWoodPlugin.OnChestConfigChanged;
		chestRows = config.BindConfigInOrder("Chest Settings", "Chest Rows", 4, "Amount of rows for core wood chest container.\n(Restart or rebuild chest).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10));
		chestRows.SettingChanged += CoreWoodPlugin.OnChestConfigChanged;
		chestPrivateColumns = config.BindConfigInOrder("Chest Settings", "Private Chest Columns", 6, "Amount of columns for Private core wood chest container.\n(Restart or rebuild chest).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 8));
		chestPrivateColumns.SettingChanged += CoreWoodPlugin.OnChestConfigChanged;
		chestPrivateRows = config.BindConfigInOrder("Chest Settings", "Private Chest Rows", 4, "Amount of rows for Private core wood chest container.\n(Restart or rebuild chest).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10));
		chestPrivateRows.SettingChanged += CoreWoodPlugin.OnChestConfigChanged;
		chestStackedColumns = config.BindConfigInOrder("Chest Settings", "StackedChestColumns", 6, "Amount of columns for Stacked core wood chest container.\n(Restart or rebuild chest).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 8));
		chestStackedColumns.SettingChanged += CoreWoodPlugin.OnChestConfigChanged;
		chestStackedRows = config.BindConfigInOrder("Chest Settings", "StackedChestRows", 4, "Amount of rows for Stacked core wood chest container.\n(Restart or rebuild chest).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10));
		chestStackedRows.SettingChanged += CoreWoodPlugin.OnChestConfigChanged;
		chestStackedHotbar = config.BindConfigInOrder("Chest Settings", "DisableHotbarNaming", defaultValue: false, "Enabling this will disable auto naming from hotbar.\n", synced: false);
		chestStackedHotbar.SettingChanged += CoreWoodPlugin.OnChestConfigChanged;
		
		skullLightIntensity = config.BindConfigInOrder("Skull Light Settings", "Skulls Intensity", 1f, "The intensity of the Skull lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		skullLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		skullLightRange = config.BindConfigInOrder("Skull Light Settings", "Skulls Range", 6f, "The range of the Skull lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		skullLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		skullLightShadows = config.BindConfigInOrder("Skull Light Settings", "Skulls Shadow Type", ShadowsType.Soft, "Set Skull lighting Shadows.\n", synced: false);
		skullLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		chandelierLightIntensity = config.BindConfigInOrder("Chandelier Light Settings", "Chandelier Intensity", 1.8f, "The intensity of the Chandelier lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		chandelierLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		chandelierLightRange = config.BindConfigInOrder("Chandelier Light Settings", "Chandelier Range", 12f, "The range of the Chandelier lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		chandelierLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		chandelierLightShadows = config.BindConfigInOrder("Chandelier Light Settings", "Chandelier Shadow Type", ShadowsType.Soft, "Set Chandelier lighting Shadows.\n", synced: false);
		chandelierLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		wallLightIntensity = config.BindConfigInOrder("Wall Light Settings", "Wall Light Intensity", 1.5f, "The intensity of the Wall lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		wallLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		wallLightRange = config.BindConfigInOrder("Wall Light Settings", "Wall Light Range", 12f, "The range of the Wall lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		wallLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		wallLightShadows = config.BindConfigInOrder("Wall Light Settings", "Wall Light Shadow Type", ShadowsType.Soft, "Set Wall lighting Shadows.\n", synced: false);
		wallLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingLanternLightIntensity = config.BindConfigInOrder("Surtling Lantern Light Settings", "Surtling Lantern Intensity", 2f, "The intensity of the Surtling Lantern lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		surtlingLanternLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingLanternLightRange = config.BindConfigInOrder("Surtling Lantern Light Settings", "Surtling Lantern Range", 15f, "The range of the Surtling Lantern lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		surtlingLanternLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingLanternLightShadows = config.BindConfigInOrder("Surtling Lantern Light Settings", "Surtling Lantern Shadow Type", ShadowsType.Soft, "Set Surtling Lantern lighting Shadows.\n", synced: false);
		surtlingLanternLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingSingleLightIntensity = config.BindConfigInOrder("Surtling Single Light Settings", "Surtling Single Intensity", 2f, "The intensity of the Surtling Single Lamppost lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		surtlingSingleLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingSingleLightRange = config.BindConfigInOrder("Surtling Single Light Settings", "Surtling Single Range", 15f, "The range of the Surtling Single Lamppost lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		surtlingSingleLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingSingleLightShadows = config.BindConfigInOrder("Surtling Single Light Settings", "Surtling Single Shadow Type", ShadowsType.Soft, "Set Surtling Single Lamppost lighting Shadows.\n", synced: false);
		surtlingSingleLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingDoubleLightIntensity = config.BindConfigInOrder("Surtling Double Light Settings", "Surtling Double Intensity", 2f, "The intensity of the Surtling Double Lamppost lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		surtlingDoubleLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingDoubleLightRange = config.BindConfigInOrder("Surtling Double Light Settings", "Surtling Double Range", 15f, "The range of the Surtling Double Lamppost lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		surtlingDoubleLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingDoubleLightShadows = config.BindConfigInOrder("Surtling Double Light Settings", "Surtling Double Shadow Type", ShadowsType.Soft, "Set Surtling Double Lamppost lighting Shadows.\n", synced: false);
		surtlingDoubleLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		lavaLightIntensity = config.BindConfigInOrder("Lava Light Settings", "Lava Light Intensity", 1.5f, "The intensity of the Lava Light lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		lavaLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		lavaLightRange = config.BindConfigInOrder("Lava Light Settings", "Lava Light Range", 12f, "The range of the Lava Light lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		lavaLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		lavaLightShadows = config.BindConfigInOrder("Lava Light Settings", "Lava Light Shadow Type", ShadowsType.Soft, "Set Lava Light Shadows.\n", synced: false);
		lavaLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		crystalLightIntensity = config.BindConfigInOrder("Crystal Light Settings", "Crystal Light Intensity", 2f, "The intensity of the Crystal Light lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		crystalLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		crystalLightRange = config.BindConfigInOrder("Crystal Light Settings", "Crystal Light Range", 12f, "The range of the Crystal Light lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		crystalLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		crystalLightShadows = config.BindConfigInOrder("Crystal Light Settings", "Crystal Light Shadow Type", ShadowsType.Soft, "Set Crystal Light Shadows.\n", synced: false);
		crystalLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		ropeLightIntensity = config.BindConfigInOrder("Rope Light Settings", "Rope Light Intensity", 1.5f, "The intensity of the Rope Light lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		ropeLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		ropeLightRange = config.BindConfigInOrder("Rope Light Settings", "Rope Light Range", 12f, "The range of the Rope Light lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		ropeLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		ropeLightShadows = config.BindConfigInOrder("Rope Light Settings", "Rope Light Shadow Type", ShadowsType.Soft, "Set Rope Light Shadows.\n", synced: false);
		ropeLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		brazierLightIntensity = config.BindConfigInOrder("Brazier Light Settings", "Brazier Light Intensity", 2f, "The intensity of the Brazier lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		brazierLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		brazierLightRange = config.BindConfigInOrder("Brazier Light Settings", "Brazier Light Range", 10f, "The range of the Brazier lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		brazierLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		brazierLightShadows = config.BindConfigInOrder("Brazier Light Settings", "Brazier Light Shadow Type", ShadowsType.Soft, "Set Brazier Light Shadows.\n", synced: false);
		brazierLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		beaconLightIntensity = config.BindConfigInOrder("Beacon Light Settings", "Beacon Light Intensity", 2f, "The intensity of the Beacon lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		beaconLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		beaconLightRange = config.BindConfigInOrder("Beacon Light Settings", "Beacon Light Range", 12f, "The range of the Beacon lighting.\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		beaconLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		beaconLightShadows = config.BindConfigInOrder("Beacon Light Settings", "Beacon Light Shadow Type", ShadowsType.Soft, "Set Beacon Light Shadows.\n", synced: false);
		beaconLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		
		ContainerRange = config.BindConfigInOrder("Auto-Feed Settings", "Container Range", 15f, "Defines the range in meters within which containers are checked for food items.\n");
        FeedCheckCooldown = config.BindConfigInOrder("Auto-Feed Settings", "Feed Check Cooldown", 2f, "Cooldown in seconds between feed checks. Checks only occur when the pet is hungry.\n");

        EnableProtectionToggle = config.BindConfigInOrder("Scarecrow Settings", "Enable Protection Toggle", true, "If On, the scarecrow protection can be toggled on and off. If Off, the scarecrow does nothing (no forcefield, no interaction).\n");
        EnableProtectionToggle.SettingChanged += CoreWoodPlugin.OnScarecrowConfigChanged;
        ShowForcefield = config.BindConfigInOrder("Scarecrow Settings", "Show Forcefield", true, "If Off, the scarecrow forcefield is hidden but still active.\n", synced: false);
        ShowForcefield.SettingChanged += CoreWoodPlugin.OnScarecrowConfigChanged;

        // Read live by every seed bed, so changes apply without a restart.
        SeedBedGerminationDuration = config.BindConfigInOrder("Seed Bed Settings", "Germination Duration", 4000f, "How many seconds it takes for seeds to finish germinating in the seed bed.\n(What can be germinated is set in BepInEx/config/CoreWoodExtras/SeedBedItems.json).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(60f, 5000f));
        SeedBedAutoHarvest = config.BindConfigInOrder("Seed Bed Settings", "Auto Harvest", false, "If On, the seed bed harvests itself as soon as the seeds finish germinating, and the produce appears at the seed bed.\n(No Farming or Herbalist XP is given for automatic harvests).\n", synced: true, sectionOrder: true, settingOrder: true);
        SeedBedAutoStore = config.BindConfigInOrder("Seed Bed Settings", "Auto Store", true, "If On, produce from an automatic harvest is stored in a feeding trough first (for food the trough accepts), otherwise in the nearest chest with room, instead of dropping at the seed bed.\n(Needs 'Auto Harvest'. Harvesting by hand always drops the produce at the seed bed).\n", synced: true, sectionOrder: true, settingOrder: true);
        SeedBedAutoReplant = config.BindConfigInOrder("Seed Bed Settings", "Auto Replant", false, "If On, the seed bed starts growing again after each harvest, whether it was harvested by hand or automatically.\n(Items that give themselves back, like Barley or Dandelion, are replanted from the harvest. Items like CarrotSeeds -> Carrot take their seeds from a chest within 'Auto Replant Range' instead, and wait until the chest has enough).\n", synced: true, sectionOrder: true, settingOrder: true);
        SeedBedChestRange = config.BindConfigInOrder("Seed Bed Settings", "Chest Range", 15f, "Range in meters within which the seed bed looks for chests. It takes seeds from the nearest one when replanting, and, with 'Auto Store' on, stores automatic harvests in the nearest one with room (the produce drops at the seed bed if there is none).\n(Only chests the person who built the seed bed could open are used).\n",synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 30f));
        SeedBedHarvestDelay = config.BindConfigInOrder("Seed Bed Settings", "Harvest Delay", 1.5f, "Delay in seconds between harvesting the seed bed and the produce appearing.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 3f));
        SeedBedFarmingExp = config.BindConfigInOrder("Seed Bed Settings", "Farming XP", 1f, "XP given to the Farming skill each time the seed bed is harvested.\n(Needs the Farming mod, does nothing if the skill does not exist).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.01f, 1f));
        SeedBedHerbalistExp = config.BindConfigInOrder("Seed Bed Settings", "Herbalist XP", 1f, "XP given to the Herbalist skill when a herb is harvested from the seed bed.\n(Needs the Herbalist mod, does nothing if the skill does not exist).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.01f, 5f));
    }

    private static void SetLightIntensity(string prefab, float intensity)
	{
		GameObject prefab2 = PrefabManager.Cache.GetPrefab<GameObject>(prefab);
		if ((bool)prefab2)
		{
			Light[] componentsInChildren = prefab2.GetComponentsInChildren<Light>(includeInactive: true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].intensity = intensity;
			}
		}
	}

	private static void SetLightRange(string prefab, float range)
	{
		GameObject prefab2 = PrefabManager.Cache.GetPrefab<GameObject>(prefab);
		if ((bool)prefab2)
		{
			Light[] componentsInChildren = prefab2.GetComponentsInChildren<Light>(includeInactive: true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].range = range;
			}
		}
	}
}
