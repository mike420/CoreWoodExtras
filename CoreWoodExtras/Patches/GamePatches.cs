using HarmonyLib;
using System.Linq;
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
			if (!prefab || !prefab.name.ToLower().StartsWith("mm_corewood"))
			{
				continue;
			}
			MeshRenderer[] componentsInChildren = prefab.GetComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer meshRenderer in componentsInChildren)
			{
				Material material = meshRenderer.sharedMaterial;
				if (material && material.HasProperty("_RippleDistance"))
				{
					material.SetFloat("_RippleDistance", 0.01f);
					material.SetFloat("_RippleFreq", 0f);
					material.SetFloat("_ValueNoise", 0f);
				}
			}
		}
	}
    
    [HarmonyPatch(typeof(EffectArea))]
    internal static class EffectAreaPatch
    {
        internal const string NoMonstersStatusEffect = "NoMonstersStatusEffect";

        internal static readonly int NoMonstersStatusEffectHash = NoMonstersStatusEffect.GetStableHashCode();

        private static readonly System.Predicate<Character> IsInvalidCollidedWithCharacter = item => !IsValidCollidedWithCharacter(item);

        [HarmonyPrefix]
        [HarmonyPatch("CustomFixedUpdate")]
        private static void CustomFixedUpdatePrefex(EffectArea __instance, float deltaTime)
        {
            if ((bool)__instance && __instance.m_collidedWithCharacter.Count > 0)
            {
                __instance.m_collidedWithCharacter.RemoveAll(IsInvalidCollidedWithCharacter);
            }
        }

        private static bool IsValidCollidedWithCharacter(Character item)
        {
            if (!item || item.GetSEMan() == null || !item.GetSEMan().m_nview || !item.GetSEMan().m_nview.IsValid())
            {
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(Player))]
    internal static class PlayerPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch("UpdateEnvStatusEffects")]
        private static void UpdateEnvStatusEffectsPostFix(Player __instance)
        {
            SEMan seman = ((Character)__instance).m_seman;
            if (seman == null || !seman.HaveStatusEffect(EffectAreaPatch.NoMonstersStatusEffectHash))
            {
                return;
            }
            if (!EffectArea.IsPointInsideArea(__instance.transform.position, EffectArea.Type.NoMonsters, 1f))
            {
                seman.RemoveStatusEffect(EffectAreaPatch.NoMonstersStatusEffectHash);
            }
        }
    }
}
