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
				ChangeTextureFilter();
			}
		}
	}

	public static ZNetScene zNetScene;

	public static void ChangeTextureFilter()
	{
		foreach (GameObject prefab in zNetScene.m_prefabs)
		{
			if (!prefab.name.ToLower().Contains("mm_corewood"))
			{
				continue;
			}
			MeshRenderer[] componentsInChildren = prefab.GetComponentsInChildren<MeshRenderer>(includeInactive: true);
			if (componentsInChildren == null)
			{
				continue;
			}
			MeshRenderer[] array = componentsInChildren;
			foreach (MeshRenderer meshRenderer in array)
			{
				if (meshRenderer.material.mainTexture != null)
				{
					meshRenderer.material.mainTexture.anisoLevel = 0;
					meshRenderer.material.mainTexture.filterMode = FilterMode.Point;
				}
			}
		}
	}
}
