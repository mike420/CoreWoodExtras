using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras;

internal class AddStructures
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

	public static EffectList doorOpen;

	public static EffectList doorClose;

	public static void LoadPieces()
	{
		AddFX();
		AddCoreWoodBar();
		AddCoreWoodOuthouse();
		AddCoreWoodShower();
		AddWaterFountain();
		AddWaterFountain02();
		AddFishPond();
		AddSwimmingPool();
		AddOldWell();
		AddGazebo();
		AddPergola();
		AddLargeAquarium();
		AddCoreWoodArch();
		AddCoreWoodArchIvy();
		AddCoreWoodArchCorner();
		AddCoreWoodMarketStallMeat();
		AddCoreWoodMarketStallFish();
		AddCoreWoodMarketStallVeg();
		AddCoreWoodMarketStallSeeds();
		AddCoreWoodMarketStallHotFood();
	}

	public static void AddFX()
	{
		GameObject prefab = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_wood");
		GameObject prefab2 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_wood_break");
		GameObject prefab3 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_wood_hit");
		GameObject prefab4 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_door_open");
		GameObject prefab5 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_door_close");
		GameObject prefab6 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_metal");
		GameObject prefab7 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_metal_blocked");
		GameObject prefab8 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_stone");
		GameObject prefab9 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_rock_destroyed");
		GameObject prefab10 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_rock_hit");

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
                        m_prefab = prefab6
                    }
                }
        };
        breakMetal = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab7
                    }
                }
        };
        hitMetal = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab7
                    }
                }
        };

        buildStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab8
                    }
                }
        };
        breakStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab9
                    }
                }
        };
        hitStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab10
                    }
                }
        };

        doorOpen = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab4
                    }
                }
        };
        doorClose = new EffectList
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

	public static void AddCoreWoodBar()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bar");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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
		Trader component2 = Utils.FindChild(gameObject.transform, "Burt").gameObject.GetComponent<Trader>();
		if (!MainConfig.traderEnabled.Value)
		{
			component2.gameObject.SetActive(value: false);
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodOuthouse()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_outhouse");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_shower");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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

	public static void AddWaterFountain()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_water_fountain");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Stone",
					Amount = 50,
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

	public static void AddWaterFountain02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_water_fountain_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "Stone",
					Amount = 50,
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

	public static void AddFishPond()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_pond");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_pool");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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

	public static void AddOldWell()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_well");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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

	public static void AddGazebo()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_gazebo");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_pergola");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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

	public static void AddLargeAquarium()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_large_aquarium");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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

	public static void AddCoreWoodArch()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_log_arch");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_log_arch_ivy");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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

	public static void AddCoreWoodArchCorner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_arch_corner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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

	public static void AddCoreWoodMarketStallMeat()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_market_stall_meat");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Structure",
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
			Category = "CoreWood-Structure",
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
			Category = "CoreWood-Structure",
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
			Category = "CoreWood-Structure",
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
			Category = "CoreWood-Structure",
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
}
