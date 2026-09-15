using BepInEx.Configuration;
using Jotunn.Extensions;
using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras;

internal static class MainConfig
{
	internal enum GlobalTraderKeys
	{
		defeated_bonemass,
		defeated_gdking,
		defeated_goblinking,
		defeated_dragon,
		defeated_eikthyr,
		defeated_queen,
		defeated_fader,
		defeated_serpent,
		KilledTroll,
		killed_surtling,
		KilledBat,
		None
	}

	public enum ShadowsType
	{
		None,
		Hard,
		Soft
	}

	internal const string GeneralSection = "General Settings";

	public static ConfigEntry<bool> modEnabled;

	public static ConfigEntry<bool> disableHDTextures;

	public static ConfigEntry<bool> toiletEffects;

	public static ConfigEntry<bool> enableElevators;

	public static ConfigEntry<bool> autoTriggers;

	internal const string ChestSection = "Chest Settings";

	public static ConfigEntry<int> chestColumns;

	public static ConfigEntry<int> chestRows;

	public static ConfigEntry<int> chestPrivateColumns;

	public static ConfigEntry<int> chestPrivateRows;

	public static ConfigEntry<int> chestStackedColumns;

	public static ConfigEntry<int> chestStackedRows;

	public static ConfigEntry<bool> chestStackedHotbar;

	internal const string SkullLightSection = "Skull Light Settings";

	public static ConfigEntry<float> skullLightIntensity;

	public static ConfigEntry<float> skullLightRange;

	public static ConfigEntry<ShadowsType> skullLightShadows;

	internal const string ChandelierLightSection = "Chandelier Light Settings";

	public static ConfigEntry<float> chandelierLightIntensity;

	public static ConfigEntry<float> chandelierLightRange;

	public static ConfigEntry<ShadowsType> chandelierLightShadows;

	internal const string WallLightSection = "Wall Light Settings";

	public static ConfigEntry<float> wallLightIntensity;

	public static ConfigEntry<float> wallLightRange;

	public static ConfigEntry<ShadowsType> wallLightShadows;

	internal const string LanternLightSection = "Surtling Lantern Light Settings";

	public static ConfigEntry<float> surtlingLanternLightIntensity;

	public static ConfigEntry<float> surtlingLanternLightRange;

	public static ConfigEntry<ShadowsType> surtlingLanternLightShadows;

	internal const string SingleLightSection = "Surtling Single Light Settings";

	public static ConfigEntry<float> surtlingSingleLightIntensity;

	public static ConfigEntry<float> surtlingSingleLightRange;

	public static ConfigEntry<ShadowsType> surtlingSingleLightShadows;

	internal const string DoubleLightSection = "Surtling Double Light Settings";

	public static ConfigEntry<float> surtlingDoubleLightIntensity;

	public static ConfigEntry<float> surtlingDoubleLightRange;

	public static ConfigEntry<ShadowsType> surtlingDoubleLightShadows;

	internal const string LavaLightSection = "Lava Light Settings";

	public static ConfigEntry<float> lavaLightIntensity;

	public static ConfigEntry<float> lavaLightRange;

	public static ConfigEntry<ShadowsType> lavaLightShadows;

	internal const string CrystalLightSection = "Crystal Light Settings";

	public static ConfigEntry<float> crystalLightIntensity;

	public static ConfigEntry<float> crystalLightRange;

	public static ConfigEntry<ShadowsType> crystalLightShadows;

	internal const string RopeLightSection = "Rope Light Settings";

	public static ConfigEntry<float> ropeLightIntensity;

	public static ConfigEntry<float> ropeLightRange;

	public static ConfigEntry<ShadowsType> ropeLightShadows;

	internal const string BrazierLightSection = "Brazier Light Settings";

	public static ConfigEntry<float> brazierLightIntensity;

	public static ConfigEntry<float> brazierLightRange;

	public static ConfigEntry<ShadowsType> brazierLightShadows;

	internal const string BeaconLightSection = "Beacon Light Settings";

