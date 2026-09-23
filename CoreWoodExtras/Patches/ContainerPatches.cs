using CoreWoodExtras.Containers;
using CoreWoodExtras.Updates;
using HarmonyLib;
using Jotunn;
using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras;

internal class ContainerPatches
{
	[HarmonyPatch(typeof(ZNetScene), "Awake")]
	private static class ZNetSceneAwakeContainerPatch
	{
		private static void Postfix(ZNetScene __instance)
		{
			try
			{
				UpdateChestSettings.ApplyToPrefabs(__instance.GetPrefab);
			}
			catch (System.Exception ex)
			{
				Jotunn.Logger.LogError("Error with ZNetSceneAwakeContainerPatch: " + ex);
			}
		}
	}

	[HarmonyPatch(typeof(Container), "Interact")]
	public static class ContainerInteractPatch
	{
		private static bool Prefix(Container __instance, Humanoid character, bool hold, bool alt)
		{
			Piece component = __instance.GetComponent<Piece>();
			if (component == null || component.m_name != "$piece_mm_corewood_chest_stackable")
			{
				return true;
			}
			Sign component2 = __instance.GetComponent<Sign>();
			if (component2 == null)
			{
				return true;
			}
			if (!alt)
			{
				return true;
			}
			return !component2.Interact(character, hold, alt: true);
		}
	}

	[HarmonyPatch(typeof(Container), "GetHoverText")]
	public static class ContainerGetHoverTextPatch
	{
		private static bool Prefix(Container __instance, ref string __result)
		{
			Piece component = __instance.GetComponent<Piece>();
			if (component == null || component.m_name != "$piece_mm_corewood_chest_stackable")
			{
				return true;
			}
			if (__instance.GetComponent<Sign>() == null)
			{
				return true;
			}
			if (!MainConfig.chestStackedHotbar.Value)
			{
				__result = Localization.instance.Localize("$piece_mm_corewood_chest_stackable\n[<color=yellow><b>$KEY_Use</b></color>] $text_chest_open\n[<color=yellow><b>Shift + $KEY_Use</b></color>] $text_chest_edit\n[<color=yellow><b>1-8</b></color>] $text_chest_set\n");
			}
			else
			{
				__result = Localization.instance.Localize("$piece_mm_corewood_chest_stackable\n[<color=yellow><b>$KEY_Use</b></color>] $text_chest_open\n[<color=yellow><b>Shift + $KEY_Use</b></color>] $text_chest_edit\n");
			}
			return false;
		}
	}

	[HarmonyPatch(typeof(Player), "UseHotbarItem")]
	public static class InterceptUseHotbarItemOnNamedChest
	{
		private static bool Prefix(Player __instance, int index)
		{
			GameObject hoverObject = __instance.GetHoverObject();
			if (hoverObject == null)
			{
				return true;
			}
			Piece componentInParent = hoverObject.GetComponentInParent<Piece>();
			if (componentInParent == null || componentInParent.m_name != "$piece_mm_corewood_chest_stackable" || MainConfig.chestStackedHotbar.Value)
			{
				return true;
			}
			Sign component = componentInParent.GetComponent<Sign>();
			if (component == null)
			{
				return true;
			}
			ItemDrop.ItemData itemData = __instance.GetInventory()?.GetItemAt(index - 1, 0);
			if (itemData == null)
			{
				return true;
			}
			string text = (itemData.m_dropPrefab ? itemData.m_dropPrefab.name : itemData.m_shared.m_name);
			component.SetText(text);
			return false;
		}
	}

	[HarmonyPatch(typeof(InventoryGui), "Show")]
	public static class InventoryGui_Show_Patch
	{
		public static void Postfix(Container ___m_currentContainer)
		{
			if ((bool)___m_currentContainer && ___m_currentContainer.name.Contains("mm_corewood_stackable_chest"))
			{
				Sign componentInParent = ___m_currentContainer.gameObject.GetComponentInParent<Sign>();
				Transform canvas = componentInParent != null ? Utils.FindChild(componentInParent.transform, "CanvasFront") : null;
				if (canvas != null)
				{
					canvas.localPosition = new Vector3(0f, 0.666f, 1.795f);
				}
			}
		}
	}

	[HarmonyPatch(typeof(InventoryGui), "Hide")]
	public static class InventoryGui_Hide_Patch
	{
		public static void Prefix(InventoryGui __instance, Container ___m_currentContainer)
		{
			if (!__instance.m_animator.GetBool("visible") || !___m_currentContainer || !___m_currentContainer.name.Contains("mm_corewood_stackable_chest"))
			{
				return;
			}
			Sign componentInParent = ___m_currentContainer.gameObject.GetComponentInParent<Sign>();
			Transform canvas = componentInParent != null ? Utils.FindChild(componentInParent.transform, "CanvasFront") : null;
			if (canvas != null && (bool)Player.m_localPlayer)
			{
				canvas.localPosition = new Vector3(0f, 0.666f, 1.003f);
			}
		}
    }

    // Visual Containers
    [HarmonyPatch]
    public class PlacementPatch
    {
        [HarmonyPatch(typeof(Player), "SetupPlacementGhost")]
        [HarmonyPostfix]
        public static void SetupPlacementGhostPatch(Player __instance)
        {
            if ((bool)__instance.m_placementGhost)
            {
                VisualStack[] componentsInChildren = __instance.m_placementGhost.GetComponentsInChildren<VisualStack>();
                for (int i = 0; i < componentsInChildren.Length; i++)
                {
                    UnityEngine.Object.Destroy(componentsInChildren[i]);
                }
            }
        }
    }
}
