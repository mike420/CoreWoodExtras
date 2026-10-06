using System;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;

namespace CoreWoodExtras;

internal enum PieceSfx
{
    Wood,
    Glass,
    Stone,
    Metal
}

internal static class PieceBuilder
{
    private const string HammerTable = "_HammerPieceTable";

    public static GameObject LoadPrefab(string prefabName)
    {
        return CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>(prefabName);
    }

    public static RequirementConfig Req(string item, int amount, bool recover = true)
    {
        return new RequirementConfig
        {
            Item = item,
            Amount = amount,
            Recover = recover
        };
    }

    public static PieceConfig Config(string craftingStation, string category, string[] usage, params RequirementConfig[] requirements)
    {
        return new PieceConfig
        {
            CraftingStation = craftingStation,
            PieceTable = HammerTable,
            Category = category,
            Usage = usage,
            Requirements = requirements
        };
    }

    public static void Add(string prefabName, PieceSfx sfx, PieceConfig config, bool fixReference = true)
    {
        try
        {
            CustomPiece customPiece = CreatePiece(LoadPrefab(prefabName), sfx, config, fixReference);
            PieceManager.Instance.AddPiece(customPiece);
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError("Exception caught while adding " + prefabName + ": " + ex);
        }
    }

    public static void AddItem(string prefabName, string craftingStation, params RequirementConfig[] requirements)
    {
        try
        {
            CustomItem customItem = new CustomItem(LoadPrefab(prefabName), fixReference: true, new ItemConfig
            {
                Amount = 1,
                CraftingStation = craftingStation,
                Requirements = requirements
            });
            ItemManager.Instance.AddItem(customItem);
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError("Exception caught while adding " + prefabName + ": " + ex);
        }
    }

    public static CustomPiece CreatePiece(GameObject prefab, PieceSfx sfx, PieceConfig config, bool fixReference = true)
    {
        CustomPiece customPiece = new CustomPiece(prefab, fixReference, config);
        ApplySfx(prefab, sfx);
        return customPiece;
    }

    private static void ApplySfx(GameObject prefab, PieceSfx sfx)
    {
        WearNTear wearNTear = prefab.GetComponent<WearNTear>();
        switch (sfx)
        {
            case PieceSfx.Stone:
                prefab.GetComponent<Piece>().m_placeEffect = buildStone;
                wearNTear.m_destroyedEffect = breakStone;
                wearNTear.m_hitEffect = hitStone;
                break;
            case PieceSfx.Metal:
                prefab.GetComponent<Piece>().m_placeEffect = buildMetal;
                wearNTear.m_destroyedEffect = breakMetal;
                wearNTear.m_hitEffect = hitMetal;
                break;
            case PieceSfx.Glass:
                prefab.GetComponent<Piece>().m_placeEffect = buildWood;
                wearNTear.m_destroyedEffect = breakGlass;
                wearNTear.m_hitEffect = hitWood;
                break;
            default:
                prefab.GetComponent<Piece>().m_placeEffect = buildWood;
                wearNTear.m_destroyedEffect = breakWood;
                wearNTear.m_hitEffect = hitWood;
                break;
        }
    }
}
