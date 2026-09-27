using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;

namespace CoreWoodExtras;

public class LightPatches
{
	[HarmonyPatch(typeof(ZNetScene), "Awake")]
	[HarmonyAfter(new string[] { "com.jotunn.jotunn" })]
	public static class CustomLightPatch
	{
		[HarmonyPostfix]
		public static void Postfix(ZNetScene __instance)
		{
			ApplyAll(__instance.GetPrefab);
		}
	}

	private class LightEntry
	{
		public readonly string PrefabName;
		public readonly float Intensity;
		public readonly float Range;
		public readonly LightShadows Shadows;
		public readonly bool AllChildren;

		public LightEntry(string prefabName, float intensity, float range, MainConfig.ShadowsType shadows, bool allChildren)
		{
			PrefabName = prefabName;
			Intensity = intensity;
			Range = range;
			Shadows = ToLightShadows(shadows);
			AllChildren = allChildren;
		}
	}

	private static LightEntry[] GetEntries()
	{
		return new LightEntry[]
		{
			new LightEntry("mm_corewood_skull_candles", MainConfig.skullLightIntensity.Value, MainConfig.skullLightRange.Value, MainConfig.skullLightShadows.Value, allChildren: true),
			new LightEntry("mm_deerchandelier", MainConfig.chandelierLightIntensity.Value, MainConfig.chandelierLightRange.Value, MainConfig.chandelierLightShadows.Value, allChildren: true),
			new LightEntry("mm_corewood_surtling_lantern", MainConfig.surtlingLanternLightIntensity.Value, MainConfig.surtlingLanternLightRange.Value, MainConfig.surtlingLanternLightShadows.Value, allChildren: false),
			new LightEntry("mm_corewood_surtling_lamppost_single", MainConfig.surtlingSingleLightIntensity.Value, MainConfig.surtlingSingleLightRange.Value, MainConfig.surtlingSingleLightShadows.Value, allChildren: false),
			new LightEntry("mm_corewood_surtling_lamppost_double", MainConfig.surtlingDoubleLightIntensity.Value, MainConfig.surtlingDoubleLightRange.Value, MainConfig.surtlingDoubleLightShadows.Value, allChildren: true),
			new LightEntry("mm_horn_walltorch", MainConfig.wallLightIntensity.Value, MainConfig.wallLightRange.Value, MainConfig.wallLightShadows.Value, allChildren: false),
			new LightEntry("mm_corewood_lavalantern", MainConfig.lavaLightIntensity.Value, MainConfig.lavaLightRange.Value, MainConfig.lavaLightShadows.Value, allChildren: false),
			new LightEntry("mm_corewood_crystal_light", MainConfig.crystalLightIntensity.Value, MainConfig.crystalLightRange.Value, MainConfig.crystalLightShadows.Value, allChildren: false),
			new LightEntry("mm_corewood_rope_lights", MainConfig.ropeLightIntensity.Value, MainConfig.ropeLightRange.Value, MainConfig.ropeLightShadows.Value, allChildren: true),
			new LightEntry("mm_corewood_brazier", MainConfig.brazierLightIntensity.Value, MainConfig.brazierLightRange.Value, MainConfig.brazierLightShadows.Value, allChildren: false),
			new LightEntry("mm_corewood_palisade_beacon", MainConfig.beaconLightIntensity.Value, MainConfig.beaconLightRange.Value, MainConfig.beaconLightShadows.Value, allChildren: false),
		};
	}

	internal static void ApplyAll(Func<string, GameObject> getPrefab)
	{
		foreach (LightEntry entry in GetEntries())
		{
			ApplyToObject(getPrefab(entry.PrefabName), entry);
		}
	}

	internal static void ApplyToLiveInstances()
	{
		Dictionary<string, LightEntry> entries = new Dictionary<string, LightEntry>();
		foreach (LightEntry entry in GetEntries())
		{
			entries[entry.PrefabName] = entry;
		}
		foreach (ZNetView nview in UnityEngine.Object.FindObjectsByType<ZNetView>(FindObjectsSortMode.None))
		{
			if (entries.TryGetValue(Utils.GetPrefabName(nview.gameObject), out LightEntry entry))
			{
				ApplyToObject(nview.gameObject, entry);
			}
		}
	}

	private static void ApplyToObject(GameObject target, LightEntry entry)
	{
		if (!target)
		{
			return;
		}
		if (entry.AllChildren)
		{
			foreach (Light light in target.GetComponentsInChildren<Light>(includeInactive: true))
			{
				ApplyLight(light, entry);
			}
		}
		else
		{
			ApplyLight(target.GetComponentInChildren<Light>(includeInactive: true), entry);
		}
	}

	private static void ApplyLight(Light light, LightEntry entry)
	{
		if (!light)
		{
			return;
		}
		light.intensity = entry.Intensity;
		light.range = entry.Range;
		light.shadows = entry.Shadows;

		LightFlicker flicker = light.GetComponent<LightFlicker>();
		if (flicker)
		{
			Traverse.Create(flicker).Field("m_baseIntensity").SetValue(entry.Intensity);
		}
		LightLod lod = light.GetComponent<LightLod>();
		if (lod)
		{
			Traverse.Create(lod).Field("m_baseRange").SetValue(entry.Range);
		}
	}

	private static LightShadows ToLightShadows(MainConfig.ShadowsType type)
	{
		return type switch
		{
			MainConfig.ShadowsType.Hard => LightShadows.Hard,
			MainConfig.ShadowsType.Soft => LightShadows.Soft,
			_ => LightShadows.None,
		};
	}
}
