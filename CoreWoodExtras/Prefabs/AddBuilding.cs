using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;

namespace CoreWoodExtras;

internal class AddBuilding
{
	public static void LoadPieces()
	{
		PieceAssets.Init();
		CoreWoodPlugin.TryAddPiece(AddSteakWall);
		CoreWoodPlugin.TryAddPiece(AddSharpSteaks01);
		CoreWoodPlugin.TryAddPiece(AddSharpSteaks02);
		CoreWoodPlugin.TryAddPiece(AddSharpSteaks03);
		CoreWoodPlugin.TryAddPiece(AddSharpSteaks04);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisade);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeTall);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodDecking2m);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodDecking);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodFloorHalf);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodFloor);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodFloor4m);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPlanks);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPlanks4m);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPavingStraight);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPavingCross);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPavingCorner);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPavingCurve);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodCross26);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodCross45);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWallRoof26);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWallRoof45);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWallRoofUpsidedown26);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWallRoofUpsidedown45);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRoof26);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRoof45);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRoofICorner26);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRoofICorner45);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRoofOCorner26);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRoofOCorner45);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRoofTop26);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRoofTop45);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWallQuarter);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWallHalf);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWallV);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWall4m);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodGateLeft);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodGateRight);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodGateSmallLeft);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodGateSmallRight);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodTrapdoor);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowSingle);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowDouble);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowTall);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowSmallAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowMediumAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowLargeAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodShutterSmallAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodShutterMediumAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodShutterLargeAnimated);
		CoreWoodPlugin.TryAddPiece(AddLargeStainedWindow01);
		CoreWoodPlugin.TryAddPiece(AddLargeStainedWindow02);
		CoreWoodPlugin.TryAddPiece(AddLargeStainedWindow03);
		CoreWoodPlugin.TryAddPiece(AddMediumStainedWindow01);
		CoreWoodPlugin.TryAddPiece(AddMediumStainedWindow02);
		CoreWoodPlugin.TryAddPiece(AddMediumStainedWindow03);
		CoreWoodPlugin.TryAddPiece(AddSmallStainedWindow01);
		CoreWoodPlugin.TryAddPiece(AddSmallStainedWindow02);
		CoreWoodPlugin.TryAddPiece(AddSmallStainedWindow03);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWattleFence);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodPost);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodFenceLarge);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodFenceSmall);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodFenceSmallAlt);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodFenceSmallGate);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRopeFence);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodRopeFenceAngled);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodStairs);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodStepladder);
		CoreWoodPlugin.TryAddPiece(AddFootbridgeSmall);
		CoreWoodPlugin.TryAddPiece(AddFootbridgeLarge);
		CoreWoodPlugin.TryAddPiece(AddWoodPoleLog1);
		CoreWoodPlugin.TryAddPiece(AddWoodPoleLog2);
		CoreWoodPlugin.TryAddPiece(AddWoodPoleLog3);
		CoreWoodPlugin.TryAddPiece(AddWoodPoleLog4);
		CoreWoodPlugin.TryAddPiece(AddWoodWallLog1);
		CoreWoodPlugin.TryAddPiece(AddWoodWallLog2);
		CoreWoodPlugin.TryAddPiece(AddWoodWallLog3);
		CoreWoodPlugin.TryAddPiece(AddWoodWallLog4);
		CoreWoodPlugin.TryAddPiece(AddWoodPoleLog1Thin);
		CoreWoodPlugin.TryAddPiece(AddWoodPoleLog2Thin);
		CoreWoodPlugin.TryAddPiece(AddWoodPoleLog3Thin);
		CoreWoodPlugin.TryAddPiece(AddWoodPoleLog4Thin);
		CoreWoodPlugin.TryAddPiece(AddWoodWallLog1Thin);
		CoreWoodPlugin.TryAddPiece(AddWoodWallLog2Thin);
		CoreWoodPlugin.TryAddPiece(AddWoodWallLog3Thin);
		CoreWoodPlugin.TryAddPiece(AddWoodWallLog4Thin);
		CoreWoodPlugin.TryAddPiece(AddWoodLog26);
		CoreWoodPlugin.TryAddPiece(AddWoodLog45);
	}

	public static void AddSteakWall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stake_wall");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Defense },
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

	public static void AddCoreWoodDecking2m()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_decking_2x2");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
            Usage = new[] { PieceUsages.Building, PieceUsages.Floor },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Floor },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Floor },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Floor },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Floor },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Floor },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Floor },
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

	public static void AddCoreWoodCross45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_cross45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodWallRoof26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wallroof26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Wall },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Roof },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Wall },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Wall },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Doors },
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
            Usage = new[] { PieceUsages.Building },
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

	public static void AddCoreWoodFenceSmall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fence_small");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodFenceSmallAlt()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fence_small_alt");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodFenceSmallGate()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fence_small_alt_gate");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddCoreWoodRopeFence()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_rope_fence");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
            Usage = new[] { PieceUsages.Building, PieceUsages.Stairs },
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
		GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_stepladder");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
            Usage = new[] { PieceUsages.Building, PieceUsages.Stairs },
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
            Usage = new[] { PieceUsages.Building },
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
            Usage = new[] { PieceUsages.Building },
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
            Usage = new[] { PieceUsages.Building },
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

	public static void AddWoodPoleLog4()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodWallLog1()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_1m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
            Usage = new[] { PieceUsages.Building },
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
            Usage = new[] { PieceUsages.Building },
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

	public static void AddWoodWallLog4()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodPoleLog1Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_thin_1m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
            Usage = new[] { PieceUsages.Building },
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
            Usage = new[] { PieceUsages.Building },
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

	public static void AddWoodPoleLog4Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_pole_log_thin_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodWallLog1Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_thin_1m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
            Usage = new[] { PieceUsages.Building },
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
            Usage = new[] { PieceUsages.Building },
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

	public static void AddWoodWallLog4Thin()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_wall_log_thin_4m");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodLog26()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_log_26");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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

	public static void AddWoodLog45()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wood_log_45");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Building",
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
}
