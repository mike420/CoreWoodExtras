using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;

namespace CoreWoodExtras;

internal class AddStructures
{

    public static void LoadPieces()
	{
		PieceAssets.Init();
		CoreWoodPlugin.TryAddPiece(AddCoreWoodBar);

        CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeTower);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeBeacon);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeEntrance);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeWall);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeCorner);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeGates);

        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgePart);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgePart02);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgeTjunction);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgeCrossjunction);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgeFoundation);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgeFoundation02);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgeRamp);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgeDrawbridge);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodTowerDrawbridge);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodDrawbridge);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodDrawbridge2);

        CoreWoodPlugin.TryAddPiece(AddCoreWoodLiftGate);

        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevatorSmall);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevatorSmall9);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevatorLarge);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevatorLarge9);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevator01);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevator02);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevator03);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevator04);

        CoreWoodPlugin.TryAddPiece(AddGazebo);
        CoreWoodPlugin.TryAddPiece(AddPergola);


        CoreWoodPlugin.TryAddPiece(AddCoreWoodOuthouse);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodShower);
        CoreWoodPlugin.TryAddPiece(AddOldWell);
        CoreWoodPlugin.TryAddPiece(AddSwimmingPool);
        CoreWoodPlugin.TryAddPiece(AddLargeAquarium);


		CoreWoodPlugin.TryAddPiece(AddFishPond);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodArch);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodArchIvy);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodArchCorner);
	}

	public static void AddCoreWoodBar()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bar");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[4]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Wood",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Bronze",
					Amount = 2,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Coins",
					Amount = 1000,
					Recover = false
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Transform burt = Utils.FindChild(gameObject.transform, "Burt");
		if (burt != null)
		{
			gameObject.AddComponent<TraderToggle>().m_trader = burt.gameObject;
		}
		PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodPalisadeTower()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_palisade_tower");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 20,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
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

    public static void AddCoreWoodPalisadeBeacon()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_fixed.LoadAsset<GameObject>("mm_corewood_palisade_beacon");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[4]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 4,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 2,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Coal",
                    Amount = 5,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Fireplace component2 = gameObject.GetComponent<Fireplace>();
        component2.m_fuelItem = fuelCoal;
        component2.m_fuelAddedEffects = addFuel;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodPalisadeEntrance()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_palisade_entrance");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 30,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 8,
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

    public static void AddCoreWoodPalisadeWall()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_palisade_wall");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 40,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 8,
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

    public static void AddCoreWoodPalisadeCorner()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_palisade_corner");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 30,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 8,
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

    public static void AddCoreWoodPalisadeGates()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_palisadefence_gates");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 10,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 6,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = doorOpen;
        component2.m_closeEffects = doorClose;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodBridgePart()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bridge_part");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
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

    public static void AddCoreWoodBridgePart02()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bridge_part_02");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 8,
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

    public static void AddCoreWoodBridgeTjunction()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bridge_tjunction");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 25,
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

    public static void AddCoreWoodBridgeCrossjunction()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bridge_cross_junction");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 32,
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

    public static void AddCoreWoodBridgeFoundation()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bridge_foundation");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 8,
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

    public static void AddCoreWoodBridgeFoundation02()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bridge_foundation_02");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
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

    public static void AddCoreWoodBridgeRamp()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bridge_ramp");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
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

    public static void AddCoreWoodBridgeDrawbridge()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_bridge_drawbridge");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 12,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 5,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = bridgeOC;
        component2.m_closeEffects = bridgeOC;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodTowerDrawbridge()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_tower_drawbridge");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 40,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 10,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = towerOC;
        component2.m_closeEffects = towerOC;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodDrawbridge()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_drawbridge");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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
                    Item = "Wood",
                    Amount = 20,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 6,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = bridgeOC;
        component2.m_closeEffects = bridgeOC;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodDrawbridge2()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_drawbridge2");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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
                    Item = "Wood",
                    Amount = 20,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 6,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = bridgeOC;
        component2.m_closeEffects = bridgeOC;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodLiftGate()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_liftgate");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
            Requirements = new RequirementConfig[3]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 10,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 20,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Bronze",
                    Amount = 8,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = gateOpen;
        component2.m_closeEffects = gateClose;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevatorSmall()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_elevator_small");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[3]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 4,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 5,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 4,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = elevator;
        component2.m_closeEffects = elevator;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevatorSmall9()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_elevator_small_9m");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[3]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 4,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 5,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 8,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = elevatorLong;
        component2.m_closeEffects = elevatorLong;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevatorLarge()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_elevator_large");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
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
                    Item = "Wood",
                    Amount = 10,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 4,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = elevator;
        component2.m_closeEffects = elevator;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevatorLarge9()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_elevator_large_9m");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "forge",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
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
                    Item = "Wood",
                    Amount = 10,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Iron",
                    Amount = 8,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = elevatorLong;
        component2.m_closeEffects = elevatorLong;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevator01()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_elevator_01");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 4,
                    Recover = true
                },
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

    public static void AddCoreWoodElevator02()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_elevator_02");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
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
                    Item = "Wood",
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

    public static void AddCoreWoodElevator03()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_elevator_03");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 12,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
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

    public static void AddCoreWoodElevator04()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_elevator_04");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 16,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 8,
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

    public static void AddGazebo()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_gazebo");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 15,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 15,
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

    public static void AddPergola()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_pergola");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 12,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 12,
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

    public static void AddCoreWoodArchCorner()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_arch_corner");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 14,
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

    public static void AddCoreWoodArch()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_log_arch");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
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

    public static void AddCoreWoodArchIvy()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_log_arch_ivy");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[1]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
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

    public static void AddFishPond()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_pond");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 12,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Stone",
                    Amount = 10,
                    Recover = true
                }
            }
        });
        gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
        WearNTear component = gameObject.GetComponent<WearNTear>();
        component.m_destroyedEffect = breakWood;
        component.m_hitEffect = hitWood;
        Utils.FindChild(gameObject.transform, "sfx_frog_croaking").gameObject.GetComponent<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddSwimmingPool()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_pool");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[3]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 80,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Stone",
                    Amount = 40,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Wood",
                    Amount = 40,
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

    public static void AddLargeAquarium()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_large_aquarium");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_stonecutter",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
            {
                new RequirementConfig
                {
                    Item = "RoundLog",
                    Amount = 12,
                    Recover = true
                },
                new RequirementConfig
                {
                    Item = "Crystal",
                    Amount = 8,
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

    public static void AddCoreWoodOuthouse()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_outhouse");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 6,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Wood",
					Amount = 4,
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
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		Utils.FindChild(gameObject.transform, "SFX").gameObject.GetComponent<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
		Transform transform = Utils.FindChild(gameObject.transform, "Effects");
		if (!MainConfig.toiletEffects.Value)
		{
			transform.gameObject.SetActive(value: false);
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodShower()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_shower");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 12,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Wood",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Iron",
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

	public static void AddOldWell()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_well");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
            Usage = new[] { PieceUsages.Building },
            Requirements = new RequirementConfig[2]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 10,
					Recover = true
				},
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
}
