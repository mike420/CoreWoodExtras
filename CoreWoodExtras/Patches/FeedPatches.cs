using HarmonyLib;
using System.Linq;
using UnityEngine;
using CoreWoodExtras.Containers;

namespace CoreWoodExtras
{
    internal class FeedPatches
    {
        [HarmonyPatch(typeof(Container), nameof(Container.Awake))]
        public static class Container_Awake_Patch
        {
            private static void Postfix(Container __instance)
            {
                if (!UtilityMethods.VerifyValid(__instance))
                    return;
                UtilityMethods.RegisterContainer(__instance);
            }
        }

        [HarmonyPatch(typeof(Container), nameof(Container.OnDestroyed))]
        public static class Container_OnDestroy_Patch
        {
            private static void Prefix(Container __instance)
            {
                if (!UtilityMethods.VerifyValid(__instance))
                    return;
                UtilityMethods.DeRegisterContainer(__instance);
            }
        }

        [HarmonyPatch(typeof(Player), nameof(Player.UpdateTeleport))]
        public static class PlayerUpdateTeleportPatchCleanupContainers
        {
            public static void Prefix(float dt)
            {
                if (Player.m_localPlayer == null || !Player.m_localPlayer.m_teleporting)
                    return;
                // Drops destroyed containers (Unity null) as well as ones without an inventory.
                UtilityMethods.RegisteredContainers.RemoveWhere(container => container == null || container.GetInventory() == null);

                UtilityMethods.LastFeedCheckTimes.Clear();
            }
        }

        [HarmonyPatch(typeof(Tameable), nameof(Tameable.IsHungry))]
        public static class Tameable_IsHungry_Patch
        {
            public static void Postfix(Tameable __instance, ref bool __result)
            {
                // Not hungry, or already feeding this tame from a trough (IsHungry is called again while it eats).
                if (!__result || UtilityMethods.IsFeeding || !__instance.m_nview.IsOwner())
                    return;

                if (__instance.m_monsterAI == null || __instance.m_character == null) return;
                float currentTime = Time.time;
                if (UtilityMethods.LastFeedCheckTimes.TryGetValue(__instance.m_character, out float lastCheckTime))
                {
                    if (currentTime - lastCheckTime < MainConfig.FeedCheckCooldown.Value)
                        return;
                }

                UtilityMethods.LastFeedCheckTimes[__instance.m_character] = currentTime;
                UtilityMethods.TryFeedAnimal(__instance.m_monsterAI, __instance, __instance.m_character);
            }
        }

        [HarmonyPatch(typeof(Tameable), nameof(Tameable.OnDeath))]
        public static class Tameable_OnDeath_Patch
        {
            public static void Prefix(Tameable __instance)
            {
                if (__instance.m_character == null)
                    return;
                UtilityMethods.SafeRemoveFeedCheckTime(__instance.m_character);
            }
        }

        [HarmonyPatch(typeof(Character), nameof(Character.OnDestroy))]
        static class CharacterOnDestroyPatch
        {
            static void Prefix(Character __instance)
            {
                UtilityMethods.SafeRemoveFeedCheckTime(__instance);
            }
        }
    }
}
