using CoreWoodExtras.Containers;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;
using static CoreWoodExtras.PieceBuilder;

namespace CoreWoodExtras;

internal class AddDecor
{
    private static readonly HashSet<string> troughItems = new HashSet<string> {
        "Carrot",
        "Turnip",
        "Onion",
        "Raspberry",
        "Blueberries"
        };

    public static void AddTameFoodsToTrough(ZNetScene zNetScene)
    {
        int before = troughItems.Count;
        foreach (GameObject prefab in zNetScene.m_prefabs)
        {
            if (!prefab || !prefab.GetComponent<Tameable>())
            {
                continue;
            }
            MonsterAI monsterAI = prefab.GetComponent<MonsterAI>();
            if (!monsterAI || monsterAI.m_consumeItems == null)
            {
                continue;
            }
            foreach (ItemDrop food in monsterAI.m_consumeItems)
            {
                if (food)
                {
                    troughItems.Add(food.gameObject.name);
                }
            }
        }
        if (troughItems.Count > before)
        {
            Jotunn.Logger.LogInfo($"[CoreWoodExtras] Trough accepts {troughItems.Count} tame foods ({troughItems.Count - before} added from tameable creatures).");
        }
    }

    public static void LoadPieces()
	{
        PieceAssets.Init();
        CoreWoodPlugin.TryAddPiece(AddCoreWoodChest);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPrivateChest);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodStackableChest);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodTrough);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodStackDynamic);
        Add("mm_corewood_stack", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Storage, PieceUsages.Stacks }, Req("RoundLog", 50)));
        CoreWoodPlugin.TryAddPiece(AddCoreWoodRoaster);

        Add("mm_water_fountain", PieceSfx.Stone, Config("piece_stonecutter", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Stone", 50)));
        Add("mm_water_fountain_02", PieceSfx.Stone, Config("piece_stonecutter", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Stone", 50)));
        Add("mm_corewood_logbench", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 2)));
        Add("mm_corewood_large_bench", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 4), Req("WolfPelt", 4), Req("LeatherScraps", 10)));
        Add("mm_corewood_stump_chair", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 2), Req("LeatherScraps", 4)));
        Add("mm_corewood_throne", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 3)));
        Add("mm_corewood_chair", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 3)));
        Add("mm_corewood_table", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 4)));
        Add("mm_corewood_log_stump_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 1)));
        Add("mm_corewood_log_table_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 2)));
        Add("mm_corewood_bed", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 8), Req("DeerHide", 4), Req("WolfPelt", 4), Req("Feathers", 10)));
        Add("mm_corewood_4poster_bed", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 12), Req("DeerHide", 4), Req("WolfPelt", 4), Req("Feathers", 10)));
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBookshelfSmall);
        Add("mm_corewood_bookshelf_medium", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 3)));
        Add("mm_corewood_bookshelf_large", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 4)));
        CoreWoodPlugin.TryAddPiece(AddCoreWoodCabinetWall);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodCabinetTall);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodCabinetTallDouble);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodCabinetArmor);
        Add("mm_corewood_displaycase", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 6)));
        Add("mm_corewood_displaycase_large", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 10)));
        Add("mm_corewood_aquarium", PieceSfx.Wood, Config("piece_stonecutter", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 6), Req("Crystal", 2)));
        Add("mm_corewood_footbridge_small", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Building }, Req("RoundLog", 6), Req("Wood", 4)));
        Add("mm_corewood_footbridge_large", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Building }, Req("RoundLog", 10), Req("Wood", 6)));

        Add("mm_parasol", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Flax", 1), Req("Barley", 1)));
        Add("mm_barrel_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 6), Req("Iron", 1)));
        Add("mm_keg_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 6), Req("Iron", 1)));
        Add("mm_keg_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 4), Req("Iron", 1)));
        Add("mm_corewood_private_sign", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Wood", 2)));
        Add("mm_corewood_rest_sign", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Wood", 2)));
        Add("mm_corewood_repair_sign", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Wood", 2)));
        Add("mm_corewood_docks_sign", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Wood", 2)));
        Add("mm_corewood_tavern_sign", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Wood", 2)));
        Add("mm_corewood_haldor_sign", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Wood", 2)));
        Add("mm_corewood_hildir_sign", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Wood", 2)));
        Add("mm_corewood_noticeboard", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("Wood", 2)));
        CoreWoodPlugin.TryAddPiece(AddPictureFrame);
        CoreWoodPlugin.TryAddPiece(AddPictureFrameVertical);
        CoreWoodPlugin.TryAddPiece(AddPictureFrameSquare);
        Add("mm_wood_carving_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2)));
        Add("mm_wood_carving_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2)));
        Add("mm_corewood_stuffed_crow", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Feathers", 40), Req("RawMeat", 2)));
        Add("mm_corewood_stuffed_seagul", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Feathers", 40), Req("RawMeat", 2)));
        Add("mm_corewood_stuffed_boar", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("TrophyBoar", 1), Req("RawMeat", 10), Req("LeatherScraps", 10)));
        Add("mm_corewood_stuffed_deer", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("TrophyDeer", 1), Req("DeerMeat", 10), Req("DeerHide", 10)));
        Add("mm_corewood_stuffed_wolf", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("TrophyWolf", 1), Req("WolfMeat", 10), Req("WolfPelt", 5)));
        Add("mm_corewood_stuffed_vulture", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("TrophyVolture", 1), Req("VoltureMeat", 10), Req("Feathers", 20)));
        Add("mm_corewood_stuffed_werewolf", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("TrophyFenring", 1), Req("WolfMeat", 10), Req("WolfPelt", 8)));
        Add("mm_corewood_creature_stand_small", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2)), fixReference: false);
        Add("mm_corewood_creature_stand_medium", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 3)), fixReference: false);
        Add("mm_corewood_creature_stand_large", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 4)), fixReference: false);
        Add("mm_bookstack_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)), fixReference: false);
        Add("mm_bookstack_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)), fixReference: false);
        Add("mm_bookstack_03", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)), fixReference: false);
        Add("mm_bookstack_04", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)), fixReference: false);
        Add("mm_bookstack_05", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)), fixReference: false);
        Add("mm_bookstack_06", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)), fixReference: false);
        Add("mm_bowlstack_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)));
        Add("mm_bowlstack_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)));
        Add("mm_platestack_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)));
        Add("mm_platestack_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Wood", 1)));
        Add("mm_saucepan_01", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Iron", 1)));
        Add("mm_saucepan_02", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Iron", 1)));
        Add("mm_decorative_goblet", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Bronze", 1)));
        Add("mm_decorative_pitcher", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Bronze", 1)));
        Add("mm_decorative_plate", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Bronze", 2)));
        Add("mm_decorative_bowl", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Bronze", 1)));
        Add("mm_decorative_plate_large", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Bronze", 2)));
        Add("mm_decorative_bowl_large", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Bronze", 1)));
        Add("mm_cutlery_set", PieceSfx.Metal, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Bronze", 1)));
        Add("mm_haybale", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("Barley", 10), Req("Flax", 10)));

        CoreWoodPlugin.TryAddPiece(AddWallTorch);
        CoreWoodPlugin.TryAddPiece(AddDeerChandelier);
        CoreWoodPlugin.TryAddPiece(AddSkullCandles);
        CoreWoodPlugin.TryAddPiece(AddLavaLantern);
        CoreWoodPlugin.TryAddPiece(AddSurtlingLantern);
        CoreWoodPlugin.TryAddPiece(AddSurtlingLamppostSingle);
        CoreWoodPlugin.TryAddPiece(AddSurtlingLamppostDouble);
        CoreWoodPlugin.TryAddPiece(AddCrystalLight);
        CoreWoodPlugin.TryAddPiece(AddRopeLights);
        CoreWoodPlugin.TryAddPiece(AddBrazier);
        Add("mm_corewood_bonemass_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_eikthyr_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_elder_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_fader_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_moder_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_queen_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_yagluth_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_haldor_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_hildir_banner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 5)));
        Add("mm_corewood_wall_banner_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 8)));
        Add("mm_corewood_wall_banner_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 8)));
        Add("mm_corewood_wall_banner_03", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 8)));
        Add("mm_corewood_wall_banner_04", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 2), Req("LinenThread", 8)));
        Add("mm_rug_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("LinenThread", 10)), fixReference: false);
        Add("mm_rug_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("LinenThread", 10)), fixReference: false);
        Add("mm_rug_03", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("LinenThread", 10)), fixReference: false);
    }

    public static void AddCoreWoodChest()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_chest_public");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Storage }, Req("RoundLog", 2), Req("Bronze", 1)));
        Container component2 = gameObject.GetComponent<Container>();
        component2.m_width = MainConfig.chestColumns.Value;
        component2.m_height = MainConfig.chestRows.Value;
        component2.m_openEffects = chestOpen;
        component2.m_closeEffects = chestClose;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodPrivateChest()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_chest_private");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Storage }, Req("RoundLog", 2), Req("Iron", 2)));
        Container component2 = gameObject.GetComponent<Container>();
        component2.m_width = MainConfig.chestPrivateColumns.Value;
        component2.m_height = MainConfig.chestPrivateRows.Value;
        component2.m_openEffects = chestOpen;
        component2.m_closeEffects = chestClose;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodStackableChest()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_stackable_chest");
        if (gameObject == null)
        {
            return;
        }
        GameObject prefab = PrefabManager.Instance.GetPrefab("sign");
        if (!(prefab == null))
        {
            TextMeshProUGUI textMeshProUGUI = SignHelper.CreateText(SignHelper.CreateSignCanvas("SignCanvas", gameObject.transform, default(Vector3), Quaternion.Euler(0f, 0f, 0f), new Vector2(1f, 1f)).transform, "Text");
            textMeshProUGUI.fontSize = 0f;
            textMeshProUGUI.color = new Color(0f, 0f, 0f, 0f);
            TextMeshProUGUI componentInChildren = prefab.GetComponentInChildren<TextMeshProUGUI>(includeInactive: true);
            if (componentInChildren != null)
            {
                textMeshProUGUI.font = componentInChildren.font;
                textMeshProUGUI.material = componentInChildren.fontMaterial;
            }
            Sign sign = gameObject.AddComponent<Sign>();
            sign.m_textWidget = textMeshProUGUI;
            sign.m_defaultText = "...";
            sign.m_characterLimit = 80;
            NamedChest namedChest = gameObject.AddComponent<NamedChest>();
            namedChest.sign = sign;
            GameObject gameObject2 = SignHelper.CreateSignCanvas("CanvasFront", gameObject.transform, new Vector3(0f, 0.666f, 1.003f), Quaternion.identity, new Vector2(0.75f, 0f));
            namedChest.textFront = SignHelper.CreateText(gameObject2.transform, "TextFront");
            namedChest.textFront.rectTransform.localEulerAngles = new Vector3(0f, 180f, 0f);
            namedChest.textFront.fontSize = 0.13f;
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Storage }, Req("RoundLog", 4), Req("Wood", 4), Req("Coal", 1)));
            Container component2 = gameObject.GetComponent<Container>();
            component2.m_width = MainConfig.chestStackedColumns.Value;
            component2.m_height = MainConfig.chestStackedRows.Value;
            component2.m_openEffects = chestOpen;
            component2.m_closeEffects = chestClose;
            PieceManager.Instance.AddPiece(customPiece);
        }
    }

    public static void AddCoreWoodStackDynamic()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_dynamic_stack");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Storage, PieceUsages.Stacks }, Req("RoundLog", 1)));
        PieceManager.Instance.AddPiece(customPiece);
        CoreWoodPlugin.PrepareContainer(gameObject);
        RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "RoundLog" });
    }

    public static void AddCoreWoodTrough()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_trough");
        gameObject.AddComponent<TroughVisualState>();
        gameObject.AddComponent<TroughAutoCollect>();

        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Storage }, Req("RoundLog", 2)));
        PieceManager.Instance.AddPiece(customPiece);
        RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, troughItems);
    }


    public static void AddCoreWoodRoaster()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_hog_roast");
        PieceConfig config = Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Crafting }, Req("RoundLog", 2));
        config.Name = "$piece_mm_corewood_hog_roast";
        config.Description = "$piece_mm_corewood_hog_roast_desc";
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, config);
        HogRoast hogRoast = gameObject.GetComponent<HogRoast>();
        if (hogRoast == null)
        {
            hogRoast = gameObject.AddComponent<HogRoast>();
        }
        CookingStation cookingStation = PrefabManager.Instance.GetPrefab("piece_cookingstation")?.GetComponent<CookingStation>();
        if (cookingStation != null)
        {
            hogRoast.m_addEffects = cookingStation.m_addEffect;
            hogRoast.m_doneEffects = cookingStation.m_doneEffect;
        }
        PieceManager.Instance.AddPiece(customPiece);
    }













	public static void AddCoreWoodBookshelfSmall()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_bookshelf_small");
		PieceConfig config = Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 2));
		config.Name = "$piece_mm_corewood_bookshelf_small";
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, config);
		PieceManager.Instance.AddPiece(customPiece);
	}



	public static void AddCoreWoodCabinetWall()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_wall_cabinet");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 2), Req("Wood", 2), Req("Bronze", 1)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodCabinetTall()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_tall_cabinet");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 2), Req("Bronze", 1)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodCabinetTallDouble()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_tall_cabinet_double");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 5), Req("Bronze", 1)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodCabinetArmor()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_cabinet_armor");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Furniture }, Req("RoundLog", 6), Req("Bronze", 1)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}



















    public static void AddPictureFrame()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_picture_frame");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 1), Req("LinenThread", 4), Req("BronzeNails", 1)));
        gameObject.AddComponent<PictureFrame>();
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddPictureFrameVertical()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_picture_frame_vertical");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 1), Req("LinenThread", 4), Req("BronzeNails", 1)));
        gameObject.AddComponent<PictureFrameVertical>();
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddPictureFrameSquare()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_picture_frame_square");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor }, Req("RoundLog", 1), Req("LinenThread", 4), Req("BronzeNails", 1)));
        gameObject.AddComponent<PictureFrameSquare>();
        PieceManager.Instance.AddPiece(customPiece);
    }


































    public static void AddWallTorch()
	{
		GameObject gameObject = LoadPrefab("mm_horn_walltorch");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 1), Req("Iron", 1), Req("BoneFragments", 1), Req("Resin", 1)));
		Fireplace component2 = gameObject.GetComponent<Fireplace>();
		component2.m_fuelItem = fuelResin;
		component2.m_fuelAddedEffects = addFuel;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddDeerChandelier()
	{
		GameObject gameObject = LoadPrefab("mm_deerchandelier");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("TrophyDeer", 4), Req("Iron", 3), Req("BoneFragments", 4), Req("Resin", 4)));
		Fireplace component2 = gameObject.GetComponent<Fireplace>();
		component2.m_fuelItem = fuelResin;
		component2.m_fuelAddedEffects = addFuel;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSkullCandles()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_skull_candles");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 1), Req("BoneFragments", 6), Req("Resin", 3)));
		Fireplace component2 = gameObject.GetComponent<Fireplace>();
		component2.m_fuelItem = fuelResin;
		component2.m_fuelAddedEffects = addFuel;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddLavaLantern()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_lavalantern");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 1), Req("FlametalOreNew", 1), Req("SurtlingCore", 1)));
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSurtlingLantern()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_surtling_lantern");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 1), Req("Iron", 2), Req("SurtlingCore", 1)));
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSurtlingLamppostSingle()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_surtling_lamppost_single");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 3), Req("Iron", 2), Req("SurtlingCore", 1)));
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSurtlingLamppostDouble()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_surtling_lamppost_double");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 4), Req("Iron", 2), Req("SurtlingCore", 2)));
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCrystalLight()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_crystal_light");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 4), Req("Wood", 2), Req("Crystal", 2)));
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddRopeLights()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_rope_lights");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 2), Req("LinenThread", 2), Req("Crystal", 3)));
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddBrazier()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_brazier");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Decor", new[] { PieceUsages.Decor, PieceUsages.Lighting }, Req("RoundLog", 4), Req("Stone", 2), Req("Iron", 2), Req("Coal", 5)));
		Fireplace component2 = gameObject.GetComponent<Fireplace>();
		component2.m_fuelItem = fuelCoal;
		component2.m_fuelAddedEffects = addFuel;
		PieceManager.Instance.AddPiece(customPiece);
	}

















}
