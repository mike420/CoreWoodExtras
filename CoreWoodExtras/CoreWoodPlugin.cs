using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using CoreWoodExtras.Containers;
using CoreWoodExtras.Updates;
using HarmonyLib;
using Jotunn;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CoreWoodExtras;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
[BepInDependency("com.jotunn.jotunn", BepInDependency.DependencyFlags.HardDependency)]
[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Major)]
public class CoreWoodPlugin : BaseUnityPlugin
{
	public const string PluginName = "CoreWoodExtras";
	public const string PluginVersion = "2.1.9";
	public const string PluginAuthor = "MagicMike";
	internal const string PluginGUID = "MagicMike.CoreWoodExtras";
	internal const string PluginCopy = "Copyright © MagicMike 2026";
	public const string PluginLink = "https://www.nexusmods.com/profile/MagicMikeMods/mods";

	private static char pds = Path.DirectorySeparatorChar;
	public static readonly string _basePath = BepInEx.Paths.ConfigPath + pds + "CoreWoodExtras";
	public static readonly string TranslationFilePath = _basePath + pds + "Translations";

	private CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

	public static CoreWoodPlugin plugininstance;

	public static AssetBundle cwextras;
	public static string extrasBundle = "corewoodextras";

	private Harmony harmony = new Harmony(PluginGUID);

	internal static ConfigFile ConfigFile;
	internal static ConfigFileWatcher ConfigFileWatcher;

	public static bool MainConfigChanged = false;
	public static bool ChestConfigChanged = false;
	public static bool LightConfigChanged = false;

