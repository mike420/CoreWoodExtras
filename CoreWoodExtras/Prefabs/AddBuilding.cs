using CoreWoodExtras.Containers;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using System.Collections.Generic;
using UnityEngine;

namespace CoreWoodExtras;

internal class AddBuilding
{
	public static EffectList buildWood;

	public static EffectList breakWood;

	public static EffectList hitWood;

	public static EffectList chestOpen;

	public static EffectList chestClose;

	public static EffectList wdOpen;

	public static EffectList wdClose;

	public static EffectList breakGlass;

	public static EffectList buildMetal;

	public static EffectList breakMetal;

	public static EffectList hitMetal;

	public static EffectList buildStone;

	public static EffectList breakStone;

	public static EffectList hitStone;

	public static EffectList bridgeOC;

	public static EffectList towerOC;

	public static EffectList gateOpen;

	public static EffectList gateClose;

	public static EffectList elevator;

	public static EffectList elevatorLong;

	public static EffectList addFuel;

	public static ItemDrop fuelCoal;

	public static ItemDrop fuelResin;

	public static void LoadPieces()
	{
		AddFX();
		AddCoreWoodStack();
		AddCoreWoodStackDynamic();
		AddSteakWall();
		AddSharpSteaks01();
		AddSharpSteaks02();
		AddSharpSteaks03();
		AddSharpSteaks04();
		AddCoreWoodPalisade();
		AddCoreWoodPalisadeTall();
		AddCoreWoodPalisadeGates();
		AddCoreWoodPalisadeTower();
		AddCoreWoodPalisadeEntrance();
		AddCoreWoodPalisadeWall();
		AddCoreWoodPalisadeCorner();
		AddPalisadeBeacon();
		AddCoreWoodBridgePart();
		AddCoreWoodBridgePart02();
		AddCoreWoodBridgeTjunction();
		AddCoreWoodBridgeCrossjunction();
		AddCoreWoodBridgeFoundation();
		AddCoreWoodBridgeFoundation02();
		AddCoreWoodBridgeRamp();
		AddCoreWoodBridgeDrawbridge();
		AddCoreWoodTowerDrawbridge();
		AddCoreWoodDrawbridge();
		AddCoreWoodDrawbridge2();
		AddCoreWoodLiftGate();
		if (MainConfig.enableElevators.Value)
		{
			AddCoreWoodElevatorSmall();
			AddCoreWoodElevatorSmall9();
			AddCoreWoodElevatorLarge();
			AddCoreWoodElevatorLarge9();
			AddCoreWoodElevator01();
			AddCoreWoodElevator02();
			AddCoreWoodElevator03();
			AddCoreWoodElevator04();
		}
		AddCoreWoodDecking2m();
		AddCoreWoodDecking();
		AddCoreWoodFloorHalf();
		AddCoreWoodFloor();
		AddCoreWoodFloor4m();
		AddCoreWoodPlanks();
		AddCoreWoodPlanks4m();
		AddCoreWoodPavingStraight();
		AddCoreWoodPavingCross();
		AddCoreWoodPavingCorner();
		AddCoreWoodPavingCurve();
		AddCoreWoodCross26();
		AddCoreWoodCross45();
		AddCoreWoodWallRoof26();
		AddCoreWoodWallRoof45();
		AddCoreWoodWallRoofUpsidedown26();
		AddCoreWoodWallRoofUpsidedown45();
		AddCoreWoodRoof26();
		AddCoreWoodRoof45();
		AddCoreWoodRoofICorner26();
		AddCoreWoodRoofICorner45();
		AddCoreWoodRoofOCorner26();
		AddCoreWoodRoofOCorner45();
		AddCoreWoodRoofTop26();
		AddCoreWoodRoofTop45();
		AddCoreWoodWallQuarter();
		AddCoreWoodWallHalf();
		AddCoreWoodWallV();
		AddCoreWoodWall4m();
		AddCoreWoodGateLeft();
		AddCoreWoodGateRight();
		AddCoreWoodGateSmallLeft();
		AddCoreWoodGateSmallRight();
		AddCoreWoodTrapdoor();
		AddCoreWoodWindowSingle();
		AddCoreWoodWindowDouble();
		AddCoreWoodWindowTall();
		AddCoreWoodWindowSmallAnimated();
		AddCoreWoodWindowMediumAnimated();
		AddCoreWoodWindowLargeAnimated();
		AddCoreWoodShutterSmallAnimated();
		AddCoreWoodShutterMediumAnimated();
		AddCoreWoodShutterLargeAnimated();
		AddLargeStainedWindow01();
		AddLargeStainedWindow02();
		AddLargeStainedWindow03();
		AddMediumStainedWindow01();
		AddMediumStainedWindow02();
		AddMediumStainedWindow03();
		AddSmallStainedWindow01();
		AddSmallStainedWindow02();
		AddSmallStainedWindow03();
		AddCoreWoodWattleFence();
		AddCoreWoodPost();
		AddCoreWoodFenceLarge();
		AddCoreWoodFenceSmall();
		AddCoreWoodFenceSmallAlt();
		AddCoreWoodFenceSmallGate();
		AddCoreWoodRopeFence();
		AddCoreWoodRopeFenceAngled();
		AddCoreWoodStairs();
		AddCoreWoodStepladder();
		AddFootbridgeSmall();
		AddFootbridgeLarge();
		AddWoodPoleLog1();
		AddWoodPoleLog2();
		AddWoodPoleLog3();
		AddWoodPoleLog4();
		AddWoodWallLog1();
		AddWoodWallLog2();
		AddWoodWallLog3();
		AddWoodWallLog4();
		AddWoodPoleLog1Thin();
		AddWoodPoleLog2Thin();
		AddWoodPoleLog3Thin();
		AddWoodPoleLog4Thin();
		AddWoodWallLog1Thin();
		AddWoodWallLog2Thin();
		AddWoodWallLog3Thin();
		AddWoodWallLog4Thin();
		AddWoodLog26();
		AddWoodLog45();
		AddCoreWoodGreenhouseDoor();
		AddCoreWoodGreenhousePanel();
		AddCoreWoodGreenhouseRoof();
		AddCoreWoodGreenhouseRoofTop();
		AddCoreWoodGreenhouseRoofWallCorner();
		AddCoreWoodGreenhouseRoofWallHalf();
	}

