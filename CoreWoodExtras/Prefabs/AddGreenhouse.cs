using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using System.IO;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;

namespace CoreWoodExtras
{
    internal class AddGreenhouse
    {


        public static void LoadPieces()
        {
            PieceAssets.Init();
            CoreWoodPlugin.TryAddPiece(AddGreenhouseWorkbench);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseDoor);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhousePanel);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoof);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofGlass);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofGlass45);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofTop);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofGlassTop45);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofWallCorner);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofWallCorner45);
            CoreWoodPlugin.TryAddPiece(AddCoreWoodGreenhouseRoofWallHalf);
            CoreWoodPlugin.TryAddPiece(AddGreenhouseTable);
            CoreWoodPlugin.TryAddPiece(AddGreenhouseSeedbed);
            CoreWoodPlugin.TryAddPiece(AddGreenhousePlantPot);
            CoreWoodPlugin.TryAddPiece(AddGreenhousePlantPots);
            CoreWoodPlugin.TryAddPiece(AddGreenhouseSoilBags);
            CoreWoodPlugin.TryAddPiece(AddGreenhouseShovel);
            CoreWoodPlugin.TryAddPiece(AddGreenhouseRake);
            CoreWoodPlugin.TryAddPiece(AddPlanter01);
            CoreWoodPlugin.TryAddPiece(AddPlanter02);
            CoreWoodPlugin.TryAddPiece(AddPlanter03);
            CoreWoodPlugin.TryAddPiece(AddPlanter04);
            CoreWoodPlugin.TryAddPiece(AddPlanter05);
            CoreWoodPlugin.TryAddPiece(AddPlanter06);
            CoreWoodPlugin.TryAddPiece(AddPlanterGlowing);
            CoreWoodPlugin.TryAddPiece(AddPlanterRosesRed);
            CoreWoodPlugin.TryAddPiece(AddPlanterRosesYellow);
            CoreWoodPlugin.TryAddPiece(AddPlanterRosesWhite);
            CoreWoodPlugin.TryAddPiece(AddPottedPlant01);
            CoreWoodPlugin.TryAddPiece(AddPottedPlant02);
            CoreWoodPlugin.TryAddPiece(AddPottedPlant03);
            CoreWoodPlugin.TryAddPiece(AddPottedPlant04);
            CoreWoodPlugin.TryAddPiece(AddPottedPlant05);
            CoreWoodPlugin.TryAddPiece(AddPottedPlant06);
            CoreWoodPlugin.TryAddPiece(AddIvyWall2x2);
            CoreWoodPlugin.TryAddPiece(AddHedge);
            CoreWoodPlugin.TryAddPiece(AddHedgeCorner);
            CoreWoodPlugin.TryAddPiece(AddHedgeCurved);
            CoreWoodPlugin.TryAddPiece(AddHedgeArch);
            CoreWoodPlugin.TryAddPiece(AddGnomeWelcome);
            CoreWoodPlugin.TryAddPiece(AddGnomeFemale);
            CoreWoodPlugin.TryAddPiece(AddGnomePots);
            CoreWoodPlugin.TryAddPiece(AddGnomePalm);
            CoreWoodPlugin.TryAddPiece(AddScarecrow);
        }

        public static void AddGreenhouseWorkbench()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_greenhouse_workbench");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Crafting },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "FineWood",
                    Amount = 10,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            component.m_switchEffect = placeWorkbench;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseDoor()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_greenhouse_door");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "forge",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Crystal",
                    Amount = 2,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            Door component2 = gameObject.GetComponent<Door>();
            component2.m_openEffects = doorOpen;
            component2.m_closeEffects = doorClose;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhousePanel()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_greenhouse_panel");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "forge",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Crystal",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseRoof()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_roof_greenhouse");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 2,
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

        private static void AddRainBlocker(GameObject piece)
        {
            Transform blocker = piece.transform.Find("rain_blocker");
            if (blocker != null)
            {
                blocker.gameObject.AddComponent<RainBlocker>();
            }
        }

        public static void AddCoreWoodGreenhouseRoofGlass()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_roof_greenhouse_glass");
            AddRainBlocker(gameObject);
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                    new RequirementConfig
                    {
                        Item = "RoundLog",
                        Amount = 2,
                        Recover = true
                    },
                    new RequirementConfig
                    {
                        Item = "Crystal",
                        Amount = 1,
                        Recover = true
                    }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseRoofGlass45()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_roof_greenhouse_glass_45");
            AddRainBlocker(gameObject);
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                    new RequirementConfig
                    {
                        Item = "RoundLog",
                        Amount = 2,
                        Recover = true
                    },
                    new RequirementConfig
                    {
                        Item = "Crystal",
                        Amount = 1,
                        Recover = true
                    }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseRoofTop()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_roofTop_greenhouse");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                    new RequirementConfig
                    {
                        Item = "RoundLog",
                        Amount = 2,
                        Recover = true
                    },
                    new RequirementConfig
                    {
                        Item = "Crystal",
                        Amount = 1,
                        Recover = true
                    }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseRoofGlassTop45()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_roofTop_greenhouse_45");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                    new RequirementConfig
                    {
                        Item = "RoundLog",
                        Amount = 2,
                        Recover = true
                    },
                    new RequirementConfig
                    {
                        Item = "Crystal",
                        Amount = 1,
                        Recover = true
                    }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseRoofWallCorner()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_greenhouse_roof_wall_corner");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "forge",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Crystal",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseRoofWallCorner45()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_greenhouse_roof_wall_corner_45");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "forge",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Crystal",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddCoreWoodGreenhouseRoofWallHalf()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_greenhouse_roof_wall_half");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "forge",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Crystal",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakGlass;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }


        public static void AddGreenhouseTable()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_greenhouse_table");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 10,
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

        public static void AddGreenhouseSeedbed()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_seedbed");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Misc },
                Requirements = new RequirementConfig[2]
                {
                    new RequirementConfig
                    {
                        Item = "RoundLog",
                        Amount = 6,
                        Recover = true
                    },
                    new RequirementConfig
                    {
                        Item = "BronzeNails",
                        Amount = 4,
                        Recover = true
                    }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
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


        public static void AddGreenhousePlantPot()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_plant_pot");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_stonecutter",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "Stone",
                    Amount = 1,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddGreenhousePlantPots()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_plant_pots");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_stonecutter",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "Stone",
                    Amount = 2,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddGreenhouseSoilBags()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_soil_bags");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
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

        public static void AddGreenhouseShovel()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_garden_shovel");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "forge",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
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
        }

        public static void AddGreenhouseRake()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_garden_rake");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "forge",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
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
        }

        public static void AddPlanter01()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_01");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_small",
                    Amount = 1,
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
        }

        public static void AddPlanter02()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_02");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_small",
                    Amount = 1,
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
        }

        public static void AddPlanter03()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_03");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_small",
                    Amount = 1,
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
        }

        public static void AddPlanter04()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_04");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_small",
                    Amount = 1,
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
        }

        public static void AddPlanter05()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_05");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_small",
                    Amount = 1,
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
        }

        public static void AddPlanter06()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_06");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_small",
                    Amount = 1,
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
        }

        public static void AddPlanterGlowing()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_glowing");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_large",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 2,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPlanterRosesRed()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_roses_red");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_large",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 2,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPlanterRosesYellow()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_roses_yellow");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_large",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 2,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPlanterRosesWhite()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_roses_white");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_corewood_planter_large",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 2,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPottedPlant01()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_potted_plant_01");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_vase_01",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPottedPlant02()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_potted_plant_02");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_vase_01",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPottedPlant03()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_potted_plant_03");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_vase_01",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPottedPlant04()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_potted_plant_04");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_vase_02",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPottedPlant05()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_potted_plant_05");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_vase_03",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddPottedPlant06()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_potted_plant_06");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[2]
                {
                new RequirementConfig
                {
                    Item = "mm_vase_02",
                    Amount = 1,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddIvyWall2x2()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_ivy_wall_2x2");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddHedge()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_hedge");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building, PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddHedgeCorner()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_hedge_corner");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building, PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddHedgeCurved()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_hedge_curved");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building, PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddHedgeArch()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_hedge_arch");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "mm_corewood_greenhouse_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Building, PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "mm_mystical_seed",
                    Amount = 1,
                    Recover = false
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddGnomeWelcome()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_gnome_welcome");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_stonecutter",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "Stone",
                    Amount = 2,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddGnomeFemale()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_gnome_female");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_stonecutter",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "Stone",
                    Amount = 2,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddGnomePots()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_gnome_flowerpots");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_stonecutter",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "Stone",
                    Amount = 2,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddGnomePalm()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_gnome_palm_tree");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_stonecutter",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Decor },
                Requirements = new RequirementConfig[1]
                {
                new RequirementConfig
                {
                    Item = "Stone",
                    Amount = 2,
                    Recover = true
                }
                }
            });
            gameObject.GetComponent<Piece>().m_placeEffect = buildStone;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakStone;
            component.m_hitEffect = hitStone;
            PieceManager.Instance.AddPiece(customPiece);
        }

        public static void AddScarecrow()
        {
            GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_scarecrow");
            CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
            {
                CraftingStation = "piece_workbench",
                PieceTable = "_HammerPieceTable",
                Category = "CoreWood-Greenhouse",
                Usage = new[] { PieceUsages.Misc },
                Requirements = new RequirementConfig[2]
                {
                    new RequirementConfig
                    {
                        Item = "Wood",
                        Amount = 4,
                        Recover = true
                    },
                    new RequirementConfig
                    {
                        Item = "LeatherScraps",
                        Amount = 4,
                        Recover = true
                    }
                }
            });

            gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
            WearNTear component = gameObject.GetComponent<WearNTear>();
            component.m_destroyedEffect = breakWood;
            component.m_hitEffect = hitWood;

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
