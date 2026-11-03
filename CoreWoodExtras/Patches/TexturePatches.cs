using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;

namespace CoreWoodExtras;

public class TexturePatches
{
	[HarmonyPatch(typeof(ZNetScene), "Awake")]
	private class ZNetSceneAwakeTexturePatch
	{
		[HarmonyPriority(200)]
		private static void Postfix(ZNetScene __instance)
		{
			zNetScene = __instance;
			if (MainConfig.disableHDTextures.Value)
			{
				ApplyTextureQuality();
			}
		}
	}

	private const string PieceTag = "mm_corewood";

	// Original material name -> low quality material name in the corewood_new bundle.
	private static readonly Dictionary<string, string> LowQualityNames = new Dictionary<string, string>
	{
		{ "carved_panel_01", "carved_panel_01_lq" },
		{ "carved_panel_02", "carved_panel_02_lq" },
		{ "carved_panel_03", "carved_panel_03_lq" },
		{ "carved_panel_04", "carved_panel_04_lq" },
		{ "corewood_log_flat", "corewood_log_flat_lq" },
		{ "corewood_log_flat_stump", "corewood_log_flat_lq" },
		{ "corewood_log_flat_worn", "corewood_log_flat_worn_lq" },
		{ "corewood_logwall", "corewood_logwall_lq" },
		{ "corewood_logwall_worn", "corewood_logwall_worn_lq" },
		{ "corewood_logwalls", "corelogs_lq" },
		{ "corewood_shower_planks", "wood_planks_lq" },
		{ "corewood_wood_bark", "log_bark_lq" },
		{ "wood_parts", "wood_parts_lq" },
		{ "wood_planks", "wood_planks_lq" },
		{ "wood_pole", "plank_wood_lq" },
		{ "workbench_wood", "wood_parts_lq" },
		{ "plank_wood", "plank_wood_lq" },
		{ "seamless_wood", "seamless_wood_lq" },
		{ "log_stump_01", "log_stump_lq" },
		{ "log_table", "log_table_lq" },
	};

	public static ZNetScene zNetScene;

	private static Dictionary<string, Material> lowQualityMaterials;

	// Prefab renderer -> its original (HD) materials, captured the first time it is swapped.
	private static readonly Dictionary<Renderer, Material[]> OriginalPrefabMaterials = new Dictionary<Renderer, Material[]>();

	private static bool prefabsSwapped;

	public static void ApplyTextureQuality()
	{
		if (!zNetScene)
		{
			return;
		}
		bool lowQuality = MainConfig.disableHDTextures.Value;
		if (lowQuality == prefabsSwapped)
		{
			return;
		}
		if (lowQuality && !LoadLowQualityMaterials())
		{
			return;
		}
		foreach (GameObject prefab in zNetScene.m_prefabs)
		{
			if (!prefab || !prefab.name.ToLower().Contains(PieceTag))
			{
				continue;
			}
			foreach (Renderer renderer in prefab.GetComponentsInChildren<Renderer>(includeInactive: true))
			{
				if (lowQuality)
				{
					SwapToLowQuality(renderer);
				}
				else if (OriginalPrefabMaterials.TryGetValue(renderer, out Material[] originals))
				{
					renderer.sharedMaterials = originals;
				}
			}
		}
		if (!lowQuality)
		{
			OriginalPrefabMaterials.Clear();
		}
		prefabsSwapped = lowQuality;
		UpdatePlacedPieces();
	}

	private static bool LoadLowQualityMaterials()
	{
		if (lowQualityMaterials != null)
		{
			return lowQualityMaterials.Count > 0;
		}
		lowQualityMaterials = new Dictionary<string, Material>();
		if (!CoreWoodPlugin.cwextras_new)
		{
			Jotunn.Logger.LogWarning("Disable HD: asset bundle " + CoreWoodPlugin.newBundle + " is not loaded, cannot swap materials.");
			return false;
		}
		foreach (string lqName in new HashSet<string>(LowQualityNames.Values))
		{
			Material material = CoreWoodPlugin.cwextras_new.LoadAsset<Material>(lqName);
			if (material)
			{
				lowQualityMaterials[lqName] = material;
			}
			else
			{
				Jotunn.Logger.LogWarning("Disable HD: low quality material '" + lqName + "' not found in " + CoreWoodPlugin.newBundle + ".");
			}
		}
		return lowQualityMaterials.Count > 0;
	}

	private static void SwapToLowQuality(Renderer renderer)
	{
		Material[] materials = renderer.sharedMaterials;
		bool changed = false;
		for (int i = 0; i < materials.Length; i++)
		{
			Material material = materials[i];
			if (!material || !LowQualityNames.TryGetValue(CleanName(material.name), out string lqName))
			{
				continue;
			}
			if (lowQualityMaterials.TryGetValue(lqName, out Material lqMaterial))
			{
				FixShader(lqMaterial, material);
				materials[i] = lqMaterial;
				changed = true;
			}
		}
		if (changed)
		{
			OriginalPrefabMaterials[renderer] = renderer.sharedMaterials;
			renderer.sharedMaterials = materials;
		}
	}

	private static readonly HashSet<Material> ShaderFixed = new HashSet<Material>();

	// Materials loaded straight from the bundle still use the placeholder shader, unlike the
	// piece prefabs, which Jotunn fixes. Give them the real shader the original material uses.
	private static void FixShader(Material lqMaterial, Material original)
	{
		if (!ShaderFixed.Add(lqMaterial))
		{
			return;
		}
		lqMaterial.shader = original.shader;
		lqMaterial.renderQueue = original.renderQueue;
		lqMaterial.shaderKeywords = original.shaderKeywords;
	}

	// Copies the (now swapped or restored) prefab materials onto pieces already placed in the world.
	private static void UpdatePlacedPieces()
	{
		foreach (ZNetView nview in Object.FindObjectsByType<ZNetView>(FindObjectsSortMode.None))
		{
			string prefabName = Utils.GetPrefabName(nview.gameObject);
			if (!prefabName.ToLower().Contains(PieceTag))
			{
				continue;
			}
			GameObject prefab = zNetScene.GetPrefab(prefabName);
			if (!prefab)
			{
				continue;
			}
			Renderer[] source = prefab.GetComponentsInChildren<Renderer>(includeInactive: true);
			Renderer[] target = nview.GetComponentsInChildren<Renderer>(includeInactive: true);
			if (source.Length != target.Length)
			{
				continue;
			}
			for (int i = 0; i < source.Length; i++)
			{
				target[i].sharedMaterials = source[i].sharedMaterials;
			}
		}
	}

	private static string CleanName(string name)
	{
		return name.Replace(" (Instance)", "").Trim();
	}
}
