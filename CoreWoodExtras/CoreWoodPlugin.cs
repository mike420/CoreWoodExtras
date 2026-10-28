using BepInEx;
using BepInEx.Configuration;
using CoreWoodExtras.Containers;
using CoreWoodExtras.Updates;
using HarmonyLib;
using Jotunn;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CoreWoodExtras;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
[BepInDependency("com.jotunn.jotunn", BepInDependency.DependencyFlags.HardDependency)]
[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Major)]
public class CoreWoodPlugin : BaseUnityPlugin
{
	public const string PluginName = "CoreWoodExtras";
	public const string PluginVersion = "2.4.1";
	public const string PluginAuthor = "MagicMike";
	internal const string PluginGUID = "MagicMike.CoreWoodExtras";
	internal const string PluginCopy = "Copyright © MagicMike 2026";
	public const string PluginLink = "https://discord.gg/mnr36G6J4x";

	private static char pds = Path.DirectorySeparatorChar;
	public static readonly string _basePath = BepInEx.Paths.ConfigPath + pds + "CoreWoodExtras";

	public static CoreWoodPlugin plugininstance;

    public static AssetBundle cwextras_new;
    public static string newBundle = "corewood_new";

    private Harmony harmony;

	internal static ConfigFile ConfigFile;
	internal static ConfigFileWatcher ConfigFileWatcher;

    public static CustomStatusEffect noMonstersStatus;

