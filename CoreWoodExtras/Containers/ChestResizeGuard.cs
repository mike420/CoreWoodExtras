using HarmonyLib;
using UnityEngine;

namespace CoreWoodExtras.Containers;

// Valheim's Inventory.Load silently drops any item whose saved slot is outside the
// current grid, or whose slot is already taken, and the next save then makes that loss
// permanent. Grow the loaded chest inventory and relocate clashing items so nothing is discarded.
[HarmonyPatch]
internal static class ChestResizeGuard
{
	private static Inventory _loading;

	[HarmonyPatch(typeof(Container), "Load")]
	[HarmonyPrefix]
	private static void LoadPrefix(Container __instance)
	{
		_loading = IsCoreWoodChest(__instance) ? __instance.m_inventory : null;
	}

	[HarmonyPatch(typeof(Container), "Load")]
	[HarmonyFinalizer]
	private static void LoadFinalizer()
	{
		_loading = null;
	}

	[HarmonyPatch(typeof(Inventory), "AddItem", new[] { typeof(ItemDrop.ItemData), typeof(int), typeof(int), typeof(int), typeof(bool) })]
	[HarmonyPrefix]
	private static void AddItemPrefix(Inventory __instance, ItemDrop.ItemData item, int amount, ref int x, ref int y)
	{
		if (__instance != _loading || item == null || x < 0 || y < 0)
		{
			return;
		}
		string itemName = item.m_dropPrefab ? item.m_dropPrefab.name : item.m_shared.m_name;
		if (x >= __instance.m_width || y >= __instance.m_height)
		{
			Jotunn.Logger.LogWarning("[CoreWoodExtras] " + __instance.m_name + ": " + itemName + " x" + item.m_stack + " was saved at slot (" + x + "," + y + ") outside the " + __instance.m_width + "x" + __instance.m_height + " grid, growing the chest to keep it.");
		}
		if (x >= __instance.m_width)
		{
			__instance.m_width = Mathf.Min(x + 1, 64);
		}
		if (y >= __instance.m_height)
		{
			__instance.m_height = Mathf.Min(y + 1, 64);
		}
		// Vanilla discards an item whose saved slot is already taken by something it can't merge into.
		ItemDrop.ItemData itemAt = __instance.GetItemAt(x, y);
		if (itemAt == null || (itemAt.IsSameType(item) && itemAt.m_stack + Mathf.Min(amount, item.m_stack) <= itemAt.m_shared.m_maxStackSize))
		{
			return;
		}
		Vector2i empty = __instance.FindEmptySlot(false);
		if (empty.x < 0)
		{
			empty = new Vector2i(0, __instance.m_height);
			__instance.m_height = Mathf.Min(__instance.m_height + 1, 64);
		}
		Jotunn.Logger.LogWarning("[CoreWoodExtras] " + __instance.m_name + ": " + itemName + " x" + item.m_stack + " was saved at slot (" + x + "," + y + ") already holding " + (itemAt.m_dropPrefab ? itemAt.m_dropPrefab.name : itemAt.m_shared.m_name) + " x" + itemAt.m_stack + ", moved it to (" + empty.x + "," + empty.y + ").");
		x = empty.x;
		y = empty.y;
	}

	private static bool IsCoreWoodChest(Container container)
	{
		return container != null && container.m_inventory != null && container.name.StartsWith("mm_corewood_") && container.name.Contains("chest");
	}
}
