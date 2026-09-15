using HarmonyLib;
using Jotunn;
using UnityEngine;

namespace CoreWoodExtras;

public class SoundPatches
{
	[HarmonyPatch(typeof(ZNetScene), "Awake")]
	private static class ZNetSceneAwakePatch
	{
		private static void Postfix(ZNetScene __instance)
		{
			GameObject prefab = __instance.GetPrefab("sfx_open_gate_mm");
			GameObject prefab2 = __instance.GetPrefab("sfx_close_gate_mm");
			GameObject prefab3 = __instance.GetPrefab("sfx_open_bridge_mm");
			GameObject prefab4 = __instance.GetPrefab("sfx_break_glass_mm");
			GameObject prefab5 = __instance.GetPrefab("sfx_tower_bridge_mm");
			GameObject prefab6 = __instance.GetPrefab("sfx_elevator_mm");
			GameObject prefab7 = __instance.GetPrefab("sfx_elevator_long_mm");
			GameObject prefab8 = __instance.GetPrefab("sfx_water_fountain");
			GameObject prefab9 = __instance.GetPrefab("sfx_frog_croaking");
			GameObject prefab10 = __instance.GetPrefab("sfx_water_bucket");
			GameObject prefab11 = __instance.GetPrefab("sfx_bartender_bye");
			GameObject prefab12 = __instance.GetPrefab("sfx_bartender_greet");
			GameObject prefab13 = __instance.GetPrefab("sfx_bartender_random");
			GameObject prefab14 = __instance.GetPrefab("sfx_bartender_trade");
			GameObject prefab15 = __instance.GetPrefab("sfx_shower_cwe");
			GameObject prefab16 = __instance.GetPrefab("sfx_elevator_cwe_01");
			GameObject prefab17 = __instance.GetPrefab("sfx_elevator_cwe_01");
			GameObject prefab18 = __instance.GetPrefab("sfx_elevator_cwe_01");
			GameObject prefab19 = __instance.GetPrefab("sfx_elevator_cwe_01");
			try
			{
				prefab.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab2.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab3.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab4.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab5.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab6.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab7.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab8.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab9.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab10.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab11.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab12.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab13.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab14.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab15.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab16.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab17.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab18.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
				prefab19.GetComponentInChildren<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
			}
			catch
			{
				Jotunn.Logger.LogError("Error with ZNetSceneAwakePatch!");
			}
		}
	}
}
