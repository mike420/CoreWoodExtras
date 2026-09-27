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
				ChangeTextureFilter();
			}
		}
	}

	private class TextureState
	{
		public FilterMode Filter;
		public int AnisoLevel;
	}

	public static ZNetScene zNetScene;

	private static readonly Dictionary<Texture, TextureState> OriginalStates = new Dictionary<Texture, TextureState>();

	public static void ChangeTextureFilter()
	{
		if (!MainConfig.disableHDTextures.Value)
		{
			RestoreTextureFilter();
			return;
		}
		if (!zNetScene)
		{
			return;
		}
		foreach (GameObject prefab in zNetScene.m_prefabs)
		{
			if (!prefab || !prefab.name.ToLower().Contains("mm_corewood"))
			{
				continue;
			}
			foreach (MeshRenderer meshRenderer in prefab.GetComponentsInChildren<MeshRenderer>(includeInactive: true))
			{
				Material material = meshRenderer.sharedMaterial;
				Texture texture = material ? material.mainTexture : null;
				if (!texture)
				{
					continue;
				}
				if (!OriginalStates.ContainsKey(texture))
				{
					OriginalStates[texture] = new TextureState { Filter = texture.filterMode, AnisoLevel = texture.anisoLevel };
				}
				texture.anisoLevel = 0;
				texture.filterMode = FilterMode.Point;
			}
		}
	}

	private static void RestoreTextureFilter()
	{
		foreach (KeyValuePair<Texture, TextureState> entry in OriginalStates)
		{
			if (entry.Key)
			{
				entry.Key.filterMode = entry.Value.Filter;
				entry.Key.anisoLevel = entry.Value.AnisoLevel;
			}
		}
		OriginalStates.Clear();
	}
}
