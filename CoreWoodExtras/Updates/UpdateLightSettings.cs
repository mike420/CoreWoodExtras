using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras.Updates;

internal class UpdateLightSettings
{
	public static void LightSettingsChanged()
	{
		GameObject prefab = PrefabManager.Instance.GetPrefab("mm_horn_walltorch");
		if (prefab != null)
		{
			Light componentInChildren = prefab.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren.intensity = MainConfig.wallLightIntensity.Value;
			componentInChildren.range = MainConfig.wallLightRange.Value;
			if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren.shadows = LightShadows.None;
				return;
			}
			if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren.shadows = LightShadows.Hard;
				return;
			}
			if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren.shadows = LightShadows.Soft;
			}
		}
		GameObject prefab2 = PrefabManager.Instance.GetPrefab("mm_deerchandelier");
		if (prefab2 != null)
		{
			Light[] componentsInChildren = prefab2.GetComponentsInChildren<Light>(includeInactive: true);
			foreach (Light light in componentsInChildren)
			{
				light.intensity = MainConfig.chandelierLightIntensity.Value;
				light.range = MainConfig.chandelierLightRange.Value;
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
		GameObject prefab3 = PrefabManager.Instance.GetPrefab("mm_corewood_skull_candles");
		if (prefab3 != null)
		{
			Light[] componentsInChildren = prefab3.GetComponentsInChildren<Light>(includeInactive: true);
			foreach (Light light2 in componentsInChildren)
			{
				light2.intensity = MainConfig.skullLightIntensity.Value;
				light2.range = MainConfig.skullLightRange.Value;
				if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.None)
				{
					light2.shadows = LightShadows.None;
				}
				else if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.Hard)
				{
					light2.shadows = LightShadows.Hard;
				}
				else if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.Soft)
				{
					light2.shadows = LightShadows.Soft;
				}
			}
		}
		GameObject prefab4 = PrefabManager.Instance.GetPrefab("mm_corewood_lavalantern");
		if (prefab4 != null)
		{
			Light componentInChildren2 = prefab4.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren2.intensity = MainConfig.lavaLightIntensity.Value;
			componentInChildren2.range = MainConfig.lavaLightRange.Value;
			if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren2.shadows = LightShadows.None;
				return;
			}
			if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren2.shadows = LightShadows.Hard;
				return;
			}
			if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren2.shadows = LightShadows.Soft;
			}
		}
		GameObject prefab5 = PrefabManager.Instance.GetPrefab("mm_corewood_surtling_lantern");
		if (prefab5 != null)
		{
			Light componentInChildren3 = prefab5.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren3.intensity = MainConfig.surtlingLanternLightIntensity.Value;
			componentInChildren3.range = MainConfig.surtlingLanternLightRange.Value;
			if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren3.shadows = LightShadows.None;
				return;
			}
			if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren3.shadows = LightShadows.Hard;
				return;
			}
			if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren3.shadows = LightShadows.Soft;
			}
		}
		GameObject prefab6 = PrefabManager.Instance.GetPrefab("mm_corewood_surtling_lamppost_single");
		if (prefab6 != null)
		{
			Light componentInChildren4 = prefab6.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren4.intensity = MainConfig.surtlingSingleLightIntensity.Value;
			componentInChildren4.range = MainConfig.surtlingSingleLightRange.Value;
			if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren4.shadows = LightShadows.None;
				return;
			}
			if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren4.shadows = LightShadows.Hard;
				return;
			}
			if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren4.shadows = LightShadows.Soft;
			}
		}
		GameObject prefab7 = PrefabManager.Instance.GetPrefab("mm_corewood_surtling_lamppost_double");
		if (prefab7 != null)
		{
			Light[] componentsInChildren = prefab7.GetComponentsInChildren<Light>(includeInactive: true);
			foreach (Light light3 in componentsInChildren)
			{
				light3.intensity = MainConfig.surtlingDoubleLightIntensity.Value;
				light3.range = MainConfig.surtlingDoubleLightRange.Value;
				if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.None)
				{
					light3.shadows = LightShadows.None;
				}
				else if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.Hard)
				{
					light3.shadows = LightShadows.Hard;
				}
				else if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.Soft)
				{
					light3.shadows = LightShadows.Soft;
				}
			}
		}
		GameObject prefab8 = PrefabManager.Instance.GetPrefab("mm_corewood_crystal_light");
		if (prefab8 != null)
		{
			Light componentInChildren5 = prefab8.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren5.intensity = MainConfig.crystalLightIntensity.Value;
			componentInChildren5.range = MainConfig.crystalLightRange.Value;
			if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren5.shadows = LightShadows.None;
				return;
			}
			if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren5.shadows = LightShadows.Hard;
				return;
			}
			if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren5.shadows = LightShadows.Soft;
			}
		}
		GameObject prefab9 = PrefabManager.Instance.GetPrefab("mm_corewood_rope_lights");
		if (prefab9 != null)
		{
			Light[] componentsInChildren = prefab9.GetComponentsInChildren<Light>(includeInactive: true);
			foreach (Light light4 in componentsInChildren)
			{
				light4.intensity = MainConfig.ropeLightIntensity.Value;
				light4.range = MainConfig.ropeLightRange.Value;
				if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.None)
				{
					light4.shadows = LightShadows.None;
				}
				else if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.Hard)
				{
					light4.shadows = LightShadows.Hard;
				}
				else if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.Soft)
				{
					light4.shadows = LightShadows.Soft;
				}
			}
		}
		GameObject prefab10 = PrefabManager.Instance.GetPrefab("mm_corewood_brazier");
		if (prefab10 != null)
		{
			Light componentInChildren6 = prefab10.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren6.intensity = MainConfig.brazierLightIntensity.Value;
			componentInChildren6.range = MainConfig.brazierLightRange.Value;
			if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren6.shadows = LightShadows.None;
				return;
			}
			if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren6.shadows = LightShadows.Hard;
				return;
			}
			if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren6.shadows = LightShadows.Soft;
			}
		}
		GameObject prefab11 = PrefabManager.Instance.GetPrefab("mm_corewood_palisade_beacon");
		if (prefab11 != null)
		{
			Light componentInChildren7 = prefab11.GetComponentInChildren<Light>(includeInactive: true);
			componentInChildren7.intensity = MainConfig.beaconLightIntensity.Value;
			componentInChildren7.range = MainConfig.beaconLightRange.Value;
			if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.None)
			{
				componentInChildren7.shadows = LightShadows.None;
			}
			else if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				componentInChildren7.shadows = LightShadows.Hard;
			}
			else if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				componentInChildren7.shadows = LightShadows.Soft;
			}
		}
	}
}
