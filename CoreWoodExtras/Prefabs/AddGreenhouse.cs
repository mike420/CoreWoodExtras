using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using System.IO;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;
using static CoreWoodExtras.PieceBuilder;

namespace CoreWoodExtras
{
    internal class AddGreenhouse
    {
        public static void LoadPieces()
        {
            PieceAssets.Init();
            CoreWoodPlugin.TryAddPiece(AddGreenhouseWorkbench);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseDoor);
            Add("mm_corewood_greenhouse_panel", PieceSfx.Glass, Config("forge", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("Crystal", 1)));
            Add("mm_corewood_roof_greenhouse", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofGlass);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofGlass45);
            Add("mm_corewood_roofTop_greenhouse", PieceSfx.Glass, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("Crystal", 1)));
            Add("mm_corewood_roofTop_greenhouse_45", PieceSfx.Glass, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("Crystal", 1)));
            Add("mm_corewood_greenhouse_roof_wall_corner", PieceSfx.Glass, Config("forge", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 1), Req("Crystal", 1)));
            Add("mm_corewood_greenhouse_roof_wall_corner_45", PieceSfx.Glass, Config("forge", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 1), Req("Crystal", 1)));
            Add("mm_corewood_greenhouse_roof_wall_half", PieceSfx.Glass, Config("forge", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 1), Req("Crystal", 1)));
            Add("mm_corewood_greenhouse_table", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Wood", 10)));
            CoreWoodPlugin.TryAddPiece(AddGreenhouseSeedbed);
            Add("mm_plant_pot", PieceSfx.Stone, Config("piece_stonecutter", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Stone", 1)));
            Add("mm_plant_pots", PieceSfx.Stone, Config("piece_stonecutter", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Stone", 2)));
            Add("mm_soil_bags", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Wood", 2)));
            Add("mm_garden_shovel", PieceSfx.Wood, Config("forge", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Wood", 1), Req("Iron", 1)));
            Add("mm_garden_rake", PieceSfx.Wood, Config("forge", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Wood", 1), Req("Iron", 1)));
            Add("mm_corewood_planter_01", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_small", 1), Req("mm_mystical_seed", 1)));
            Add("mm_corewood_planter_02", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_small", 1), Req("mm_mystical_seed", 1)));
            Add("mm_corewood_planter_03", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_small", 1), Req("mm_mystical_seed", 1)));
            Add("mm_corewood_planter_04", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_small", 1), Req("mm_mystical_seed", 1)));
            Add("mm_corewood_planter_05", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_small", 1), Req("mm_mystical_seed", 1)));
            Add("mm_corewood_planter_06", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_small", 1), Req("mm_mystical_seed", 1)));
            Add("mm_corewood_planter_glowing", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_large", 1), Req("mm_mystical_seed", 2, recover: false)));
            Add("mm_corewood_planter_roses_red", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_large", 1), Req("mm_mystical_seed", 2, recover: false)));
            Add("mm_corewood_planter_roses_yellow", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_large", 1), Req("mm_mystical_seed", 2, recover: false)));
            Add("mm_corewood_planter_roses_white", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_corewood_planter_large", 1), Req("mm_mystical_seed", 2, recover: false)));
            Add("mm_potted_plant_01", PieceSfx.Stone, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_vase_01", 1), Req("mm_mystical_seed", 1, recover: false)), fixReference: false);
            Add("mm_potted_plant_02", PieceSfx.Stone, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_vase_01", 1), Req("mm_mystical_seed", 1, recover: false)), fixReference: false);
            Add("mm_potted_plant_03", PieceSfx.Stone, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_vase_01", 1), Req("mm_mystical_seed", 1, recover: false)), fixReference: false);
            Add("mm_potted_plant_04", PieceSfx.Stone, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_vase_02", 1), Req("mm_mystical_seed", 1, recover: false)), fixReference: false);
            Add("mm_potted_plant_05", PieceSfx.Stone, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_vase_03", 1), Req("mm_mystical_seed", 1, recover: false)), fixReference: false);
            Add("mm_potted_plant_06", PieceSfx.Stone, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_vase_02", 1), Req("mm_mystical_seed", 1, recover: false)), fixReference: false);
            Add("mm_ivy_wall_2x2", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("mm_mystical_seed", 1, recover: false)));
            Add("mm_corewood_hedge", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building, PieceUsages.Decor }, Req("mm_mystical_seed", 1, recover: false)));
            Add("mm_corewood_hedge_corner", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building, PieceUsages.Decor }, Req("mm_mystical_seed", 1, recover: false)));
            Add("mm_corewood_hedge_curved", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building, PieceUsages.Decor }, Req("mm_mystical_seed", 1, recover: false)));
            Add("mm_corewood_hedge_arch", PieceSfx.Wood, Config("mm_corewood_greenhouse_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building, PieceUsages.Decor }, Req("mm_mystical_seed", 1, recover: false)));
            Add("mm_gnome_welcome", PieceSfx.Stone, Config("piece_stonecutter", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Stone", 2)));
            Add("mm_gnome_female", PieceSfx.Stone, Config("piece_stonecutter", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Stone", 2)));
            Add("mm_gnome_flowerpots", PieceSfx.Stone, Config("piece_stonecutter", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Stone", 2)));
            Add("mm_gnome_palm_tree", PieceSfx.Stone, Config("piece_stonecutter", "CoreWood-Greenhouse", new[] { PieceUsages.Decor }, Req("Stone", 2)));
            CoreWoodPlugin.TryAddPiece(AddScarecrow);
        }

        private static void AddRainBlocker(GameObject piece)
        {
            Transform blocker = piece.transform.Find("rain_blocker");
            if (blocker != null)
            {
                blocker.gameObject.AddComponent<RainBlocker>();
            }
        }

        public static void AddGreenhouseWorkbench()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_greenhouse_workbench");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Crafting }, Req("FineWood", 10)));
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_switchEffect = placeWorkbench;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseDoor()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_greenhouse_door");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Glass, Config("forge", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("Crystal", 2)));
            Door component2 = gameObject.GetComponent<Door>();
            component2.m_openEffects = doorOpen;
            component2.m_closeEffects = doorClose;
            PieceManager.Instance.AddPiece(customPiece);
        }



        public static void AddCoreWoodGreenhouseRoofGlass()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_roof_greenhouse_glass");
            AddRainBlocker(gameObject);
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Glass, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("Crystal", 1)));
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseRoofGlass45()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_roof_greenhouse_glass_45");
            AddRainBlocker(gameObject);
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Glass, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("Crystal", 1)));
            PieceManager.Instance.AddPiece(customPiece);
        }








        public static void AddGreenhouseSeedbed()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_seedbed");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Misc }, Req("RoundLog", 6), Req("BronzeNails", 4)));
            SeedBed component2 = gameObject.GetComponent<SeedBed>();
            if (component2 == null)
            {
                component2 = gameObject.AddComponent<SeedBed>();
            }
            component2.m_addEffects = harvestEffects;
            component2.m_harvestEffects = harvestEffects;
            component2.m_spawnEffects = spawnEffects;
            PieceManager.Instance.AddPiece(customPiece);
        }
































        public static void AddScarecrow()
        {
            GameObject gameObject = LoadPrefab("mm_scarecrow");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Greenhouse", new[] { PieceUsages.Misc }, Req("Wood", 4), Req("LeatherScraps", 4)));


            Transform scarecrowChild = Utils.FindChild(gameObject.transform, "New");
            Scarecrow component2 = scarecrowChild != null ? scarecrowChild.GetComponent<Scarecrow>() : null;
            if (component2 != null)
            {
                Transform forcefield = Utils.FindChild(gameObject.transform, "ForceField");
                if (component2.m_forcefield == null && forcefield != null)
                {
                    component2.m_forcefield = forcefield.gameObject;
                }
                component2.m_activateSFX = m_activateSFX;
                component2.m_deactivateSFX = m_deactivateSFX;
            }

            EffectArea component3 = Utils.FindChild(gameObject.transform, "nomonsters").GetComponent<EffectArea>();
            component3.m_statusEffect = "NoMonstersStatusEffect";
            component3.m_statusEffectHash = "NoMonstersStatusEffect".GetStableHashCode();
            component3.m_playerOnly = true;

            PieceManager.Instance.AddPiece(customPiece);
        }
    }
}