	public static ConfigEntry<float> beaconLightIntensity;

	public static ConfigEntry<float> beaconLightRange;

	public static ConfigEntry<ShadowsType> beaconLightShadows;

	internal const string TraderSection = "Trader Settings";

	public static ConfigEntry<bool> traderEnabled;

	public static ConfigEntry<int> barleyWineStack;

	public static ConfigEntry<int> barleyWinePrice;

	public static ConfigEntry<string> barleyWineKey;

	public static ConfigEntry<bool> barleyWineEnabled;

	public static ConfigEntry<int> frostResistStack;

	public static ConfigEntry<int> frostResistPrice;

	public static ConfigEntry<string> frostResistKey;

	public static ConfigEntry<bool> frostResistEnabled;

	public static ConfigEntry<int> poisonResistStack;

	public static ConfigEntry<int> poisonResistPrice;

	public static ConfigEntry<string> poisonResistKey;

	public static ConfigEntry<bool> poisonResistEnabled;

	public static ConfigEntry<int> healthMinorStack;

	public static ConfigEntry<int> healthMinorPrice;

	public static ConfigEntry<string> healthMinorKey;

	public static ConfigEntry<bool> healthMinorEnabled;

	public static ConfigEntry<int> healthMediumStack;

	public static ConfigEntry<int> healthMediumPrice;

	public static ConfigEntry<string> healthMediumKey;

	public static ConfigEntry<bool> healthMediumEnabled;

	public static ConfigEntry<int> healthMajorStack;

	public static ConfigEntry<int> healthMajorPrice;

	public static ConfigEntry<string> healthMajorKey;

	public static ConfigEntry<bool> healthMajorEnabled;

	public static ConfigEntry<int> healthLingeringStack;

	public static ConfigEntry<int> healthLingeringPrice;

	public static ConfigEntry<string> healthLingeringKey;

	public static ConfigEntry<bool> healthLingeringEnabled;

	public static ConfigEntry<int> staminaMinorStack;

	public static ConfigEntry<int> staminaMinorPrice;

	public static ConfigEntry<string> staminaMinorKey;

	public static ConfigEntry<bool> staminaMinorEnabled;

	public static ConfigEntry<int> staminaMediumStack;

	public static ConfigEntry<int> staminaMediumPrice;

	public static ConfigEntry<string> staminaMediumKey;

	public static ConfigEntry<bool> staminaMediumEnabled;

	public static ConfigEntry<int> staminaLingeringStack;

	public static ConfigEntry<int> staminaLingeringPrice;

	public static ConfigEntry<string> staminaLingeringKey;

	public static ConfigEntry<bool> staminaLingeringEnabled;

	public static ConfigEntry<int> eitrMinorStack;

	public static ConfigEntry<int> eitrMinorPrice;

	public static ConfigEntry<string> eitrMinorKey;

	public static ConfigEntry<bool> eitrMinorEnabled;

	public static ConfigEntry<int> eitrLingeringStack;

	public static ConfigEntry<int> eitrLingeringPrice;

	public static ConfigEntry<string> eitrLingeringKey;

	public static ConfigEntry<bool> eitrLingeringEnabled;

	public static ConfigEntry<int> meadBzerkerStack;

	public static ConfigEntry<int> meadBzerkerPrice;

	public static ConfigEntry<string> meadBzerkerKey;

	public static ConfigEntry<bool> meadBzerkerEnabled;

	public static ConfigEntry<int> bugRepellentStack;

	public static ConfigEntry<int> bugRepellentPrice;

	public static ConfigEntry<string> bugRepellentKey;

	public static ConfigEntry<bool> bugRepellentEnabled;

	public static ConfigEntry<int> trollPheromonesStack;

	public static ConfigEntry<int> trollPheromonesPrice;

	public static ConfigEntry<string> trollPheromonesKey;

	public static ConfigEntry<bool> trollPheromonesEnabled;

	public static ConfigEntry<int> meadTastyStack;