	public static void AddFX()
	{
		GameObject prefab = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_wood");
		GameObject prefab2 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_wood_break");
		GameObject prefab3 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_wood_hit");
		GameObject prefab4 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_chest_open");
		GameObject prefab5 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_chest_close");
		GameObject prefab6 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_break_glass_mm");
		GameObject prefab7 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_metal");
		GameObject prefab8 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_metal_blocked");
		GameObject prefab9 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_stone");
		GameObject prefab10 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_rock_destroyed");
		GameObject prefab11 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_rock_hit");
		GameObject prefab12 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_open_bridge_mm");
		GameObject prefab13 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_tower_bridge_mm");
		GameObject prefab14 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_open_gate_mm");
		GameObject prefab15 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_close_gate_mm");
		GameObject prefab16 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_elevator_mm");
		GameObject prefab17 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_elevator_long_mm");
		GameObject prefab18 = PrefabManager.Cache.GetPrefab<GameObject>("vfx_walltorch_addFuel");
		GameObject prefab19 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_FireAddFuel");
        GameObject prefab20 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_door_open");
        GameObject prefab21 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_door_close");


        buildWood = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab
                    }
                }
        };
        breakWood = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab2
                    }
                }
        };
        hitWood = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab3
                    }
                }
        };

        buildMetal = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab7
                    }
                }
        };
        breakMetal = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab8
                    }
                }
        };
        hitMetal = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab8
                    }
                }
        };

        buildStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab9
                    }
                }
        };
        breakStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab10
                    }
                }
        };
        hitStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab11
                    }
                }
        };

        breakGlass = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab6
                    }
                }
        };

        chestOpen = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab4
                    }
                }
        };
        chestClose = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab5
                    }
                }
        };

        wdOpen = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab4
                    }
                }
        };
        wdClose = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab5
                    }
                }
        };

        gateOpen = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab14
                    }
                }
        };
        gateClose = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab15
                    }
                }
        };

        bridgeOC = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab12
                    }
                }
        };
        towerOC = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab13
                    }
                }
        };

        elevator = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab16
                    }
                }
        };
        elevatorLong = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab17
                    }
                }
        };

        addFuel = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab18
                    },
                    new EffectList.EffectData
                    {
                        m_prefab = prefab19
                    }
                }
        };

		fuelCoal = PrefabManager.Cache.GetPrefab<GameObject>("Coal").GetComponent<ItemDrop>();
		fuelResin = PrefabManager.Cache.GetPrefab<GameObject>("Resin").GetComponent<ItemDrop>();
	}

	public static void AddCoreWoodStack()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stack");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 50,
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

	public static void AddCoreWoodStackDynamic()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_dynamic_stack");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "RoundLog" });
	}

	public static void AddSteakWall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stake_wall");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddSharpSteaks01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stakes_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddSharpSteaks02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stakes_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddSharpSteaks03()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stakes_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddSharpSteaks04()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_refined_sharpstakes");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodPalisade()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_palisadefence");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodPalisadeTall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_palisadefenceTall");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodPalisadeGates()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_palisadefence_gates");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodPalisadeTower()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_palisade_tower");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodPalisadeEntrance()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_palisade_entrance");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_palisade_wall");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_palisade_corner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddPalisadeBeacon()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_palisade_beacon");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		Light componentInChildren = gameObject.GetComponentInChildren<Light>(includeInactive: true);
		componentInChildren.intensity = MainConfig.beaconLightIntensity.Value;
		componentInChildren.range = MainConfig.beaconLightRange.Value;
		if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.None)
		{
			componentInChildren.shadows = LightShadows.None;
			return;
		}
		if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.Hard)
		{
			componentInChildren.shadows = LightShadows.Hard;
			return;
		}
		if (MainConfig.beaconLightShadows.Value == MainConfig.ShadowsType.Soft)
		{
			componentInChildren.shadows = LightShadows.Soft;
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodBridgePart()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bridge_part");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bridge_part_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bridge_tjunction");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bridge_cross_junction");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bridge_foundation");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bridge_foundation_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bridge_ramp");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bridge_drawbridge");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tower_drawbridge");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_drawbridge");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_drawbridge2");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_liftgate");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elevator_small");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elevator_small_9m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elevator_large");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elevator_large_9m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elevator_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elevator_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elevator_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elevator_04");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodDecking2m()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_decking_2x2");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodDecking()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_decking_4x4");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodFloorHalf()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_floor_half");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddCoreWoodFloor()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_floor");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodFloor4m()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_floor_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodPlanks()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planks");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "Wood",
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

	public static void AddCoreWoodPlanks4m()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planks_4x4");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodPavingStraight()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_paving_straight");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "Stone",
					Amount = 5,
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

	public static void AddCoreWoodPavingCross()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_paving_cross");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodPavingCorner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_paving_corner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "Stone",
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

	public static void AddCoreWoodPavingCurve()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_paving_curve");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "Stone",
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

	public static void AddCoreWoodCross26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_cross26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodCross45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_cross45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodWallRoof26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wallroof26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddCoreWoodWallRoof45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wallroof45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddCoreWoodWallRoofUpsidedown26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wallroof_upsidedown26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddCoreWoodWallRoofUpsidedown45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wallroof_upsidedown45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddCoreWoodRoof26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roof26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRoof45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roof45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRoofICorner26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roofICorner26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRoofICorner45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roofICorner45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRoofOCorner26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roofOCorner26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRoofOCorner45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roofOCorner45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRoofTop26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roofTop26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRoofTop45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roofTop45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodWallQuarter()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_quarterwall");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddCoreWoodWallHalf()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_halfwall");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddCoreWoodWallV()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wall_v");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodWall4m()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wall_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodGateLeft()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_gate_left");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodGateRight()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_gate_right");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodGateSmallLeft()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_gate_small_left");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodGateSmallRight()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_gate_small_right");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodTrapdoor()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_trapDoor");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWindowSingle()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_single");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWindowDouble()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_double");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWindowTall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_tall");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWindowSmallAnimated()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_animated_s");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWindowMediumAnimated()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_animated_m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWindowLargeAnimated()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_animated_l");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[2]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 3,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Crystal",
					Amount = 3,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodShutterSmallAnimated()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_shutter_animated_s");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakWood;
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodShutterMediumAnimated()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_shutter_animated_m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 3,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakWood;
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodShutterLargeAnimated()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_shutter_animated_l");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakWood;
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddLargeStainedWindow01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_large_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "Crystal",
					Amount = 4,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddLargeStainedWindow02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_large_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "Crystal",
					Amount = 4,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddLargeStainedWindow03()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_large_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "Crystal",
					Amount = 4,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddMediumStainedWindow01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_medium_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddMediumStainedWindow02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_medium_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddMediumStainedWindow03()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_medium_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSmallStainedWindow01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_small_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSmallStainedWindow02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_small_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSmallStainedWindow03()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_window_small_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component.m_hitEffect = hitWood;
		component.m_destroyedEffect = breakGlass;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWattleFence()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wattle_fence");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodPost()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fencepost");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddCoreWoodFenceLarge()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fence_large");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodFenceSmall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fence_small");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodFenceSmallAlt()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fence_small_alt");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodFenceSmallGate()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fence_small_alt_gate");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRopeFence()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_rope_fence");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "LinenThread",
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

	public static void AddCoreWoodRopeFenceAngled()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_rope_fence_angled");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
					Item = "LinenThread",
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

	public static void AddCoreWoodStairs()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stairs");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodStepladder()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stepladder");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddFootbridgeSmall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_footbridge_small");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddFootbridgeLarge()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_footbridge_large");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddWoodPoleLog1()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_1m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddWoodPoleLog2()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_2m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddWoodPoleLog3()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_3m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodPoleLog4()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodWallLog1()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_1m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddWoodWallLog2()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_2m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddWoodWallLog3()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_3m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodWallLog4()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodPoleLog1Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_thin_1m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddWoodPoleLog2Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_thin_2m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddWoodPoleLog3Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_thin_3m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodPoleLog4Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_thin_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodWallLog1Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_thin_1m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddWoodWallLog2Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_thin_2m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
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

	public static void AddWoodWallLog3Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_thin_3m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodWallLog4Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_thin_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodLog26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_log_26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodLog45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_log_45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodGreenhouseDoor()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_greenhouse_door");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodGreenhousePanel()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_greenhouse_panel");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodGreenhouseRoof()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roof_greenhouse");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodGreenhouseRoofTop()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_roofTop_greenhouse");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodGreenhouseRoofWallCorner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_greenhouse_roof_wall_corner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_greenhouse_roof_wall_half");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
}
