using CoreWoodExtras.Containers;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using System.Collections.Generic;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;

namespace CoreWoodExtras
{
    internal class AddMarket
    {

        public static void LoadPieces()
        {
            PieceAssets.Init();
            CoreWoodPlugin.TryAddPiece(AddCoreWoodMarketStallMeat);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodMarketStallFish);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodMarketStallVeg);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodMarketStallSeeds);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodMarketStallHotFood);
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

        public static void AddCoreWoodMarketStallMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_market_stall_meat");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[3]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 8,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 6,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "FreezeGland",
                    Amount = 4,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodMarketStallFish()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_market_stall_fish");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[3]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 8,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 6,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "FreezeGland",
                    Amount = 4,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodMarketStallVeg()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_market_stall_veg");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 8,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 6,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodMarketStallSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_market_stall_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 8,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 6,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodMarketStallHotFood()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_market_stall_hot_food");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[4]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 8,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 6,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 4,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "SurtlingCore",
                    Amount = 4,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCrateLoxMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_lox_meat");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "LoxMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "LoxMeat" });
        }

        public static void AddCrateChickenMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_chicken_meat");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "ChickenMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "ChickenMeat" });
        }

        public static void AddCrateDeerMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_deer_meat");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "DeerMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "DeerMeat" });
        }

        public static void AddCrateHareMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_hare_meat");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "HareMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "HareMeat" });
        }

        public static void AddCrateVoltureMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_volture_meat");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "VoltureMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "VoltureMeat" });
        }

        public static void AddCrateWolfMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_wolf_meat");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "WolfMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "WolfMeat" });
        }

        public static void AddCrateBoarMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_boar_meat_new");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "RawMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "RawMeat" });
        }

        public static void AddCrateAskvinMeat()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_asksvin_meat");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "AsksvinMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "AsksvinMeat" });
        }

        public static void AddCrateAnglerFish()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_angler_fish");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Fish9",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish9" });
        }

        public static void AddCrateTrollFish()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_trollfish");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Fish5",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish5" });
        }

        public static void AddCrateHerringFish()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_herring_fish");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Fish6",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish6" });
        }

        public static void AddCratePerchFish()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_perch_fish");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Fish1",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish1" });
        }

        public static void AddCrateTunaFish()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_tuna_fish");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Fish3",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish3" });
        }

        public static void AddCrateSerpentFlesh()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_serpent_flesh");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "SerpentMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "SerpentMeat" });
        }

        public static void AddCrateBlueberries()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_blueberry");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Blueberries",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Blueberries" });
        }

        public static void AddCrateRaspberry()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_raspberry");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Raspberry",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Raspberry" });
        }

        public static void AddCrateCloudberry()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_cloudberry");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Cloudberry",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Cloudberry" });
        }

        public static void AddCrateOnion()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_onion");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Onion",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Onion" });
        }

        public static void AddCrateTurnip()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_turnip");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Turnip",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Turnip" });
        }

        public static void AddCrateCarrot()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_carrot");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Carrot",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            CoreWoodPlugin.PrepareContainer(gameObject);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Carrot" });
        }

        public static void AddSackOakSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_oak_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Acorn",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Acorn" });
        }

        public static void AddSackBirchSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_birch_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "BirchSeeds",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "BirchSeeds" });
        }

        public static void AddSackBeechSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_beech_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "BeechSeeds",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "BeechSeeds" });
        }

        public static void AddSackPineSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_pine_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "PineCone",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "PineCone" });
        }

        public static void AddSackCarrotSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_carrot_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "CarrotSeeds",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CarrotSeeds" });
        }

        public static void AddSackTurnipSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_turnip_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "TurnipSeeds",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "TurnipSeeds" });
        }

        public static void AddSackOnionSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_onion_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "OnionSeeds",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "OnionSeeds" });
        }

        public static void AddSackMysticalSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_mystical_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "mm_mystical_seed" });
        }

        public static void AddSackAncientSeeds()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_ancient_seeds");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "LinenThread",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "AncientSeed",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "AncientSeed" });
        }

        public static void AddAsksvinMeatTray()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_asksvin");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "CookedAsksvinMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedAsksvinMeat" });
        }

        public static void AddBoarMeatTray()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_boar");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "CookedMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedMeat" });
        }

        public static void AddLoxMeatTray()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_lox");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "CookedLoxMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedLoxMeat" });
        }

        public static void AddWolfMeatTray()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_wolf");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "CookedWolfMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedWolfMeat" });
        }

        public static void AddDeerMeatTray()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_deer");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "CookedDeerMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedDeerMeat" });
        }

        public static void AddChickenMeatTray()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_chicken");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "CookedChickenMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedChickenMeat" });
        }

        public static void AddVoltureMeatTray()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_volture");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "CookedVoltureMeat",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedVoltureMeat" });
        }

        public static void AddSerpentMeatTray()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_serpent");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Market",
                Usage = new[] { PieceUsages.Storage },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "SerpentMeatCooked",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
            RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "SerpentMeatCooked" });
        }
    }
}
