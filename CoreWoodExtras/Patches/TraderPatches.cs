using System;
using System.Collections.Generic;
using HarmonyLib;
using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras;

internal class TraderPatches
{
    [HarmonyPatch(typeof(Trader), "GetAvailableItems")]
    public static class GetAvailableItemsPatch
    {
        private enum AddResult
        {
            Added,
            Locked,
            Failed
        }

        private static readonly Dictionary<string, string> ResolvedNameCache = new Dictionary<string, string>();

        private static readonly Dictionary<string, Trader.TradeItem> TradeItemCache = new Dictionary<string, Trader.TradeItem>();

        private static readonly HashSet<string> Warned = new HashSet<string>();

        private static ObjectDB s_cacheDb;

        [HarmonyPriority(200)]
        private static void Postfix(Trader __instance, List<Trader.TradeItem> __result)
        {
            try
            {
                AddItems(__instance, __result);
            }
            catch (Exception ex)
            {
                WarnOnce("postfix:" + ex.Message, $"[CoreWoodExtras] Could not add items to trader '{__instance.name}': {ex.Message}");
            }
        }

        private static void AddItems(Trader trader, List<Trader.TradeItem> result)
        {
            if (result == null || ObjectDB.instance == null)
            {
                return;
            }
            if (s_cacheDb != ObjectDB.instance)
            {
                s_cacheDb = ObjectDB.instance;
                TradeItemCache.Clear();
            }

            bool isBurt = trader.name.Contains("Burt");

            if (!isBurt)
            {
                TryAddItem("mm_mystical_seed", 10, 10, "", result);
                return;
            }

            if (!MainConfig.traderEnabled.Value)
            {
                return;
            }

            if (!CustomTraderItems.HasAnyEnabledItem)
            {
                trader.gameObject.SetActive(false);
                return;
            }

            int resolved = 0;
            foreach (CustomTraderItems.CustomTraderItem item in CustomTraderItems.Items)
            {
                if (!item.enabled || string.IsNullOrEmpty(item.prefabName))
                {
                    continue;
                }

                if (TryAddItem(item.prefabName, item.stack, item.price, item.requiredGlobalKey, result) != AddResult.Failed)
                {
                    resolved++;
                }
            }

            if (resolved == 0)
            {
                WarnOnce("burt", "[CoreWoodExtras] Burt's enabled trader items all failed to resolve - disabling Burt. Check the prefab names in BurtItems.json.");
                trader.gameObject.SetActive(false);
            }
        }

        private static AddResult TryAddItem(string prefabName, int stackSize, int price, string requiredGlobalKey, List<Trader.TradeItem> result)
        {
            string resolvedName = GetResolvedPrefabName(prefabName);
            if (resolvedName == null)
            {
                WarnOnce("prefab:" + prefabName, $"[CoreWoodExtras] Trader prefab '{prefabName}' not found, skipping.");
                return AddResult.Failed;
            }

            string key = string.IsNullOrEmpty(requiredGlobalKey) || requiredGlobalKey == "none" ? "" : requiredGlobalKey;

            string cacheKey = $"{resolvedName}|{stackSize}|{price}|{key}";
            if (!TradeItemCache.TryGetValue(cacheKey, out Trader.TradeItem tradeItem) || tradeItem.m_prefab == null)
            {
                GameObject itemPrefab = ObjectDB.instance.GetItemPrefab(resolvedName);
                if (itemPrefab == null)
                {
                    WarnOnce("itemdb:" + resolvedName, $"[CoreWoodExtras] ItemDB prefab '{resolvedName}' not found, skipping.");
                    return AddResult.Failed;
                }

                ItemDrop component = itemPrefab.GetComponent<ItemDrop>();
                if (component == null)
                {
                    return AddResult.Failed;
                }

                tradeItem = new Trader.TradeItem
                {
                    m_prefab = component,
                    m_stack = stackSize,
                    m_price = price,
                    m_requiredGlobalKey = key,
                    m_buyPlayerEffects = new EffectList(),
                    m_levelUpEffect = false,
                    m_name = "",
                    m_tooltip = "",
                    m_buyKey = "",
                    m_incrementKey = "",
                };
                TradeItemCache[cacheKey] = tradeItem;
            }

            if (key.Length > 0 && (ZoneSystem.instance == null || !ZoneSystem.instance.GetGlobalKey(key)))
            {
                return AddResult.Locked;
            }

            result.Add(tradeItem);
            return AddResult.Added;
        }

        private static string GetResolvedPrefabName(string prefabName)
        {
            if (ResolvedNameCache.TryGetValue(prefabName, out string cached))
            {
                return cached;
            }

            GameObject prefab = PrefabManager.Cache.GetPrefab<GameObject>(prefabName);
            string resolved = prefab != null ? prefab.name : null;
            ResolvedNameCache[prefabName] = resolved;
            return resolved;
        }

        private static void WarnOnce(string id, string message)
        {
            if (Warned.Add(id))
            {
                Jotunn.Logger.LogWarning(message);
            }
        }
    }
}
