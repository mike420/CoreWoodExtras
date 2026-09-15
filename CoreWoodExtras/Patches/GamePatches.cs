using HarmonyLib;
using UnityEngine;

namespace CoreWoodExtras;

public class GamePatches
{
	[HarmonyPatch(typeof(ZNetScene), "Awake")]
	private class ZNetSceneAwakeMeshPatch
	{
		[HarmonyPriority(200)]
		private static void Postfix(ZNetScene __instance)
		{
			zNetScene = __instance;
			FixGameObjects();
		}
	}

	public static ZNetScene zNetScene;

	public static void FixGameObjects()
	{
		foreach (GameObject prefab in zNetScene.m_prefabs)
		{
			if (!prefab.name.ToLower().StartsWith("mm_corewood"))
			{
				continue;
			}
			MeshRenderer[] componentsInChildren = prefab.GetComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer meshRenderer in componentsInChildren)
			{
				if (meshRenderer.material.HasProperty("_RippleDistance"))
				{
					meshRenderer.sharedMaterial.SetFloat("_RippleDistance", 0.01f);
					meshRenderer.sharedMaterial.SetFloat("_RippleFreq", 0f);
					meshRenderer.sharedMaterial.SetFloat("_ValueNoise", 0f);
				}
			}
		}
	}
}