	public static ConfigEntry<int> meadTastyPrice;

	public static ConfigEntry<string> meadTastyKey;

	public static ConfigEntry<bool> meadTastyEnabled;

	public static ConfigEntry<int> meadSwimmerStack;

	public static ConfigEntry<int> meadSwimmerPrice;

	public static ConfigEntry<string> meadSwimmerKey;

	public static ConfigEntry<bool> meadSwimmerEnabled;

	public static ConfigEntry<int> meadHastyStack;

	public static ConfigEntry<int> meadHastyPrice;

	public static ConfigEntry<string> meadHastyKey;

	public static ConfigEntry<bool> meadHastyEnabled;

	public static ConfigEntry<int> meadStrengthStack;

	public static ConfigEntry<int> meadStrengthPrice;

	public static ConfigEntry<string> meadStrengthKey;

	public static ConfigEntry<bool> meadStrengthEnabled;

	public static ConfigEntry<int> meadTamerStack;

	public static ConfigEntry<int> meadTamerPrice;

	public static ConfigEntry<string> meadTamerKey;

	public static ConfigEntry<bool> meadTamerEnabled;

	public static ConfigEntry<int> meadLightfootStack;

	public static ConfigEntry<int> meadLightfootPrice;

	public static ConfigEntry<string> meadLightfootKey;

	public static ConfigEntry<bool> meadLightfootEnabled;

