using System.Collections.Generic;
using System.IO;
using HarmonyLib;
using UnityEngine;

namespace CoreWoodExtras;

// Enable Biome Overlays: swaps the wood, log and stone materials on each CoreWood piece for a "<name>_icy" version if
// the piece stands in the Mountain or Deep North, and a "<name>_mossy" version anywhere else. The versions are in the
// corewood_new bundle (made in Unity). Any material with a "<name>_mossy" and "<name>_icy" material in the bundle gets
// swapped, so adding a new overlay only takes adding those two materials. Nothing is built at runtime, and only
// materials used by CoreWood pieces change. The prefabs are left alone: each piece is decided by where it stands,
// when it appears and when the setting is switched on.
public static class BiomeOverlays
{
	[HarmonyPatch(typeof(ZNetScene), "Awake")]
	private static class ZNetSceneAwakePatch
	{
		[HarmonyPriority(Priority.VeryLow)]
		private static void Postfix()
		{
			Apply();
		}
	}

	[HarmonyPatch(typeof(ZNetView), "Awake")]
	private static class ZNetViewAwakePatch
	{
		private static void Postfix(ZNetView __instance)
		{
			if (applied && IsCoreWoodPiece(__instance.gameObject))
			{
				SwapPiece(__instance.gameObject);
			}
		}
	}

	private const string PieceTag = "mm_corewood";

	// Names (lower case) of the overlay materials in the bundle, e.g. "wood_planks_lq_mossy"
	private static HashSet<string> overlayAssets;

	private static HashSet<string> GetOverlayAssets()
	{
		if (overlayAssets != null)
		{
			return overlayAssets;
		}
		overlayAssets = new HashSet<string>();
		if (CoreWoodPlugin.cwextras_new)
		{
			foreach (string assetPath in CoreWoodPlugin.cwextras_new.GetAllAssetNames())
			{
				string name = Path.GetFileNameWithoutExtension(assetPath);
				if (assetPath.EndsWith(".mat") && (name.EndsWith("_mossy") || name.EndsWith("_icy")))
				{
					overlayAssets.Add(name);
				}
			}
		}
		return overlayAssets;
	}

	// [0] mossy, [1] icy. Material -> the overlay material standing in for it
	private static readonly Dictionary<Material, Material>[] OverlayByMaterial =
	{
		new Dictionary<Material, Material>(), new Dictionary<Material, Material>()
	};

	// Overlay material -> the material it replaced
	private static readonly Dictionary<Material, Material> OriginalByOverlay = new Dictionary<Material, Material>();

	// Overlay asset name -> the material loaded from the bundle (a second material needing it gets a copy)
	private static readonly Dictionary<string, Material> AssetsByName = new Dictionary<string, Material>();

	private static bool applied;

	public static void OnSettingChanged()
	{
		if (ZNetScene.instance)
		{
			Apply();
		}
	}

	public static void Apply()
	{
		bool wanted = MainConfig.biomeOverlays.Value;
		if (wanted == applied || !ZNetScene.instance)
		{
			return;
		}
		if (wanted && !CoreWoodPlugin.cwextras_new)
		{
			Jotunn.Logger.LogWarning("Biome Overlays: asset bundle " + CoreWoodPlugin.newBundle + " is not loaded.");
			return;
		}
		applied = wanted;
		if (wanted)
		{
			SwapAllPieces();
		}
		else
		{
			Revert();
		}
	}

	// Disable HD swaps materials by identity, so it asks for the overlays to come off first and go back on after.
	internal static void Suspend()
	{
		if (applied)
		{
			Revert();
		}
	}

	internal static void Resume()
	{
		if (applied)
		{
			SwapAllPieces();
		}
	}

	// Every slot that was swapped, so it can be put back exactly
	private sealed class Swap
	{
		public Renderer Renderer;
		public int Index;
		public Material Original;
		public Material Overlay;
	}

	private static readonly List<Swap> Swaps = new List<Swap>();

	private static bool IsCoreWoodPiece(GameObject gameObject)
	{
		return Utils.GetPrefabName(gameObject).ToLower().Contains(PieceTag);
	}

