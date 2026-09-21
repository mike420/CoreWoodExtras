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
            // The item exists but its required global key is not set yet.
            Locked,
            Failed
        }

        private static readonly Dictionary<string, string> ResolvedNameCache = new Dictionary<string, string>();

        // StoreGui finds the selected entry again with a reference comparison after every refresh, so the same
        // TradeItem object has to come back on every call or the selection jumps back to the first entry.
        private static readonly Dictionary<string, Trader.TradeItem> TradeItemCache = new Dictionary<string, Trader.TradeItem>();

        private static readonly HashSet<string> Warned = new HashSet<string>();

        private static ObjectDB s_cacheDb;

        [HarmonyPriority(200)]
        private static void Postfix(Trader __instance, List<Trader.TradeItem> __result)
        {
            // GetAvailableItems is called by the store window itself, and other mods hook the same window (EpicLoot's
            // merchant panel for one), so nothing thrown here may escape into it.
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

            // Every non-Burt trader gets the mystical seed regardless of config.
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

            // User-defined items from BepInEx/config/CoreWoodExtras/BurtItems.json
            // (loaded once at startup in CoreWoodPlugin.Awake)
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

            // Items that are only locked behind a global key still count: Burt stays, his list is just empty for now.
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

            // "none" is how the config file has always spelled "no key"; vanilla uses an empty string.
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

                // Every field the store window reads has to be set: vanilla dereferences m_buyPlayerEffects when
                // something is bought, and m_tooltip / m_name when the list is drawn.
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

            // Vanilla applies the global key filter before postfixes run, so items added here have to check it themselves.
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

        // The store window calls GetAvailableItems several times per refresh, so each problem is only logged once.
        private static void WarnOnce(string id, string message)
        {
            if (Warned.Add(id))
            {
                Jotunn.Logger.LogWarning(message);
            }
        }
    }
}