	public static void InitConfigs(ConfigFile config)
	{
		modEnabled = config.BindConfigInOrder("General Settings", "Enable Plugin", defaultValue: true, "Enable the CoreWoodExtras plugin.\n");
		disableHDTextures = config.BindConfigInOrder("General Settings", "Disable HD", defaultValue: false, "Enabling this will set the textures look more vanilla like.\n(using point filter instead of trilinear).\n(Restart required).\n", synced: false);
		disableHDTextures.SettingChanged += CoreWoodPlugin.OnMainConfigChanged;
		toiletEffects = config.BindConfigInOrder("General Settings", "Toilet Effects", defaultValue: true, "Enable the toilet effects.\n(Restart or rebuild).\n", synced: false);
		toiletEffects.SettingChanged += CoreWoodPlugin.OnMainConfigChanged;
		enableElevators = config.BindConfigInOrder("General Settings", "Enable Elevators", defaultValue: true, "If Off, elevators will be disabled.\n(Restart required).\n");
		enableElevators.SettingChanged += CoreWoodPlugin.OnMainConfigChanged;
		autoTriggers = config.BindConfigInOrder("General Settings", "Automatic Elevators", defaultValue: true, "If On, elevators will move automatically when a player steps on it.\n", synced: false);
		autoTriggers.SettingChanged += CoreWoodPlugin.OnMainConfigChanged;
		chestColumns = config.BindConfigInOrder("Chest Settings", "Chest Columns", 6, "Amount of columns for core wood chest container.\n(Restart or rebuild chest).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 8));
		chestColumns.SettingChanged += CoreWoodPlugin.OnChestConfigChanged;
		chestRows = config.BindConfigInOrder("Chest Settings", "Chest Rows", 4, "Amount of columns for core wood chest container.\n(Restart or rebuild chest).\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10));
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
		skullLightIntensity = config.BindConfigInOrder("Skull Light Settings", "Skulls Intensity", 1f, "The intensity of the Skull lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		skullLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		skullLightRange = config.BindConfigInOrder("Skull Light Settings", "Skulls Range", 6f, "The range of the Skull lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		skullLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		skullLightShadows = config.BindConfigInOrder("Skull Light Settings", "Skulls Shadow Type", ShadowsType.Soft, "Set Skull lighting Shadows.\n(Restart or rebuild light).\n", synced: false);
		skullLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		chandelierLightIntensity = config.BindConfigInOrder("Chandelier Light Settings", "Chandelier Intensity", 1.8f, "The intensity of the Chandelier lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		chandelierLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		chandelierLightRange = config.BindConfigInOrder("Chandelier Light Settings", "Chandelier Range", 12f, "The range of the Chandelier lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		chandelierLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		chandelierLightShadows = config.BindConfigInOrder("Chandelier Light Settings", "Chandelier Shadow Type", ShadowsType.Soft, "Set Chandelier lighting Shadows.\n(Restart or rebuild light).\n", synced: false);
		chandelierLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		wallLightIntensity = config.BindConfigInOrder("Wall Light Settings", "Wall Light Intensity", 1.5f, "The intensity of the Wall lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		wallLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		wallLightRange = config.BindConfigInOrder("Wall Light Settings", "Wall Light Range", 12f, "The range of the Wall lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		wallLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		wallLightShadows = config.BindConfigInOrder("Wall Light Settings", "Wall Light Shadow Type", ShadowsType.Soft, "Set Wall lighting Shadows.\n(Restart or rebuild light).\n", synced: false);
		wallLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingLanternLightIntensity = config.BindConfigInOrder("Surtling Lantern Light Settings", "Surtling Lantern Intensity", 2f, "The intensity of the Surtling Lantern lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		surtlingLanternLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingLanternLightRange = config.BindConfigInOrder("Surtling Lantern Light Settings", "Surtling Lantern Range", 15f, "The range of the Surtling Lantern lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		surtlingLanternLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingLanternLightShadows = config.BindConfigInOrder("Surtling Lantern Light Settings", "Surtling Lantern Shadow Type", ShadowsType.Soft, "Set Surtling Lantern lighting Shadows.\n(Restart or rebuild light).\n", synced: false);
		surtlingLanternLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingSingleLightIntensity = config.BindConfigInOrder("Surtling Single Light Settings", "Surtling Single Intensity", 2f, "The intensity of the Surtling Single Lamppost lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		surtlingSingleLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingSingleLightRange = config.BindConfigInOrder("Surtling Single Light Settings", "Surtling Single Range", 15f, "The range of the Surtling Single Lamppost lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		surtlingSingleLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingSingleLightShadows = config.BindConfigInOrder("Surtling Single Light Settings", "Surtling Single Shadow Type", ShadowsType.Soft, "Set Surtling Single Lamppost lighting Shadows.\n(Restart or rebuild light).\n", synced: false);
		surtlingSingleLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingDoubleLightIntensity = config.BindConfigInOrder("Surtling Double Light Settings", "Surtling Double Intensity", 2f, "The intensity of the Surtling Double Lamppost lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		surtlingDoubleLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingDoubleLightRange = config.BindConfigInOrder("Surtling Double Light Settings", "Surtling Double Range", 15f, "The range of the Surtling Double Lamppost lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		surtlingDoubleLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		surtlingDoubleLightShadows = config.BindConfigInOrder("Surtling Double Light Settings", "Surtling Double Shadow Type", ShadowsType.Soft, "Set Surtling Double Lamppost lighting Shadows.\n(Restart or rebuild light).\n", synced: false);
		surtlingDoubleLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		lavaLightIntensity = config.BindConfigInOrder("Lava Light Settings", "Lava Light Intensity", 1.5f, "The intensity of the Lava Light lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		lavaLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		lavaLightRange = config.BindConfigInOrder("Lava Light Settings", "Lava Light Range", 12f, "The range of the Lava Light lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		lavaLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		lavaLightShadows = config.BindConfigInOrder("Lava Light Settings", "Lava Light Shadow Type", ShadowsType.Soft, "Set Lava Light Shadows.\n(Restart or rebuild light).\n", synced: false);
		lavaLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		crystalLightIntensity = config.BindConfigInOrder("Crystal Light Settings", "Crystal Light Intensity", 2f, "The intensity of the Crystal Light lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		crystalLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		crystalLightRange = config.BindConfigInOrder("Crystal Light Settings", "Crystal Light Range", 12f, "The range of the Crystal Light lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		crystalLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		crystalLightShadows = config.BindConfigInOrder("Crystal Light Settings", "Crystal Light Shadow Type", ShadowsType.Soft, "Set Crystal Light Shadows.\n(Restart or rebuild light).\n", synced: false);
		crystalLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		ropeLightIntensity = config.BindConfigInOrder("Rope Light Settings", "Rope Light Intensity", 1.5f, "The intensity of the Rope Light lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		ropeLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		ropeLightRange = config.BindConfigInOrder("Rope Light Settings", "Rope Light Range", 12f, "The range of the Rope Light lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		ropeLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		ropeLightShadows = config.BindConfigInOrder("Rope Light Settings", "Rope Light Shadow Type", ShadowsType.Soft, "Set Rope Light Shadows.\n(Restart or rebuild light).\n", synced: false);
		ropeLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		brazierLightIntensity = config.BindConfigInOrder("Brazier Light Settings", "Brazier Light Intensity", 2f, "The intensity of the Brazier lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		brazierLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		brazierLightRange = config.BindConfigInOrder("Brazier Light Settings", "Brazier Light Range", 10f, "The range of the Brazier lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		brazierLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		brazierLightShadows = config.BindConfigInOrder("Brazier Light Settings", "Brazier Light Shadow Type", ShadowsType.Soft, "Set Brazier Light Shadows.\n(Restart or rebuild light).\n", synced: false);
		brazierLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		beaconLightIntensity = config.BindConfigInOrder("Beacon Light Settings", "Beacon Light Intensity", 2f, "The intensity of the Beacon lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(0.1f, 4f));
		beaconLightIntensity.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		beaconLightRange = config.BindConfigInOrder("Beacon Light Settings", "Beacon Light Range", 12f, "The range of the Beacon lighting.\n(Restart or rebuild light).\n", synced: false, sectionOrder: true, settingOrder: true, new AcceptableValueRange<float>(1f, 20f));
		beaconLightRange.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		beaconLightShadows = config.BindConfigInOrder("Beacon Light Settings", "Beacon Light Shadow Type", ShadowsType.Soft, "Set Beacon Light Shadows.\n(Restart or rebuild light).\n", synced: false);
		beaconLightShadows.SettingChanged += CoreWoodPlugin.OnLightConfigChanged;
		traderEnabled = config.BindConfigInOrder("Trader Settings", "Enable Trader", defaultValue: true, "Enable Burt the barman.\n(Restart required).\n");
		barleyWineStack = config.BindConfigInOrder("Trader Settings", "Barley Wine Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		barleyWinePrice = config.BindConfigInOrder("Trader Settings", "Barley Wine Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		barleyWineKey = config.BindConfigInOrder("Trader Settings", "Barley Wine Key", "", "GlobalKey for item to be available.\n");
		barleyWineEnabled = config.BindConfigInOrder("Trader Settings", "Barley Wine Enabled", defaultValue: true, "Enable item to be sold by Burt.\n(Restart required).\n");
		frostResistStack = config.BindConfigInOrder("Trader Settings", "Frost Resist Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		frostResistPrice = config.BindConfigInOrder("Trader Settings", "Frost Resist Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		frostResistKey = config.BindConfigInOrder("Trader Settings", "Frost Resist Key", "", "GlobalKey for item to be available.\n");
		frostResistEnabled = config.BindConfigInOrder("Trader Settings", "Frost Resist Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		poisonResistStack = config.BindConfigInOrder("Trader Settings", "Poison Resist Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		poisonResistPrice = config.BindConfigInOrder("Trader Settings", "Poison Resist Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		poisonResistKey = config.BindConfigInOrder("Trader Settings", "Poison Resist Key", "", "GlobalKey for item to be available.\n");
		poisonResistEnabled = config.BindConfigInOrder("Trader Settings", "Poison Resist Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		healthMinorStack = config.BindConfigInOrder("Trader Settings", "Health Minor Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		healthMinorPrice = config.BindConfigInOrder("Trader Settings", "Health Minor Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		healthMinorKey = config.BindConfigInOrder("Trader Settings", "Health Minor Key", "", "GlobalKey for item to be available.\n");
		healthMinorEnabled = config.BindConfigInOrder("Trader Settings", "Health Minor Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		healthMediumStack = config.BindConfigInOrder("Trader Settings", "Health Medium Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		healthMediumPrice = config.BindConfigInOrder("Trader Settings", "Health Medium Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		healthMediumKey = config.BindConfigInOrder("Trader Settings", "Health Medium Key", "", "GlobalKey for item to be available.\n");
		healthMediumEnabled = config.BindConfigInOrder("Trader Settings", "Health Medium Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		healthMajorStack = config.BindConfigInOrder("Trader Settings", "Health Major Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		healthMajorPrice = config.BindConfigInOrder("Trader Settings", "Health Major Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		healthMajorKey = config.BindConfigInOrder("Trader Settings", "Health Major Key", "", "GlobalKey for item to be available.\n");
		healthMajorEnabled = config.BindConfigInOrder("Trader Settings", "Health Major Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		healthLingeringStack = config.BindConfigInOrder("Trader Settings", "Health Lingering Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		healthLingeringPrice = config.BindConfigInOrder("Trader Settings", "Health Lingering Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		healthLingeringKey = config.BindConfigInOrder("Trader Settings", "Health Lingering Key", "", "GlobalKey for item to be available.\n");
		healthLingeringEnabled = config.BindConfigInOrder("Trader Settings", "Health Lingering Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		staminaMinorStack = config.BindConfigInOrder("Trader Settings", "Stamina Minor Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		staminaMinorPrice = config.BindConfigInOrder("Trader Settings", "Stamina Minor Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		staminaMinorKey = config.BindConfigInOrder("Trader Settings", "Stamina Minor Key", "", "GlobalKey for item to be available.\n");
		staminaMinorEnabled = config.BindConfigInOrder("Trader Settings", "Stamina Minor Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		staminaMediumStack = config.BindConfigInOrder("Trader Settings", "Stamina Medium Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		staminaMediumPrice = config.BindConfigInOrder("Trader Settings", "Stamina Medium Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		staminaMediumKey = config.BindConfigInOrder("Trader Settings", "Stamina Medium Key", "", "GlobalKey for item to be available.\n");
		staminaMediumEnabled = config.BindConfigInOrder("Trader Settings", "Stamina Medium Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		staminaLingeringStack = config.BindConfigInOrder("Trader Settings", "Stamina Lingering Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		staminaLingeringPrice = config.BindConfigInOrder("Trader Settings", "Stamina Lingering Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		staminaLingeringKey = config.BindConfigInOrder("Trader Settings", "Stamina Lingering Key", "", "GlobalKey for item to be available.\n");
		staminaLingeringEnabled = config.BindConfigInOrder("Trader Settings", "Stamina Lingering Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		eitrMinorStack = config.BindConfigInOrder("Trader Settings", "Eitr Minor Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		eitrMinorPrice = config.BindConfigInOrder("Trader Settings", "Eitr Minor Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		eitrMinorKey = config.BindConfigInOrder("Trader Settings", "Eitr Minor Key", "", "GlobalKey for item to be available.\n");
		eitrMinorEnabled = config.BindConfigInOrder("Trader Settings", "Eitr Minor Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		eitrLingeringStack = config.BindConfigInOrder("Trader Settings", "Eitr Lingering Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		eitrLingeringPrice = config.BindConfigInOrder("Trader Settings", "Eitr Lingering Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		eitrLingeringKey = config.BindConfigInOrder("Trader Settings", "Eitr Lingering Key", "", "GlobalKey for item to be available.\n");
		eitrLingeringEnabled = config.BindConfigInOrder("Trader Settings", "Eitr Lingering Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		meadBzerkerStack = config.BindConfigInOrder("Trader Settings", "Mead Bzerker Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		meadBzerkerPrice = config.BindConfigInOrder("Trader Settings", "Mead Bzerker Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		meadBzerkerKey = config.BindConfigInOrder("Trader Settings", "Mead Bzerker Key", "", "GlobalKey for item to be available.\n");
		meadBzerkerEnabled = config.BindConfigInOrder("Trader Settings", "Mead Bzerker Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		bugRepellentStack = config.BindConfigInOrder("Trader Settings", "Bug Repellent Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		bugRepellentPrice = config.BindConfigInOrder("Trader Settings", "Bug Repellent Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		bugRepellentKey = config.BindConfigInOrder("Trader Settings", "Bug Repellent Key", "", "GlobalKey for item to be available.\n");
		bugRepellentEnabled = config.BindConfigInOrder("Trader Settings", "Bug Repellent Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		trollPheromonesStack = config.BindConfigInOrder("Trader Settings", "Troll Pheromones Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		trollPheromonesPrice = config.BindConfigInOrder("Trader Settings", "Troll Pheromones Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		trollPheromonesKey = config.BindConfigInOrder("Trader Settings", "Troll Pheromones Key", "", "GlobalKey for item to be available.\n");
		trollPheromonesEnabled = config.BindConfigInOrder("Trader Settings", "Troll Pheromones Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		meadTastyStack = config.BindConfigInOrder("Trader Settings", "Mead Tasty Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		meadTastyPrice = config.BindConfigInOrder("Trader Settings", "Mead Tasty Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		meadTastyKey = config.BindConfigInOrder("Trader Settings", "Mead Tasty Key", "", "GlobalKey for item to be available.\n");
		meadTastyEnabled = config.BindConfigInOrder("Trader Settings", "Mead Tasty Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		meadSwimmerStack = config.BindConfigInOrder("Trader Settings", "Mead Swimmer Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		meadSwimmerPrice = config.BindConfigInOrder("Trader Settings", "Mead Swimmer Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		meadSwimmerKey = config.BindConfigInOrder("Trader Settings", "Mead Swimmer Key", "", "GlobalKey for item to be available.\n");
		meadSwimmerEnabled = config.BindConfigInOrder("Trader Settings", "Mead Swimmer Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		meadHastyStack = config.BindConfigInOrder("Trader Settings", "Mead Hasty Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		meadHastyPrice = config.BindConfigInOrder("Trader Settings", "Mead Hasty Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		meadHastyKey = config.BindConfigInOrder("Trader Settings", "Mead Hasty Key", "", "GlobalKey for item to be available.\n");
		meadHastyEnabled = config.BindConfigInOrder("Trader Settings", "Mead Hasty Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		meadStrengthStack = config.BindConfigInOrder("Trader Settings", "Mead Strength Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		meadStrengthPrice = config.BindConfigInOrder("Trader Settings", "Mead Strength Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		meadStrengthKey = config.BindConfigInOrder("Trader Settings", "Mead Strength Key", "", "GlobalKey for item to be available.\n");
		meadStrengthEnabled = config.BindConfigInOrder("Trader Settings", "Mead Strength Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		meadTamerStack = config.BindConfigInOrder("Trader Settings", "Mead Tamer Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		meadTamerPrice = config.BindConfigInOrder("Trader Settings", "Mead Tamer Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		meadTamerKey = config.BindConfigInOrder("Trader Settings", "Mead Tamer Key", "", "GlobalKey for item to be available.\n");
		meadTamerEnabled = config.BindConfigInOrder("Trader Settings", "Mead Tamer Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
		meadLightfootStack = config.BindConfigInOrder("Trader Settings", "Mead Lightfoot Stack", 1, "Stack size for item.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 50));
		meadLightfootPrice = config.BindConfigInOrder("Trader Settings", "Mead Lightfoot Price", 100, "Price for item stack.\n", synced: true, sectionOrder: true, settingOrder: true, new AcceptableValueRange<int>(1, 10000));
		meadLightfootKey = config.BindConfigInOrder("Trader Settings", "Mead Lightfoot Key", "", "GlobalKey for item to be available.\n");
		meadLightfootEnabled = config.BindConfigInOrder("Trader Settings", "Mead Lightfoot Enabled", defaultValue: false, "Enable item to be sold by Burt.\n(Restart required).\n");
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