	// Mountain and Deep North are icy, everywhere else is mossy
	private static bool IsIcy(Vector3 position)
	{
		try
		{
			if (WorldGenerator.instance == null)
			{
				return false;
			}
			Heightmap.Biome biome = WorldGenerator.instance.GetBiome(position);
			return biome == Heightmap.Biome.Mountain || biome == Heightmap.Biome.DeepNorth;
		}
		catch (System.Exception)
		{
			return false;
		}
	}

	private static void SwapAllPieces()
	{
		int before = Swaps.Count, pieces = 0, icy = 0;
		foreach (ZNetView nview in Object.FindObjectsByType<ZNetView>(FindObjectsSortMode.None))
		{
			if (IsCoreWoodPiece(nview.gameObject))
			{
				pieces++;
				if (SwapPiece(nview.gameObject))
				{
					icy++;
				}
			}
		}
		Jotunn.Logger.LogInfo("[CoreWoodExtras] Biome Overlays: swapped in " + (Swaps.Count - before) + " material slots on " + pieces + " pieces (" + icy + " icy).");
	}

	// Returns true if the piece got the icy overlay
	private static bool SwapPiece(GameObject root)
	{
		bool icy = IsIcy(root.transform.position);
		foreach (Renderer renderer in root.GetComponentsInChildren<Renderer>(includeInactive: true))
		{
			Material[] materials = renderer.sharedMaterials;
			bool changed = false;
			for (int i = 0; i < materials.Length; i++)
			{
				Material original = materials[i];
				Material overlay = GetOverlay(original, icy);
				if (overlay)
				{
					materials[i] = overlay;
					Swaps.Add(new Swap { Renderer = renderer, Index = i, Original = original, Overlay = overlay });
					changed = true;
				}
			}
			if (changed)
			{
				renderer.sharedMaterials = materials;
			}
		}
		if (Swaps.Count > 4000 && Swaps.Count % 1000 == 0)
		{
			Swaps.RemoveAll(swap => !swap.Renderer);
		}
		return icy;
	}

	// The game can replace a slot's material with its own per-renderer copy, named "<name> (Instance)"
	private static bool IsOurs(Material held, Material overlay)
	{
		return held && (held == overlay || held.name == overlay.name + " (Instance)");
	}

	// Pieces already placed hold the game's own copies of the overlay materials ("<name> (Instance)"), which were not
	// recorded as swaps: find them by name and put the original back
	private static int RevertCopies()
	{
		Dictionary<string, Material> originals = new Dictionary<string, Material>();
		foreach (KeyValuePair<Material, Material> pair in OriginalByOverlay)
		{
			if (pair.Key)
			{
				originals[pair.Key.name] = pair.Value;
			}
		}
		int count = 0;
		foreach (ZNetView nview in Object.FindObjectsByType<ZNetView>(FindObjectsSortMode.None))
		{
			if (!IsCoreWoodPiece(nview.gameObject))
			{
				continue;
			}
			foreach (Renderer renderer in nview.GetComponentsInChildren<Renderer>(includeInactive: true))
			{
				Material[] materials = renderer.sharedMaterials;
				bool changed = false;
				for (int i = 0; i < materials.Length; i++)
				{
					if (materials[i] && originals.TryGetValue(materials[i].name.Replace(" (Instance)", "").Trim(), out Material original))
					{
						materials[i] = original;
						changed = true;
						count++;
					}
				}
				if (changed)
				{
					renderer.sharedMaterials = materials;
				}
			}
		}
		return count;
	}

	private static void Revert()
	{
		int reverted = 0;
		foreach (Swap swap in Swaps)
		{
			if (!swap.Renderer)
			{
				continue;
			}
			Material[] materials = swap.Renderer.sharedMaterials;
			if (swap.Index < materials.Length && IsOurs(materials[swap.Index], swap.Overlay))
			{
				materials[swap.Index] = swap.Original;
				swap.Renderer.sharedMaterials = materials;
				reverted++;
			}
		}
		int copies = RevertCopies();
		Jotunn.Logger.LogInfo("[CoreWoodExtras] Biome Overlays: swapped out " + reverted + " of " + Swaps.Count + " material slots, plus " + copies + " slots holding the game's copies.");
		Swaps.Clear();
	}