    public void Awake()
	{
		plugininstance = this;
		ConfigFile = base.Config;
		ConfigFileWatcher = new ConfigFileWatcher(base.Config, 1000L);
		base.Config.SaveOnConfigSet = false;
		MainConfig.InitConfigs(base.Config);
		MagicMike.ModSettings.ModSettings.Init(this);
		UpdatePlugin();

		if (MainConfig.modEnabled.Value)
		{
            CheckForFolders();
			Translations.Load(this);

            LoadAssetBundles();
            AddFXAssets();

            AddTraderItems();
            CustomTraderItems.Load();
            SeedBedConversions.Load();

            LoadStatusEffects();

            PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodItems;
			PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodBuilding;
            PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodDecor;
            PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodGreenhouse;
            PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodMarket;
            PrefabManager.OnVanillaPrefabsAvailable += LoadCoreWoodStructures;

            harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGUID);

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

	public void Update()
    {
        Translations.Tick();
        SeedBedConversions.BroadcastIfChanged();
    }

    public void OnDestroy()
    {
        Translations.Unload();
    }

    public static void CheckForFolders()
	{
		if (!Directory.Exists(_basePath))
		{
			Jotunn.Logger.LogInfo("Creating CoreWoodExtras Directory");
			Directory.CreateDirectory(_basePath);
		}
	}

    public static void LoadAssetBundles()
    {
        cwextras_new = LoadAssetBundle(newBundle);
    }

    private static AssetBundle LoadAssetBundle(string bundleName)
    {
        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), bundleName);
        AssetBundle bundle = File.Exists(path) ? AssetBundle.LoadFromFile(path) : null;
        if (bundle == null)
        {
            Jotunn.Logger.LogError("Failed to load asset bundle with name: " + bundleName + " (expected at " + path + ")");
        }
        return bundle;
    }

    public static void AddFXAssets()
    {
        try
        {
            CustomPrefab customPrefab = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_open_gate_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab);
            CustomPrefab customPrefab2 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_close_gate_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab2);
            CustomPrefab customPrefab3 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_open_bridge_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab3);
            CustomPrefab customPrefab4 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_break_glass_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab4);
            CustomPrefab customPrefab5 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_tower_bridge_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab5);
            CustomPrefab customPrefab6 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_elevator_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab6);
            CustomPrefab customPrefab7 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_elevator_long_mm"), fixReference: false);
            PrefabManager.Instance.AddPrefab(customPrefab7);
            CustomPrefab customPrefab8 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_water_fountain"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab8);
            CustomPrefab customPrefab9 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_frog_croaking"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab9);
            CustomPrefab customPrefab10 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_water_bucket"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab10);
            CustomPrefab customPrefab11 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_bartender_bye"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab11);
            CustomPrefab customPrefab12 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_bartender_greet"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab12);
            CustomPrefab customPrefab13 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_bartender_random"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab13);
            CustomPrefab customPrefab14 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_bartender_trade"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab14);
            CustomPrefab customPrefab15 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_shower_cwe"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab15);
            CustomPrefab customPrefab16 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_elevator_cwe_01"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab16);
            CustomPrefab customPrefab17 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_elevator_cwe_02"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab17);
            CustomPrefab customPrefab18 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_elevator_cwe_03"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab18);
            CustomPrefab customPrefab19 = new CustomPrefab(cwextras_new.LoadAsset<GameObject>("sfx_elevator_cwe_04"), fixReference: true);
            PrefabManager.Instance.AddPrefab(customPrefab19);
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError("Exception caught while loading Custom Sounds: " + ex.Message);
        }
    }

    private void AddTraderItems()
    {
        GameObject seed = cwextras_new != null ? cwextras_new.LoadAsset<GameObject>("mm_mystical_seed") : null;
        if (seed == null)
        {
            Jotunn.Logger.LogError("Could not load 'mm_mystical_seed' from the '" + newBundle + "' asset bundle, skipping the mystical seed.");
            return;
        }
        CustomItem customItem = new CustomItem(seed, fixReference: true);
        ItemManager.Instance.AddItem(customItem);
    }

    public static void LoadStatusEffects()
    {
        SE_Stats sE_Stats = cwextras_new != null ? cwextras_new.LoadAsset<SE_Stats>("NoMonstersStatusEffect") : null;
        if (sE_Stats == null)
        {
            Jotunn.Logger.LogError("Could not load 'NoMonstersStatusEffect' from the '" + newBundle + "' asset bundle, the scarecrow will not keep monsters away.");
            return;
        }
        sE_Stats.name = "NoMonstersStatusEffect";
        noMonstersStatus = new CustomStatusEffect(sE_Stats, fixReference: false);
        ItemManager.Instance.AddStatusEffect(noMonstersStatus);
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

    private void LoadCoreWoodGreenhouse()
    {
        try
        {
            AddGreenhouse.LoadPieces();
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError("Exception caught while loading Core Wood Greenhouse Prefabs: " + ex.Message);
        }
        finally
        {
            PrefabManager.OnVanillaPrefabsAvailable -= LoadCoreWoodGreenhouse;
        }
    }

    private void LoadCoreWoodMarket()
    {
        try
        {
            AddMarket.LoadPieces();
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError("Exception caught while loading Core Wood Market Prefabs: " + ex.Message);
        }
        finally
        {
            PrefabManager.OnVanillaPrefabsAvailable -= LoadCoreWoodMarket;
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


    public static void OnMainConfigChanged(object obj, EventArgs args)
	{
		if (SceneManager.GetActiveScene().name.Equals("main"))
		{
			UpdateMainSettings.MainSettingsChanged();
		}
	}

	public static void OnChestConfigChanged(object obj, EventArgs args)
	{
		if (SceneManager.GetActiveScene().name.Equals("main"))
		{
			UpdateChestSettings.ChestSettingsChanged();
		}
	}

	public static void OnLightConfigChanged(object obj, EventArgs args)
	{
		if (SceneManager.GetActiveScene().name.Equals("main"))
		{
			UpdateLightSettings.LightSettingsChanged();
		}
    }

    public static void OnScarecrowConfigChanged(object obj, EventArgs args)
    {
        if (SceneManager.GetActiveScene().name.Equals("main"))
        {
            UpdateScarecrowSettings.ScarecrowSettingsChanged();
        }
    }

    private void UpdatePlugin(bool saveConfig = true)
	{
		if (saveConfig)
		{
			base.Config.Save();
		}
    }

    internal const string FortifiedGUID = "MagicMike.CorewoodFortified";

    internal static bool FortifiedInstalled => BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(FortifiedGUID);

    internal static void TryAddPiece(Action addPiece)
    {
        try
        {
            addPiece();
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError("Exception caught while adding " + addPiece.Method.Name + ": " + ex);
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
