using CoreWoodExtras.Containers;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using System.Collections.Generic;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;
using static CoreWoodExtras.PieceBuilder;

namespace CoreWoodExtras
{
    internal class AddMarket
    {

        public static void LoadPieces()
        {
            PieceAssets.Init();
            Add("mm_corewood_market_stall_meat", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Building }, Req("RoundLog", 8), Req("LinenThread", 6), Req("FreezeGland", 4)));
            Add("mm_corewood_market_stall_fish", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Building }, Req("RoundLog", 8), Req("LinenThread", 6), Req("FreezeGland", 4)));
            Add("mm_corewood_market_stall_veg", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Building }, Req("RoundLog", 8), Req("LinenThread", 6)));
            Add("mm_corewood_market_stall_seeds", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Building }, Req("RoundLog", 8), Req("LinenThread", 6)));
            Add("mm_corewood_market_stall_hot_food", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Building }, Req("RoundLog", 8), Req("LinenThread", 6), Req("Iron", 4), Req("SurtlingCore", 4)));
            CoreWoodPlugin.TryAddPiece(AddCrateAskvinMeat);
            CoreWoodPlugin.TryAddPiece(AddCrateBoarMeat);
            CoreWoodPlugin.TryAddPiece(AddCrateChickenMeat);
            CoreWoodPlugin.TryAddPiece(AddCrateDeerMeat);
            CoreWoodPlugin.TryAddPiece(AddCrateHareMeat);
            CoreWoodPlugin.TryAddPiece(AddCrateLoxMeat);
            CoreWoodPlugin.TryAddPiece(AddCrateVoltureMeat);
            CoreWoodPlugin.TryAddPiece(AddCrateWolfMeat);
            CoreWoodPlugin.TryAddPiece(AddCrateAnglerFish);
            CoreWoodPlugin.TryAddPiece(AddCrateHerringFish);
            CoreWoodPlugin.TryAddPiece(AddCratePerchFish);
            CoreWoodPlugin.TryAddPiece(AddCrateSerpentFlesh);
            CoreWoodPlugin.TryAddPiece(AddCrateTrollFish);
            CoreWoodPlugin.TryAddPiece(AddCrateTunaFish);
            CoreWoodPlugin.TryAddPiece(AddCrateBlueberries);
            CoreWoodPlugin.TryAddPiece(AddCrateCloudberry);
            CoreWoodPlugin.TryAddPiece(AddCrateRaspberry);
            CoreWoodPlugin.TryAddPiece(AddCrateCarrot);
            CoreWoodPlugin.TryAddPiece(AddCrateOnion);
            CoreWoodPlugin.TryAddPiece(AddCrateTurnip);
            CoreWoodPlugin.TryAddPiece(AddSackBeechSeeds);
            CoreWoodPlugin.TryAddPiece(AddSackBirchSeeds);
            CoreWoodPlugin.TryAddPiece(AddSackOakSeeds);
            CoreWoodPlugin.TryAddPiece(AddSackPineSeeds);
            CoreWoodPlugin.TryAddPiece(AddSackCarrotSeeds);
            CoreWoodPlugin.TryAddPiece(AddSackOnionSeeds);
            CoreWoodPlugin.TryAddPiece(AddSackTurnipSeeds);
            CoreWoodPlugin.TryAddPiece(AddSackAncientSeeds);
            CoreWoodPlugin.TryAddPiece(AddSackMysticalSeeds);
            CoreWoodPlugin.TryAddPiece(AddAsksvinMeatTray);
            CoreWoodPlugin.TryAddPiece(AddBoarMeatTray);
            CoreWoodPlugin.TryAddPiece(AddChickenMeatTray);
            CoreWoodPlugin.TryAddPiece(AddDeerMeatTray);
            CoreWoodPlugin.TryAddPiece(AddLoxMeatTray);
            CoreWoodPlugin.TryAddPiece(AddSerpentMeatTray);
            CoreWoodPlugin.TryAddPiece(AddVoltureMeatTray);
            CoreWoodPlugin.TryAddPiece(AddWolfMeatTray);
        }






        public static void AddCrateLoxMeat()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_lox_meat");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("LoxMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "LoxMeat" });
        }

        public static void AddCrateChickenMeat()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_chicken_meat");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("ChickenMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "ChickenMeat" });
        }

        public static void AddCrateDeerMeat()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_deer_meat");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("DeerMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "DeerMeat" });
        }

        public static void AddCrateHareMeat()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_hare_meat");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("HareMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "HareMeat" });
        }

        public static void AddCrateVoltureMeat()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_volture_meat");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("VoltureMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "VoltureMeat" });
        }

        public static void AddCrateWolfMeat()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_wolf_meat");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("WolfMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "WolfMeat" });
        }

        public static void AddCrateBoarMeat()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_boar_meat_new");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("RawMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "RawMeat" });
        }

        public static void AddCrateAskvinMeat()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_asksvin_meat");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("AsksvinMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "AsksvinMeat" });
        }

        public static void AddCrateAnglerFish()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_angler_fish");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Fish9", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish9" });
        }

        public static void AddCrateTrollFish()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_trollfish");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Fish5", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish5" });
        }

        public static void AddCrateHerringFish()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_herring_fish");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Fish6", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish6" });
        }

        public static void AddCratePerchFish()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_perch_fish");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Fish1", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish1" });
        }

        public static void AddCrateTunaFish()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_tuna_fish");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Fish3", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish3" });
        }

        public static void AddCrateSerpentFlesh()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_serpent_flesh");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("SerpentMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "SerpentMeat" });
        }

        public static void AddCrateBlueberries()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_blueberry");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Blueberries", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Blueberries" });
        }

        public static void AddCrateRaspberry()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_raspberry");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Raspberry", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Raspberry" });
        }

        public static void AddCrateCloudberry()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_cloudberry");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Cloudberry", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Cloudberry" });
        }

        public static void AddCrateOnion()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_onion");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Onion", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Onion" });
        }

        public static void AddCrateTurnip()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_turnip");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Turnip", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Turnip" });
        }

        public static void AddCrateCarrot()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_crate_carrot");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Wood", 2), Req("Carrot", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Carrot" });
        }

        public static void AddSackOakSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_oak_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("Acorn", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Acorn" });
        }

        public static void AddSackBirchSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_birch_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("BirchSeeds", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "BirchSeeds" });
        }

        public static void AddSackBeechSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_beech_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("BeechSeeds", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "BeechSeeds" });
        }

        public static void AddSackPineSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_pine_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("PineCone", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "PineCone" });
        }

        public static void AddSackCarrotSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_carrot_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("CarrotSeeds", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CarrotSeeds" });
        }

        public static void AddSackTurnipSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_turnip_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("TurnipSeeds", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "TurnipSeeds" });
        }

        public static void AddSackOnionSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_onion_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("OnionSeeds", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "OnionSeeds" });
        }

        public static void AddSackMysticalSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_mystical_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("mm_mystical_seed", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "mm_mystical_seed" });
        }

        public static void AddSackAncientSeeds()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_sack_ancient_seeds");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("LinenThread", 2), Req("AncientSeed", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "AncientSeed" });
        }

        public static void AddAsksvinMeatTray()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_tray_asksvin");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Iron", 1), Req("CookedAsksvinMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedAsksvinMeat" });
        }

        public static void AddBoarMeatTray()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_tray_boar");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Iron", 1), Req("CookedMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedMeat" });
        }

        public static void AddLoxMeatTray()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_tray_lox");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Iron", 1), Req("CookedLoxMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedLoxMeat" });
        }

        public static void AddWolfMeatTray()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_tray_wolf");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Iron", 1), Req("CookedWolfMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedWolfMeat" });
        }

        public static void AddDeerMeatTray()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_tray_deer");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Iron", 1), Req("CookedDeerMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedDeerMeat" });
        }

        public static void AddChickenMeatTray()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_tray_chicken");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Iron", 1), Req("CookedChickenMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedChickenMeat" });
        }

        public static void AddVoltureMeatTray()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_tray_volture");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Iron", 1), Req("CookedVoltureMeat", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedVoltureMeat" });
        }

        public static void AddSerpentMeatTray()
        {
            GameObject gameObject = LoadPrefab("mm_corewood_tray_serpent");
            CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Market", new[] { PieceUsages.Storage }, Req("Iron", 1), Req("SerpentMeatCooked", 1)), fixReference: false);
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "SerpentMeatCooked" });
        }
    }
}
