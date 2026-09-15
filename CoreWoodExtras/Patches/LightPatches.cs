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
			ModifySkullCandles(__instance, "mm_corewood_skull_candles", MainConfig.skullLightIntensity.Value, MainConfig.skullLightRange.Value);
			ModifyDeerChandelier(__instance, "mm_deerchandelier", MainConfig.chandelierLightIntensity.Value, MainConfig.chandelierLightRange.Value);
			ModifySurtlingLantern(__instance, "mm_corewood_surtling_lantern", MainConfig.surtlingLanternLightIntensity.Value, MainConfig.surtlingLanternLightRange.Value);
			ModifySurtlingSingle(__instance, "mm_corewood_surtling_lamppost_single", MainConfig.surtlingSingleLightIntensity.Value, MainConfig.surtlingSingleLightRange.Value);
			ModifySurtlingDouble(__instance, "mm_corewood_surtling_lamppost_double", MainConfig.surtlingDoubleLightIntensity.Value, MainConfig.surtlingDoubleLightRange.Value);
			ModifyWallLights(__instance, "mm_horn_walltorch", MainConfig.wallLightIntensity.Value, MainConfig.wallLightRange.Value);
			ModifyLavaLights(__instance, "mm_corewood_lavalantern", MainConfig.lavaLightIntensity.Value, MainConfig.lavaLightRange.Value);
			ModifyCrystalLights(__instance, "mm_corewood_crystal_light", MainConfig.crystalLightIntensity.Value, MainConfig.crystalLightRange.Value);
			ModifyRopeLights(__instance, "mm_corewood_rope_lights", MainConfig.ropeLightIntensity.Value, MainConfig.ropeLightRange.Value);
			ModifyBrazierLights(__instance, "mm_corewood_brazier", MainConfig.brazierLightIntensity.Value, MainConfig.brazierLightRange.Value);
			ModifyBeaconLights(__instance, "mm_corewood_palisade_beacon", MainConfig.beaconLightIntensity.Value, MainConfig.beaconLightRange.Value);
		}
	}

	public static void ModifySkullCandles(ZNetScene instance, string prefab, float intensity, float range)
	{
		GameObject prefab2 = instance.GetPrefab(prefab);
		if (!prefab2)
		{
			return;
		}
		Light[] componentsInChildren = prefab2.GetComponentsInChildren<Light>(includeInactive: true);
		foreach (Light light in componentsInChildren)
		{
			light.intensity = intensity;
			light.range = range;
			if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.None)
			{
				light.shadows = LightShadows.None;
			}
			else if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				light.shadows = LightShadows.Hard;
			}
			else if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				light.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifyDeerChandelier(ZNetScene instance, string prefab, float intensity, float range)
	{
		GameObject prefab2 = instance.GetPrefab(prefab);
		if (!prefab2)
		{
			return;
		}
		Light[] componentsInChildren = prefab2.GetComponentsInChildren<Light>(includeInactive: true);
		foreach (Light light in componentsInChildren)
		{
			light.intensity = intensity;
			light.range = range;
			if (MainConfig.chandelierLightShadows.Value == MainConfig.ShadowsType.None)
			{
				light.shadows = LightShadows.None;
			}
			else if (MainConfig.chandelierLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				light.shadows = LightShadows.Hard;
			}
			else if (MainConfig.chandelierLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				light.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifySurtlingDouble(ZNetScene instance, string prefab, float intensity, float range)
	{
		GameObject prefab2 = instance.GetPrefab(prefab);
		if (!prefab2)
		{
			return;
		}
		Light[] componentsInChildren = prefab2.GetComponentsInChildren<Light>(includeInactive: true);
		foreach (Light light in componentsInChildren)
		{
			light.intensity = intensity;
			light.range = range;
			if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.None)
			{
				light.shadows = LightShadows.None;
			}
			else if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				light.shadows = LightShadows.Hard;
			}
			else if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				light.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifyRopeLights(ZNetScene instance, string prefab, float intensity, float range)
	{
		GameObject prefab2 = instance.GetPrefab(prefab);
		if (!prefab2)
		{
			return;
		}
		Light[] componentsInChildren = prefab2.GetComponentsInChildren<Light>(includeInactive: true);
		foreach (Light light in componentsInChildren)
		{
			light.intensity = intensity;
			light.range = range;
			if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.None)
			{
				light.shadows = LightShadows.None;
			}
			else if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				light.shadows = LightShadows.Hard;
			}
			else if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				light.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifySurtlingLantern(ZNetScene instance, string slprefab, float slintensity, float slrange)
	{
		GameObject prefab = instance.GetPrefab(slprefab);
		if ((bool)prefab)
		{
			Light componentInChildren = prefab.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren.intensity = slintensity;
			componentInChildren.range = slrange;
			if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren.shadows = LightShadows.None;
			}
			else if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren.shadows = LightShadows.Hard;
			}
			else if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifySurtlingSingle(ZNetScene instance, string ssprefab, float ssintensity, float ssrange)
	{
		GameObject prefab = instance.GetPrefab(ssprefab);
		if ((bool)prefab)
		{
			Light componentInChildren = prefab.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren.intensity = ssintensity;
			componentInChildren.range = ssrange;
			if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren.shadows = LightShadows.None;
			}
			else if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren.shadows = LightShadows.Hard;
			}
			else if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifyWallLights(ZNetScene instance, string wlprefab, float wlintensity, float wlrange)
	{
		GameObject prefab = instance.GetPrefab(wlprefab);
		if ((bool)prefab)
		{
			Light componentInChildren = prefab.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren.intensity = wlintensity;
			componentInChildren.range = wlrange;
			if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren.shadows = LightShadows.None;
			}
			else if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren.shadows = LightShadows.Hard;
			}
			else if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifyLavaLights(ZNetScene instance, string llprefab, float llintensity, float llrange)
	{
		GameObject prefab = instance.GetPrefab(llprefab);
		if ((bool)prefab)
		{
			Light componentInChildren = prefab.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren.intensity = llintensity;
			componentInChildren.range = llrange;
			if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren.shadows = LightShadows.None;
			}
			else if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren.shadows = LightShadows.Hard;
			}
			else if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifyCrystalLights(ZNetScene instance, string clprefab, float clintensity, float clrange)
	{
		GameObject prefab = instance.GetPrefab(clprefab);
		if ((bool)prefab)
		{
			Light componentInChildren = prefab.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren.intensity = clintensity;
			componentInChildren.range = clrange;
			if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren.shadows = LightShadows.None;
			}
			else if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren.shadows = LightShadows.Hard;
			}
			else if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifyBrazierLights(ZNetScene instance, string bprefab, float bintensity, float brange)
	{
		GameObject prefab = instance.GetPrefab(bprefab);
		if ((bool)prefab)
		{
			Light componentInChildren = prefab.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren.intensity = bintensity;
			componentInChildren.range = brange;
			if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren.shadows = LightShadows.None;
			}
			else if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren.shadows = LightShadows.Hard;
			}
			else if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren.shadows = LightShadows.Soft;
			}
		}
	}

	public static void ModifyBeaconLights(ZNetScene instance, string bcprefab, float bcintensity, float bcrange)
	{
		GameObject prefab = instance.GetPrefab(bcprefab);
		if ((bool)prefab)
		{
			Light componentInChildren = prefab.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren.intensity = bcintensity;
			componentInChildren.range = bcrange;
			if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren.shadows = LightShadows.None;
			}
			else if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren.shadows = LightShadows.Hard;
			}
			else if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren.shadows = LightShadows.Soft;
			}
		}
	}
}
