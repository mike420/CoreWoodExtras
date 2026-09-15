using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using TMPro;
using UnityEngine;

namespace CoreWoodExtras;

internal class AddDecor
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

	public static EffectList chestOpen;

	public static EffectList chestClose;

	public static EffectList wdOpen;

	public static EffectList wdClose;

	public static EffectList addFuel;

	public static ItemDrop fuelCoal;

	public static ItemDrop fuelResin;

	public static void LoadPieces()
	{
		AddFX();
		AddCoreWoodBench();
		AddCoreWoodBench2();
		AddCoreWoodStump();
		AddCoreWoodThrone();
		AddCoreWoodChair();
		AddCoreWoodTable();
		AddCoreWoodLogChair();
		AddCoreWoodLogTable();
		AddCoreWoodBed();
		AddCoreWoodBed4Poster();
		AddCoreWoodChest();
		AddCoreWoodPrivateChest();
		AddCoreWoodStackableChest();
		AddCoreWoodBookshelfSmall();
		AddCoreWoodBookshelfMedium();
		AddCoreWoodBookshelfLarge();
		AddCoreWoodCabinetWall();
		AddCoreWoodCabinetTall();
		AddCoreWoodCabinetTallDouble();
		AddCoreWoodCabinetArmor();
		AddCoreWoodDisplaycase();
		AddCoreWoodDisplaycaseLarge();
		AddAquarium();
		AddWallTorch();
		AddDeerChandelier();
		AddSkullCandles();
		AddLavaLantern();
		AddSurtlingLantern();
		AddSurtlingLamppostSingle();
		AddSurtlingLamppostDouble();
		AddCrystalLight();
		AddRopeLights();
		AddBrazier();
		AddBonemassBanner();
		AddEikthyrBanner();
		AddElderBanner();
		AddFaderBanner();
		AddModerBanner();
		AddQueenBanner();
		AddYagluthBanner();
		AddHaldorBanner();
		AddHildirBanner();
		AddWallBanner01();
		AddWallBanner02();
		AddWallBanner03();
		AddRug01();
		AddRug02();
		AddRug03();
	}

	public static void AddFX()
	{
		GameObject prefab = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_wood");
		GameObject prefab2 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_wood_break");
		GameObject prefab3 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_wood_hit");
		GameObject prefab4 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_chest_open");
		GameObject prefab5 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_chest_close");
		GameObject prefab6 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_door_open");
		GameObject prefab7 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_door_close");
		GameObject prefab8 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_metal");
		GameObject prefab9 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_metal_blocked");
		GameObject prefab10 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_stone");
		GameObject prefab11 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_rock_destroyed");
		GameObject prefab12 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_rock_hit");
		GameObject prefab13 = PrefabManager.Cache.GetPrefab<GameObject>("vfx_walltorch_addFuel");
		GameObject prefab14 = PrefabManager.Cache.GetPrefab<GameObject>("sfx_FireAddFuel");


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
                        m_prefab = prefab8
                    }
                }
        };
        breakMetal = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab9
                    }
                }
        };
        hitMetal = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab9
                    }
                }
        };

        buildStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab10
                    }
                }
        };
        breakStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab11
                    }
                }
        };
        hitStone = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab12
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
                        m_prefab = prefab6
                    }
                }
        };
        wdClose = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
                    new EffectList.EffectData
                    {
                        m_prefab = prefab7
                    }
                }
        };

        addFuel = new EffectList
        {
            m_effectPrefabs = new EffectList.EffectData[]
                {
					new EffectList.EffectData
					{
						m_prefab = prefab13
					},
					new EffectList.EffectData
					{
						m_prefab = prefab14
					}
                }
        };

		fuelCoal = PrefabManager.Cache.GetPrefab<GameObject>("Coal").GetComponent<ItemDrop>();
		fuelResin = PrefabManager.Cache.GetPrefab<GameObject>("Resin").GetComponent<ItemDrop>();
	}

	public static void AddCoreWoodBench()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_logbench");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodBench2()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_large_bench");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "WolfPelt",
					Amount = 4,
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

	public static void AddCoreWoodStump()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stump_chair");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodThrone()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_throne");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodChair()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_chair");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodTable()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_table");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodLogChair()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_log_stump_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodLogTable()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_log_table_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodBed()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bed");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "DeerHide",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "WolfPelt",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Feathers",
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

	public static void AddCoreWoodBed4Poster()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_4poster_bed");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
			Requirements = new RequirementConfig[4]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 12,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "DeerHide",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "WolfPelt",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Feathers",
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

	public static void AddCoreWoodChest()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_chest_public");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Bronze",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Container component2 = gameObject.GetComponent<Container>();
		component2.m_width = MainConfig.chestColumns.Value;
		component2.m_height = MainConfig.chestRows.Value;
		component2.m_openEffects = chestOpen;
		component2.m_closeEffects = chestClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodPrivateChest()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_chest_private");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Iron",
					Amount = 2,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Container component2 = gameObject.GetComponent<Container>();
		component2.m_width = MainConfig.chestPrivateColumns.Value;
		component2.m_height = MainConfig.chestPrivateRows.Value;
		component2.m_openEffects = chestOpen;
		component2.m_closeEffects = chestClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodStackableChest()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stackable_chest");
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
			CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
			{
				CraftingStation = "piece_workbench",
				PieceTable = "_HammerPieceTable",
				Category = "CoreWood-Decor",
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
						Amount = 4,
						Recover = true
					},
					new RequirementConfig
					{
						Item = "Coal",
						Amount = 1,
						Recover = true
					}
				}
			});
			gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
			WearNTear component = gameObject.GetComponent<WearNTear>();
			component.m_destroyedEffect = breakWood;
			component.m_hitEffect = hitWood;
			Container component2 = gameObject.GetComponent<Container>();
			component2.m_width = MainConfig.chestStackedColumns.Value;
			component2.m_height = MainConfig.chestStackedRows.Value;
			component2.m_openEffects = chestOpen;
			component2.m_closeEffects = chestClose;
			PieceManager.Instance.AddPiece(customPiece);
		}
	}

	public static void AddCoreWoodBookshelfSmall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bookshelf_small");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodBookshelfMedium()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bookshelf_medium");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodBookshelfLarge()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bookshelf_large");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodCabinetWall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wall_cabinet");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Wood",
					Amount = 2,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Bronze",
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
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodCabinetTall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tall_cabinet");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Bronze",
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
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodCabinetTallDouble()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_tall_cabinet_double");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
			Requirements = new RequirementConfig[2]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 5,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Bronze",
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
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodCabinetArmor()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_cabinet_armor");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Bronze",
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
		component2.m_openEffects = wdOpen;
		component2.m_closeEffects = wdClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodDisplaycase()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_displaycase");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddCoreWoodDisplaycaseLarge()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_displaycase_large");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddAquarium()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_aquarium");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_stonecutter",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Crystal",
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

	public static void AddWallTorch()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_horn_walltorch");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
			Requirements = new RequirementConfig[4]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Iron",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "BoneFragments",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Resin",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Fireplace component2 = gameObject.GetComponent<Fireplace>();
		component2.m_fuelItem = fuelResin;
		component2.m_fuelAddedEffects = addFuel;
		Light componentInChildren = gameObject.GetComponentInChildren<Light>(includeInactive: true);
		componentInChildren.intensity = MainConfig.wallLightIntensity.Value;
		componentInChildren.range = MainConfig.wallLightRange.Value;
		if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.None)
		{
			componentInChildren.shadows = LightShadows.None;
			return;
		}
		if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.Hard)
		{
			componentInChildren.shadows = LightShadows.Hard;
			return;
		}
		if (MainConfig.wallLightShadows.Value == MainConfig.ShadowsType.Soft)
		{
			componentInChildren.shadows = LightShadows.Soft;
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddDeerChandelier()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_deerchandelier");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
			Requirements = new RequirementConfig[4]
			{
				new RequirementConfig
				{
					Item = "TrophyDeer",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Iron",
					Amount = 3,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "BoneFragments",
					Amount = 4,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Resin",
					Amount = 4,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Fireplace component2 = gameObject.GetComponent<Fireplace>();
		component2.m_fuelItem = fuelResin;
		component2.m_fuelAddedEffects = addFuel;
		Light[] componentsInChildren = gameObject.GetComponentsInChildren<Light>(includeInactive: true);
		foreach (Light light in componentsInChildren)
		{
			light.intensity = MainConfig.chandelierLightIntensity.Value;
			light.range = MainConfig.chandelierLightRange.Value;
			if (MainConfig.chandelierLightShadows.Value == MainConfig.ShadowsType.None)
			{
				light.shadows = LightShadows.None;
			}
			else if (MainConfig.chandelierLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				light.shadows = LightShadows.Hard;
			}
			else if (MainConfig.chandelierLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				light.shadows = LightShadows.Soft;
			}
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSkullCandles()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_skull_candles");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "BoneFragments",
					Amount = 6,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "Resin",
					Amount = 3,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Fireplace component2 = gameObject.GetComponent<Fireplace>();
		component2.m_fuelItem = fuelResin;
		component2.m_fuelAddedEffects = addFuel;
		Light[] componentsInChildren = gameObject.GetComponentsInChildren<Light>(includeInactive: true);
		foreach (Light light in componentsInChildren)
		{
			light.intensity = MainConfig.skullLightIntensity.Value;
			light.range = MainConfig.skullLightRange.Value;
			if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.None)
			{
				light.shadows = LightShadows.None;
			}
			else if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				light.shadows = LightShadows.Hard;
			}
			else if (MainConfig.skullLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				light.shadows = LightShadows.Soft;
			}
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddLavaLantern()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_lavalantern");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "FlametalOreNew",
					Amount = 1,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "SurtlingCore",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Light componentInChildren = gameObject.GetComponentInChildren<Light>(includeInactive: true);
		componentInChildren.intensity = MainConfig.lavaLightIntensity.Value;
		componentInChildren.range = MainConfig.lavaLightRange.Value;
		if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.None)
		{
			componentInChildren.shadows = LightShadows.None;
			return;
		}
		if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.Hard)
		{
			componentInChildren.shadows = LightShadows.Hard;
			return;
		}
		if (MainConfig.lavaLightShadows.Value == MainConfig.ShadowsType.Soft)
		{
			componentInChildren.shadows = LightShadows.Soft;
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSurtlingLantern()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_surtling_lantern");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Iron",
					Amount = 2,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "SurtlingCore",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Light componentInChildren = gameObject.GetComponentInChildren<Light>(includeInactive: true);
		componentInChildren.intensity = MainConfig.surtlingLanternLightIntensity.Value;
		componentInChildren.range = MainConfig.surtlingLanternLightRange.Value;
		if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.None)
		{
			componentInChildren.shadows = LightShadows.None;
			return;
		}
		if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.Hard)
		{
			componentInChildren.shadows = LightShadows.Hard;
			return;
		}
		if (MainConfig.surtlingLanternLightShadows.Value == MainConfig.ShadowsType.Soft)
		{
			componentInChildren.shadows = LightShadows.Soft;
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSurtlingLamppostSingle()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_surtling_lamppost_single");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
			Requirements = new RequirementConfig[3]
			{
				new RequirementConfig
				{
					Item = "RoundLog",
					Amount = 3,
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
					Item = "SurtlingCore",
					Amount = 1,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Light componentInChildren = gameObject.GetComponentInChildren<Light>(includeInactive: true);
		componentInChildren.intensity = MainConfig.surtlingSingleLightIntensity.Value;
		componentInChildren.range = MainConfig.surtlingSingleLightRange.Value;
		if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.None)
		{
			componentInChildren.shadows = LightShadows.None;
			return;
		}
		if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.Hard)
		{
			componentInChildren.shadows = LightShadows.Hard;
			return;
		}
		if (MainConfig.surtlingSingleLightShadows.Value == MainConfig.ShadowsType.Soft)
		{
			componentInChildren.shadows = LightShadows.Soft;
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddSurtlingLamppostDouble()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_surtling_lamppost_double");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Iron",
					Amount = 2,
					Recover = true
				},
				new RequirementConfig
				{
					Item = "SurtlingCore",
					Amount = 2,
					Recover = true
				}
			}
		});
		gameObject.GetComponent<Piece>().m_placeEffect = buildWood;
		WearNTear component = gameObject.GetComponent<WearNTear>();
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Light[] componentsInChildren = gameObject.GetComponentsInChildren<Light>(includeInactive: true);
		foreach (Light light in componentsInChildren)
		{
			light.intensity = MainConfig.surtlingDoubleLightIntensity.Value;
			light.range = MainConfig.surtlingDoubleLightRange.Value;
			if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.None)
			{
				light.shadows = LightShadows.None;
			}
			else if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				light.shadows = LightShadows.Hard;
			}
			else if (MainConfig.surtlingDoubleLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				light.shadows = LightShadows.Soft;
			}
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCrystalLight()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_crystal_light");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Light componentInChildren = gameObject.GetComponentInChildren<Light>(includeInactive: true);
		componentInChildren.intensity = MainConfig.crystalLightIntensity.Value;
		componentInChildren.range = MainConfig.crystalLightRange.Value;
		if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.None)
		{
			componentInChildren.shadows = LightShadows.None;
			return;
		}
		if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.Hard)
		{
			componentInChildren.shadows = LightShadows.Hard;
			return;
		}
		if (MainConfig.crystalLightShadows.Value == MainConfig.ShadowsType.Soft)
		{
			componentInChildren.shadows = LightShadows.Soft;
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddRopeLights()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_rope_lights");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "LinenThread",
					Amount = 2,
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
		component.m_destroyedEffect = breakWood;
		component.m_hitEffect = hitWood;
		Light[] componentsInChildren = gameObject.GetComponentsInChildren<Light>(includeInactive: true);
		foreach (Light light in componentsInChildren)
		{
			light.intensity = MainConfig.ropeLightIntensity.Value;
			light.range = MainConfig.ropeLightRange.Value;
			if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.None)
			{
				light.shadows = LightShadows.None;
			}
			else if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.Hard)
			{
				light.shadows = LightShadows.Hard;
			}
			else if (MainConfig.ropeLightShadows.Value == MainConfig.ShadowsType.Soft)
			{
				light.shadows = LightShadows.Soft;
			}
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddBrazier()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_brazier");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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
					Item = "Stone",
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
		componentInChildren.intensity = MainConfig.brazierLightIntensity.Value;
		componentInChildren.range = MainConfig.brazierLightRange.Value;
		if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.None)
		{
			componentInChildren.shadows = LightShadows.None;
			return;
		}
		if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.Hard)
		{
			componentInChildren.shadows = LightShadows.Hard;
			return;
		}
		if (MainConfig.brazierLightShadows.Value == MainConfig.ShadowsType.Soft)
		{
			componentInChildren.shadows = LightShadows.Soft;
		}
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddBonemassBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bonemass_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddEikthyrBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_eikthyr_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddElderBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_elder_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddFaderBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_fader_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddModerBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_moder_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddQueenBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_queen_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddYagluthBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_yagluth_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddHaldorBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_haldor_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddHildirBanner()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_hildir_banner");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddWallBanner01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wall_banner_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddWallBanner02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wall_banner_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddWallBanner03()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_wall_banner_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
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

	public static void AddRug01()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_rug_01");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "LinenThread",
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

	public static void AddRug02()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_rug_02");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "LinenThread",
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

	public static void AddRug03()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_rug_03");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: false, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
			Requirements = new RequirementConfig[1]
			{
				new RequirementConfig
				{
					Item = "LinenThread",
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
