using CoreWoodExtras.Containers;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using System.Collections.Generic;
using UnityEngine;

namespace CoreWoodExtras;

internal class AddMisc
{
	public static EffectList buildWood;

	public static EffectList breakWood;

	public static EffectList hitWood;

	public static EffectList buildMetal;

	public static EffectList breakMetal;

	public static EffectList hitMetal;

	public static EffectList buildStone;

	public static EffectList breakStone;

	public static EffectList hitStone;

	public static EffectList breakGlass;

	public static EffectList wdOpen;

	public static EffectList wdClose;

	public static void LoadPieces()
	{
		AddFX();
		AddGreenhouseWorkbench();
		AddGreenhouseTable();
		AddGreenhousePlantPot();
		AddGreenhousePlantPots();
		AddGreenhouseSoilBags();
		AddGreenhouseShovel();
		AddGreenhouseRake();
		AddPlanter01();
		AddPlanter02();
		AddPlanter03();
		AddPlanter04();
		AddPlanter05();
		AddPlanter06();
		AddPlanterGlowing();
		AddPlanterRosesRed();
		AddPlanterRosesYellow();
		AddPlanterRosesWhite();
		AddPottedPlant01();
		AddPottedPlant02();
		AddPottedPlant03();
		AddPottedPlant04();
		AddPottedPlant05();
		AddPottedPlant06();
		AddIvyWall2x2();
		AddHedge();
		AddHedgeCorner();
		AddHedgeCurved();
		AddHedgeArch();
		AddCrateAskvinMeat();
		AddCrateBoarMeat();
		AddCrateChickenMeat();
		AddCrateDeerMeat();
		AddCrateHareMeat();
		AddCrateLoxMeat();
		AddCrateVoltureMeat();
		AddCrateWolfMeat();
		AddCrateAnglerFish();
		AddCrateHerringFish();
		AddCratePerchFish();
		AddCrateSerpentFlesh();
		AddCrateTrollFish();
		AddCrateTunaFish();
		AddCrateBlueberries();
		AddCrateCloudberry();
		AddCrateRaspberry();
		AddCrateCarrot();
		AddCrateOnion();
		AddCrateTurnip();
		AddSackBeechSeeds();
		AddSackBirchSeeds();
		AddSackOakSeeds();
		AddSackPineSeeds();
		AddSackCarrotSeeds();
		AddSackOnionSeeds();
		AddSackTurnipSeeds();
		AddSackAncientSeeds();
		AddSackMysticalSeeds();
		AddAsksvinMeatTray();
		AddBoarMeatTray();
		AddChickenMeatTray();
		AddDeerMeatTray();
		AddLoxMeatTray();
		AddSerpentMeatTray();
		AddVoltureMeatTray();
		AddWolfMeatTray();
		AddParasol();
		AddBarrel01();
		AddKeg01();
		AddKeg02();
		AddPrivatePropertySign();
		AddRestingAreaSign();
		AddRepairStationSign();
		AddDocksSign();
		AddTavernSign();
		AddHaldorSign();
		AddHildirSign();
		AddNoticeBoard();
		AddPictureFrame();
		AddPictureFrameVertical();
		AddPictureFrameSquare();
		AddScarecrow();
		AddWoodCarving01();
		AddWoodCarving02();
		AddStuffedCrow();
		AddStuffedSeagul();
		AddStuffedBoar();
		AddStuffedDeer();
		AddStuffedWolf();
		AddStuffedVulture();
		AddStuffedWerewolf();
		AddCreatureStandSmall();
		AddCreatureStandMedium();
		AddCreatureStandLarge();
		AddBookStack01();
		AddBookStack02();
		AddBookStack03();
		AddBookStack04();
		AddBookStack05();
		AddBookStack06();
		AddBowlStack01();
		AddBowlStack02();
		AddPlateStack01();
		AddPlateStack02();
		AddSaucepan01();
		AddSaucepan02();
		AddDecoGoblet();
		AddDecoPitcher();
		AddDecoPlate();
		AddDecoBowl();
		AddDecoPlateLarge();
		AddDecoBowlLarge();
		AddCutlerySet();
		AddHayBale();
		AddGnomeWelcome();
		AddGnomeFemale();
		AddGnomePots();
		AddGnomePalm();
	}

