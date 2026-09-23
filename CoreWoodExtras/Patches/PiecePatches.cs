using HarmonyLib;
using System.Collections.Generic;

namespace CoreWoodExtras
{
    internal class PiecePatches
    {
        private const string HogRoastPrefab = "mm_corewood_hog_roast";

        // Always registered, so "Enable Elevators" can follow the server's synced value, which arrives after the pieces
        // are registered. When it is off they are only kept out of the build menu (and placed ones do not move).
        private static readonly HashSet<string> ElevatorPrefabs = new HashSet<string>
        {
            "mm_corewood_elevator_small",
            "mm_corewood_elevator_small_9m",
            "mm_corewood_elevator_large",
            "mm_corewood_elevator_large_9m",
            "mm_corewood_elevator_01",
            "mm_corewood_elevator_02",
            "mm_corewood_elevator_03",
            "mm_corewood_elevator_04",
        };

        // Pieces have no unlock key of their own, so a locked piece is taken back out of the build menu after the game
        // fills it. Doing it here rather than in Player.HaveRequirements also hides it from players who already know it.
        [HarmonyPatch(typeof(PieceTable), nameof(PieceTable.UpdateAvailable))]
        public static class PieceTable_UpdateAvailable_Patch
        {
            private static void Postfix(PieceTable __instance, bool noPlacementCost)
            {
                // The unlock key is left alone in no cost mode, like every other requirement.
                bool hideRoast = !noPlacementCost && !IsUnlocked(MainConfig.HogRoastRequiredKey.Value);
                bool hideElevators = !MainConfig.enableElevators.Value;
                if (!hideRoast && !hideElevators)
                {
                    return;
                }
                bool IsHidden(Piece piece)
                {
                    if (piece == null)
                    {
                        return false;
                    }
                    string name = piece.gameObject.name;
                    return (hideRoast && name == HogRoastPrefab) || (hideElevators && ElevatorPrefabs.Contains(name));
                }
                __instance.m_availablePieces.RemoveWhere(IsHidden);
                __instance.m_enabledPieces.RemoveWhere(IsHidden);
                foreach (List<Piece> category in __instance.m_availablePiecesByCategory)
                {
                    category.RemoveAll(IsHidden);
                }
            }
        }

        private static bool IsUnlocked(string key)
        {
            return string.IsNullOrWhiteSpace(key) || (ZoneSystem.instance != null && ZoneSystem.instance.GetGlobalKey(key.Trim()));
        }
    }
}
