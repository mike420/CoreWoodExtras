using HarmonyLib;
using UnityEngine;

namespace CoreWoodExtras;

public class SoundPatches
{
	private static readonly string[] SfxPrefabs =
	{
		"sfx_open_gate_mm",
		"sfx_close_gate_mm",
		"sfx_open_bridge_mm",
		"sfx_break_glass_mm",
		"sfx_tower_bridge_mm",
		"sfx_elevator_mm",
		"sfx_elevator_long_mm",
		"sfx_water_fountain",
		"sfx_frog_croaking",
		"sfx_water_bucket",
		"sfx_bartender_bye",
		"sfx_bartender_greet",
		"sfx_bartender_random",
		"sfx_bartender_trade",
		"sfx_shower_cwe",
		"sfx_elevator_cwe_01",
		"sfx_elevator_cwe_02",
		"sfx_elevator_cwe_03",
		"sfx_elevator_cwe_04",
	};

	[HarmonyPatch(typeof(ZNetScene), "Awake")]
	private static class ZNetSceneAwakePatch
	{
		private static void Postfix(ZNetScene __instance)
		{
			try
			{
				foreach (string prefabName in SfxPrefabs)
				{
					GameObject prefab = __instance.GetPrefab(prefabName);
					AudioSource audioSource = prefab ? prefab.GetComponentInChildren<AudioSource>() : null;
					if (!audioSource)
					{
						Jotunn.Logger.LogWarning("[CoreWoodExtras] No AudioSource found on '" + prefabName + "', skipping mixer assignment.");
						continue;
					}
					audioSource.outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				}
			}
			catch (System.Exception ex)
			{
				Jotunn.Logger.LogError("Error with SoundPatches ZNetSceneAwakePatch: " + ex);
			}
		}
	}
}