	public static void AddFX()
	{
		GameObject prefab = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_wood");
		GameObject prefab2 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_wood_break");
		GameObject prefab3 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_wood_hit");
		GameObject prefab4 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_door_open");
		GameObject prefab5 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_door_close");
		GameObject prefab6 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_break_glass_mm");
		GameObject prefab7 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_metal");
		GameObject prefab8 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_metal_blocked");
		GameObject prefab9 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_stone");
		GameObject prefab10 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_rock_destroyed");
		GameObject prefab11 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_rock_hit");



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
	}

	public static void AddGreenhouseWorkbench()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_greenhouse_workbench");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddGreenhouseTable()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_greenhouse_table");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddGreenhousePlantPot()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_plant_pot");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_plant_pots");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_soil_bags");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_garden_shovel");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_garden_rake");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_04");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_05");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_06");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_glowing");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_roses_red");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_roses_yellow");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_planter_roses_white");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_potted_plant_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_potted_plant_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_potted_plant_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_potted_plant_04");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_potted_plant_05");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_potted_plant_06");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_ivy_wall_2x2");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_hedge");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_hedge_corner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_hedge_curved");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_hedge_arch");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "mm_corewood_greenhouse_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddCrateLoxMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_lox_meat");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "LoxMeat" });
	}

	public static void AddCrateChickenMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_chicken_meat");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "ChickenMeat" });
	}

	public static void AddCrateDeerMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_deer_meat");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "DeerMeat" });
	}

	public static void AddCrateHareMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_hare_meat");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "HareMeat" });
	}

	public static void AddCrateVoltureMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_volture_meat");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "VoltureMeat" });
	}

	public static void AddCrateWolfMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_wolf_meat");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "WolfMeat" });
	}

	public static void AddCrateBoarMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_boar_meat_new");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "RawMeat" });
	}

	public static void AddCrateAskvinMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_asksvin_meat");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "AsksvinMeat" });
	}

	public static void AddCrateAnglerFish()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_angler_fish");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish9" });
	}

	public static void AddCrateTrollFish()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_trollfish");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish5" });
	}

	public static void AddCrateHerringFish()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_herring_fish");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish6" });
	}

	public static void AddCratePerchFish()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_perch_fish");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish1" });
	}

	public static void AddCrateTunaFish()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_tuna_fish");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Fish3" });
	}

	public static void AddCrateSerpentFlesh()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_serpent_flesh");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "SerpentMeat" });
	}

	public static void AddCrateBlueberries()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_blueberry");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Blueberries" });
	}

	public static void AddCrateRaspberry()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_raspberry");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Raspberry" });
	}

	public static void AddCrateCloudberry()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_cloudberry");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Cloudberry" });
	}

	public static void AddCrateOnion()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_onion");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Onion" });
	}

	public static void AddCrateTurnip()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_turnip");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Turnip" });
	}

	public static void AddCrateCarrot()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crate_carrot");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Carrot" });
	}

	public static void AddSackOakSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_oak_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "Acorn" });
	}

	public static void AddSackBirchSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_birch_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "BirchSeeds" });
	}

	public static void AddSackBeechSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_beech_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "BeechSeeds" });
	}

	public static void AddSackPineSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_pine_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "PineCone" });
	}

	public static void AddSackCarrotSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_carrot_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CarrotSeeds" });
	}

	public static void AddSackTurnipSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_turnip_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "TurnipSeeds" });
	}

	public static void AddSackOnionSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_onion_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "OnionSeeds" });
	}

	public static void AddSackMysticalSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_mystical_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "mm_mystical_seed" });
	}

	public static void AddSackAncientSeeds()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_sack_ancient_seeds");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "AncientSeed" });
	}

	public static void AddAsksvinMeatTray()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_asksvin");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedAsksvinMeat" });
	}

	public static void AddBoarMeatTray()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_boar");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedMeat" });
	}

	public static void AddLoxMeatTray()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_lox");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedLoxMeat" });
	}

	public static void AddWolfMeatTray()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_wolf");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedWolfMeat" });
	}

	public static void AddDeerMeatTray()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_deer");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedDeerMeat" });
	}

	public static void AddChickenMeatTray()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_chicken");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedChickenMeat" });
	}

	public static void AddVoltureMeatTray()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_volture");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "CookedVoltureMeat" });
	}

	public static void AddSerpentMeatTray()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tray_serpent");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
        RestrictContainers._allowedItemsByContainer.Add(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "SerpentMeatCooked" });
	}

	public static void AddParasol()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_parasol");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 2,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Flax",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Barley",
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

	public static void AddBarrel01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_barrel_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[2]
			{
				new RequirementConfig
				{
					Item = "Wood",
					Amount = 6,
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

	public static void AddKeg01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_keg_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[2]
			{
				new RequirementConfig
				{
					Item = "Wood",
					Amount = 6,
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

	public static void AddKeg02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_keg_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddPrivatePropertySign()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_private_sign");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddRestingAreaSign()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_rest_sign");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddRepairStationSign()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_repair_sign");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddDocksSign()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_docks_sign");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddTavernSign()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tavern_sign");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddHaldorSign()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_haldor_sign");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddHildirSign()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_hildir_sign");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddNoticeBoard()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_noticeboard");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddPictureFrame()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_picture_frame");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "LinenThread",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "BronzeNails",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		gameObject.AddComponent<PictureFrame>();
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddPictureFrameVertical()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_picture_frame_vertical");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "LinenThread",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "BronzeNails",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		gameObject.AddComponent<PictureFrameVertical>();
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddPictureFrameSquare()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_picture_frame_square");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "LinenThread",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "BronzeNails",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		gameObject.AddComponent<PictureFrameSquare>();
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddScarecrow()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_scarecrow");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddWoodCarving01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_wood_carving_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddWoodCarving02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_wood_carving_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddStuffedCrow()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stuffed_crow");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[2]
			{
				new RequirementConfig
				{
					Item = "Feathers",
					Amount = 40,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "RawMeat",
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

	public static void AddStuffedSeagul()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stuffed_seagul");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[2]
			{
				new RequirementConfig
				{
					Item = "Feathers",
					Amount = 40,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "RawMeat",
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

	public static void AddStuffedBoar()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stuffed_boar");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "TrophyBoar",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "RawMeat",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "LeatherScraps",
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

	public static void AddStuffedDeer()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stuffed_deer");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "TrophyDeer",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "DeerMeat",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "DeerHide",
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

	public static void AddStuffedWolf()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stuffed_wolf");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "TrophyWolf",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "WolfMeat",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "WolfPelt",
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

	public static void AddStuffedVulture()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stuffed_vulture");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "TrophyVolture",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "VoltureMeat",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Feathers",
					Amount = 20,
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

	public static void AddStuffedWerewolf()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stuffed_werewolf");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "TrophyFenring",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "WolfMeat",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "WolfPelt",
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

	public static void AddCreatureStandSmall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_creature_stand_small");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddCreatureStandMedium()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_creature_stand_medium");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCreatureStandLarge()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_creature_stand_large");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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

	public static void AddBookStack01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_bookstack_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddBookStack02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_bookstack_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddBookStack03()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_bookstack_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddBookStack04()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_bookstack_04");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddBookStack05()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_bookstack_05");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddBookStack06()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_bookstack_06");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddBowlStack01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_bowlstack_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddBowlStack02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_bowlstack_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddPlateStack01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_platestack_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddPlateStack02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_platestack_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
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

	public static void AddSaucepan01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_saucepan_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Iron",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSaucepan02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_saucepan_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Iron",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddDecoGoblet()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_decorative_goblet");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Bronze",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddDecoPitcher()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_decorative_pitcher");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Bronze",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddDecoBowl()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_decorative_bowl");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Bronze",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddDecoBowlLarge()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_decorative_bowl_large");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Bronze",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddDecoPlate()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_decorative_plate");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Bronze",
					Amount = 2,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddDecoPlateLarge()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_decorative_plate_large");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Bronze",
					Amount = 2,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCutlerySet()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_cutlery_set");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Bronze",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildMetal;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakMetal;
		component.m_hitEffect = hitMetal;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddHayBale()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_haybale");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
			Requirements = new RequirementConfig[2]
			{
				new RequirementConfig
				{
					Item = "Barley",
					Amount = 10,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Flax",
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

	public static void AddGnomeWelcome()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_gnome_welcome");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_gnome_female");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_gnome_flowerpots");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_gnome_palm_tree");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Misc",
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
}