	public void Awake()
	{
		plugininstance = this;
		ConfigFile = base.Config;
		ConfigFileWatcher = new ConfigFileWatcher(base.Config, 1000L);
		base.Config.SaveOnConfigSet = false;
		MainConfig.InitConfigs(base.Config);
		UpdatePlugin(saveConfig: true, initialUpdate: true);

		if (MainConfig.modEnabled.Value)
		{
            CheckForFolders();
			LocalisedText.AddLocalisations();
			LoadLocalisationData(TranslationFilePath);
			FileWatcher.WatchTranslationChanges(TranslationFilePath, delegate
			{
				LoadLocalisationData(TranslationFilePath);
			});

            LoadAssetBundle();
            AddFXAssets();
            AddTraderItems();

            PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodItems;
			PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodBuilding;
			PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodStructures;
			PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodDecor;
			PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodMisc;

			harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "MagicMike.CoreWoodExtras");

			ConfigFileWatcher.OnConfigFileReloaded += delegate
			{
				UpdatePlugin(saveConfig: false);
			};
			SynchronizationManager.OnConfigurationWindowClosed += delegate
			{
				UpdatePlugin();
			};
			SynchronizationManager.OnConfigurationSynchronized += delegate
			{
				UpdatePlugin();
			};

			Game.isModded = true;
		}
	}

	public void OnDestroy()
	{
	}

    public static void CheckForFolders()
	{
		if (!Directory.Exists(_basePath))
		{
			Jotunn.Logger.LogInfo("Creating CoreWoodExtras Directory");
			Directory.CreateDirectory(_basePath);
		}
		if (!Directory.Exists(TranslationFilePath))
		{
			Jotunn.Logger.LogInfo("Creating Translations folder");
			Directory.CreateDirectory(TranslationFilePath);
		}
	}

	public void LoadLocalisationData(string directory)
	{
		string[] fileSystemEntries = Directory.GetFileSystemEntries(directory, "*.json", SearchOption.AllDirectories);
		foreach (string path in fileSystemEntries)
		{
			string language = new DirectoryInfo(Path.GetDirectoryName(path)).Name;
			Path.GetFileNameWithoutExtension(path);
			Localization.AddJsonFile(language, File.ReadAllText(path));
		}
    }

    public static void LoadAssetBundle()
    {
        cwextras = AssetUtils.LoadAssetBundleFromResources(extrasBundle, Assembly.GetExecutingAssembly());
        if (cwextras == null)
        {
            Jotunn.Logger.LogError("Failed to load asset bundle with name: " + extrasBundle);
        }
    }

    public static void AddFXAssets()
    {
        try
        {
            CustomPrefab customPrefab = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_open_gate_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab);
            CustomPrefab customPrefab2 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_close_gate_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab2);
            CustomPrefab customPrefab3 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_open_bridge_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab3);
            CustomPrefab customPrefab4 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_break_glass_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab4);
            CustomPrefab customPrefab5 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_tower_bridge_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab5);
            CustomPrefab customPrefab6 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_elevator_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab6);
            CustomPrefab customPrefab7 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_elevator_long_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab7);
            CustomPrefab customPrefab8 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_water_fountain"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab8);
            CustomPrefab customPrefab9 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_frog_croaking"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab9);
            CustomPrefab customPrefab10 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_water_bucket"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab10);
            CustomPrefab customPrefab11 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_bartender_bye"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab11);
            CustomPrefab customPrefab12 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_bartender_greet"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab12);
            CustomPrefab customPrefab13 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_bartender_random"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab13);
            CustomPrefab customPrefab14 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_bartender_trade"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab14);
            CustomPrefab customPrefab15 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_shower_cwe"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab15);
            CustomPrefab customPrefab16 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_elevator_cwe_01"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab16);
            CustomPrefab customPrefab17 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_elevator_cwe_02"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab17);
            CustomPrefab customPrefab18 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_elevator_cwe_03"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab18);
            CustomPrefab customPrefab19 = new CustomPrefab(cwextras.LoadAsset<GameObject>("sfx_elevator_cwe_04"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab19);
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError("Exception caught while loading Custom Sounds: " + ex.Message);
        }
    }

    private void AddTraderItems()
    {
        CustomItem customItem = new CustomItem(cwextras.LoadAsset<GameObject>("mm_mystical_seed"), fixReference: true);
        ItemManager.Instance.AddItem(customItem);
    }

    private void LoadCoreWoodItems()
	{
		try
		{
			AddItems.LoadItems();
		}
		catch (Exception ex)
		{
			Jotunn.Logger.LogError("Exception caught while loading Core Wood Items: " + ex.Message);
		}
		finally
		{
			PrefabManager.OnVanillaPrefabsAvailable -= LoadCoreWoodItems;
		}
	}

	private void LoadCoreWoodBuilding()
	{
		try
		{
			AddBuilding.LoadPieces();
		}
		catch (Exception ex)
		{
			Jotunn.Logger.LogError("Exception caught while loading Core Wood Building Prefabs: " + ex.Message);
		}
		finally
		{
			PrefabManager.OnVanillaPrefabsAvailable -= LoadCoreWoodBuilding;
		}
	}

	private void LoadCoreWoodStructures()
	{
		try
		{
			AddStructures.LoadPieces();
		}
		catch (Exception ex)
		{
			Jotunn.Logger.LogError("Exception caught while loading Core Wood Structure Prefabs: " + ex.Message);
		}
		finally
		{
			PrefabManager.OnVanillaPrefabsAvailable -= LoadCoreWoodStructures;
		}
	}

	private void LoadCoreWoodDecor()
	{
		try
		{
			AddDecor.LoadPieces();
		}
		catch (Exception ex)
		{
			Jotunn.Logger.LogError("Exception caught while loading Core Wood Decor Prefabs: " + ex.Message);
		}
		finally
		{
			PrefabManager.OnVanillaPrefabsAvailable -= LoadCoreWoodDecor;
		}
	}

	private void LoadCoreWoodMisc()
	{
		try
		{
			AddMisc.LoadPieces();
		}
		catch (Exception ex)
		{
			Jotunn.Logger.LogError("Exception caught while loading Core Wood Misc Prefabs: " + ex.Message);
		}
		finally
		{
			PrefabManager.OnVanillaPrefabsAvailable -= LoadCoreWoodMisc;
		}
	}

	public static void OnMainConfigChanged(object obj, EventArgs args)
	{
		if (!MainConfigChanged)
		{
			MainConfigChanged = true;
		}
		if (SceneManager.GetActiveScene().name.Equals("main"))
		{
			UpdateMainSettings.MainSettingsChanged();
		}
	}

	public static void OnChestConfigChanged(object obj, EventArgs args)
	{
		if (!ChestConfigChanged)
		{
			ChestConfigChanged = true;
		}
		if (SceneManager.GetActiveScene().name.Equals("main"))
		{
			UpdateChestSettings.ChestSettingsChanged();
		}
	}

	public static void OnLightConfigChanged(object obj, EventArgs args)
	{
		if (!LightConfigChanged)
		{
			LightConfigChanged = true;
		}
		if (SceneManager.GetActiveScene().name.Equals("main"))
		{
			UpdateLightSettings.LightSettingsChanged();
		}
	}

	private void UpdatePlugin(bool saveConfig = true, bool initialUpdate = false)
	{
		if (MainConfigChanged || initialUpdate)
		{
			MainConfigChanged = false;
		}
		if (ChestConfigChanged || initialUpdate)
		{
			ChestConfigChanged = false;
		}
		if (LightConfigChanged || initialUpdate)
		{
			LightConfigChanged = false;
		}
		if (saveConfig)
		{
			base.Config.Save();
		}
    }

    public static GameObject PrepareContainer(GameObject prefab)
    {
        VisualStack visualStack = prefab.AddComponent<VisualStack>();
        MeshRenderer[] componentsInChildren = prefab.GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer meshRenderer in componentsInChildren)
        {
            if ((bool)meshRenderer.gameObject.GetComponent<MeshCollider>())
            {
                visualStack.stackMeshes.Add(meshRenderer.transform);
            }
        }
        return prefab;
    }
}
