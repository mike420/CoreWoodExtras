using System;
using System.Collections.Generic;
using HarmonyLib;

namespace CoreWoodExtras.Containers;

[HarmonyPatch]
internal static class RestrictContainers
{
	private static string _loadingContainer;

	private static string _targetContainer;

	private static HashSet<string> _allowedItems;

    public static Dictionary<string, HashSet<string>> _allowedItemsByContainer = new Dictionary<string, HashSet<string>>();

    public static void SetContainerRestrictions(Dictionary<string, HashSet<string>> allowedItemByContainer)
    {
        _allowedItemsByContainer = allowedItemByContainer;
    }

    public static void SetRestriction(string containerName, HashSet<string> allowedItems)
    {
        if (_allowedItemsByContainer.TryGetValue(containerName, out HashSet<string> existing))
        {
            Jotunn.Logger.LogWarning("[CoreWoodExtras] Container name '" + containerName + "' is used by more than one container, merging their allowed items.");
            existing.UnionWith(allowedItems);
            return;
        }
        _allowedItemsByContainer[containerName] = allowedItems;
    }

    public static bool IsRestrictedContainer(string containerName, out HashSet<string> allowedItems)
    {
        return _allowedItemsByContainer.TryGetValue(containerName, out allowedItems);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(InventoryGrid), "DropItem")]
    private static bool DropItemPrefix(InventoryGrid __instance, Inventory fromInventory, ItemDrop.ItemData item, Vector2i pos)
    {
        if (!CanAddItem(__instance.m_inventory, item))
        {
            return false;
        }
        ItemDrop.ItemData itemAt = __instance.m_inventory.GetItemAt(pos.x, pos.y);
        if (itemAt != null)
        {
            return CanAddItem(fromInventory, itemAt);
        }
        return true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Inventory), "AddItem", new Type[] { typeof(ItemDrop.ItemData) })]
    [HarmonyPatch(typeof(Inventory), "AddItem", new Type[]
    {
        typeof(ItemDrop.ItemData),
        typeof(int),
        typeof(int),
        typeof(int),
        typeof(bool)
    })]
    [HarmonyPriority(800)]
    private static bool AddItemPrefix(Inventory __instance, ItemDrop.ItemData item, ref bool __result)
    {
        if (!CanAddItem(__instance, item))
        {
            __result = false;
            return false;
        }
        return true;
    }

    [HarmonyPatch(typeof(Inventory), "MoveItemToThis", new Type[]
    {
        typeof(Inventory),
        typeof(ItemDrop.ItemData)
    })]
    [HarmonyPriority(800)]
    [HarmonyPatch(typeof(Inventory), "MoveItemToThis", new Type[]
    {
        typeof(Inventory),
        typeof(ItemDrop.ItemData),
        typeof(int),
        typeof(int),
        typeof(int)
    })]
    [HarmonyPrefix]
    private static bool MoveItemToThisPrefix_1(Inventory __instance, Inventory fromInventory, ItemDrop.ItemData item)
    {
        if (__instance == null || fromInventory == null || item == null)
        {
            return false;
        }
        return CanAddItem(__instance, item);
    }

    [HarmonyPatch(typeof(Inventory), "Load", new Type[] { typeof(ZPackage) })]
    [HarmonyPatch(typeof(Inventory), "Load", new Type[]
    {
        typeof(ZPackage),
        typeof(bool)
    })]
    [HarmonyPrefix]
    private static void LoadPrefix(Inventory __instance)
    {
        if (__instance != null)
        {
            _loadingContainer = __instance.m_name;
        }
    }

    [HarmonyPatch(typeof(Inventory), "Load", new Type[] { typeof(ZPackage) })]
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Inventory), "Load", new Type[]
    {
        typeof(ZPackage),
        typeof(bool)
    })]
    private static void LoadPostfix()
    {
        _loadingContainer = null;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Inventory), "MoveAll", new Type[] { typeof(Inventory) })]
    [HarmonyPriority(800)]
    private static void MoveAllPrefix(Inventory __instance, Inventory fromInventory)
    {
        if (__instance != null && fromInventory != null)
        {
            if (IsRestrictedContainer(__instance.m_name, out var allowedItems))
            {
                _targetContainer = __instance.m_name;
                _allowedItems = allowedItems;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Inventory), "MoveAll", new Type[] { typeof(Inventory) })]
    [HarmonyPriority(800)]
    private static void MoveAllPostfix()
    {
        _targetContainer = null;
        _allowedItems = null;
    }

    [HarmonyPriority(800)]
    [HarmonyPatch(typeof(Inventory), "RemoveItem", new Type[]
    {
        typeof(ItemDrop.ItemData),
        typeof(int)
    })]
    [HarmonyPatch(typeof(Inventory), "RemoveItem", new Type[] { typeof(ItemDrop.ItemData) })]
    [HarmonyPrefix]
    private static bool RemoveItemPrefix(Inventory __instance, ItemDrop.ItemData item)
    {
        return ShouldRemoveItem(__instance, item);
    }

    [HarmonyPriority(800)]
    [HarmonyPatch(typeof(Inventory), "RemoveOneItem", new Type[] { typeof(ItemDrop.ItemData) })]
    [HarmonyPrefix]
    private static bool RemoveOneItemPrefix(Inventory __instance, ItemDrop.ItemData item)
    {
        return ShouldRemoveItem(__instance, item);
    }

    private static bool CanAddItem(Inventory inventory, ItemDrop.ItemData item)
    {
        if (inventory == null || item == null)
        {
            return false;
        }
        if (inventory.m_name == _loadingContainer)
        {
            return true;
        }
        if (IsRestrictedContainer(inventory.m_name, out var allowedItems))
        {
            bool flag = allowedItems.Contains(item.PrefabName());
            if (!flag)
            {
                string msg = item.m_shared.m_name + " cannot be placed in " + inventory.m_name;
                Player.m_localPlayer?.Message(MessageHud.MessageType.Center, msg);
            }
            return flag;
        }
        return true;
    }

    private static bool ShouldRemoveItem(Inventory __instance, ItemDrop.ItemData item)
    {
        if (__instance == null || item == null)
        {
            return false;
        }
        bool flag = !string.IsNullOrEmpty(_targetContainer);

        if (flag && _allowedItems != null)
        {
            return _allowedItems.Contains(item.PrefabName());
        }
        return true;
    }
}