	private static Material GetOverlay(Material material, bool icy)
	{
		if (!material || OriginalByOverlay.ContainsKey(material))
		{
			return null;
		}
		Dictionary<Material, Material> cache = OverlayByMaterial[icy ? 1 : 0];
		if (cache.TryGetValue(material, out Material cached))
		{
			return cached;
		}
		Material overlay = null;
		string assetName = OverlayAssetName(material.name.Replace(" (Instance)", "").Trim(), icy);
		if (assetName != null)
		{
			EnsureRealShader(material);
			if (!AssetsByName.TryGetValue(assetName, out Material asset))
			{
				asset = CoreWoodPlugin.cwextras_new.LoadAsset<Material>(assetName);
				if (asset)
				{
					FixShader(asset, material);
				}
				else
				{
					Jotunn.Logger.LogWarning("Biome Overlays: material '" + assetName + "' not found in " + CoreWoodPlugin.newBundle + ".");
				}
				AssetsByName[assetName] = asset;
				overlay = asset;
			}
			else if (asset)
			{
				// Already standing in for another material: this one gets its own copy, so each maps back to exactly one
				overlay = new Material(asset) { name = asset.name + "_" + material.name };
			}
		}
		cache[material] = overlay;
		if (overlay)
		{
			OriginalByOverlay[overlay] = material;
		}
		return overlay;
	}

	// The overlay material for a material name, or null if the bundle has none
	private static string OverlayAssetName(string name, bool icy)
	{
		string assetName = name + (icy ? "_icy" : "_mossy");
		return GetOverlayAssets().Contains(assetName.ToLowerInvariant()) ? assetName : null;
	}

	private static Dictionary<string, Shader> loadedShaders;

	private const string Mock = "JVLmock_";

	private static string RealName(string name)
	{
		return name.StartsWith(Mock) ? name.Substring(Mock.Length) : name;
	}

	private static Shader FindShader(string name)
	{
		if (loadedShaders != null && loadedShaders.TryGetValue(name, out Shader found) && found)
		{
			return found;
		}
		loadedShaders = new Dictionary<string, Shader>();
		foreach (Shader shader in Resources.FindObjectsOfTypeAll<Shader>())
		{
			loadedShaders[shader.name] = shader;
		}
		return loadedShaders.TryGetValue(name, out found) ? found : null;
	}

	// Straight from the bundle a material has a placeholder ("JVLmock_...") shader, which draws wrongly. Give it the real
	// shader of the same name, whichever one it was given in Unity. When it is the same kind of shader as the material it
	// stands in for, take that material's queue and keywords too.
	private static void FixShader(Material mossy, Material original)
	{
		string own = mossy.shader ? mossy.shader.name : "";
		string originalName = original.shader ? RealName(original.shader.name) : "";
		if (own == "" || own == "Hidden/InternalErrorShader")
		{
			own = originalName;
			mossy.shader = original.shader;
		}
		string wanted = RealName(own);
		if (wanted == originalName && original.shader && !original.shader.name.StartsWith(Mock))
		{
			// The material it stands in for already renders with the real shader: use exactly that one
			mossy.shader = original.shader;
		}
		else if (own.StartsWith(Mock))
		{
			Shader real = FindShader(wanted);
			if (real)
			{
				mossy.shader = real;
			}
			else
			{
				Jotunn.Logger.LogWarning("Biome Overlays: shader '" + wanted + "' for '" + mossy.name + "' is not loaded in the game.");
			}
		}
		if (wanted == originalName)
		{
			mossy.renderQueue = original.renderQueue;
			mossy.shaderKeywords = original.shaderKeywords;
		}
	}

	// A material still holding its placeholder ("JVLmock_...") shader only gets the real one when Jotunn goes over the
	// materials on the pieces, and a material swapped out for a mossy one is missed: it would come back drawing wrongly
	// (see-through). So give it the real shader before it is swapped out.
	internal static void EnsureRealShader(Material material)
	{
		if (!material.shader || !material.shader.name.StartsWith(Mock))
		{
			return;
		}
		Shader real = FindShader(RealName(material.shader.name));
		if (!real)
		{
			Jotunn.Logger.LogWarning("Biome Overlays: shader '" + RealName(material.shader.name) + "' for '" + material.name + "' is not loaded in the game.");
			return;
		}
		int queue = material.renderQueue;
		string[] keywords = material.shaderKeywords;
		material.shader = real;
		material.renderQueue = queue;
		material.shaderKeywords = keywords;
	}
}
