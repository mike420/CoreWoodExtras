using CoreWoodExtras.Containers;
using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;

namespace CoreWoodExtras;

internal class AddDecor
{
    private static readonly HashSet<string> troughItems = new HashSet<string> {
        "Carrot",
        "Turnip",
        "Onion",
        "Raspberry",
        "Blueberries"
        };

    public static void LoadPieces()
	{
		PieceAssets.Init();
        CoreWoodPlugin.TryAddPiece(AddCoreWoodChest);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPrivateChest);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodStackableChest);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodFeeder);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodStackDynamic);

        CoreWoodPlugin.TryAddPiece(AddCoreWoodStack);
        CoreWoodPlugin.TryAddPiece(AddWaterFountain);
        CoreWoodPlugin.TryAddPiece(AddWaterFountain02);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBench);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodBench2);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodStump);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodThrone);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodChair);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodTable);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodLogChair);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodLogTable);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodBed);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodBed4Poster);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodBookshelfSmall);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodBookshelfMedium);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodBookshelfLarge);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodCabinetWall);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodCabinetTall);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodCabinetTallDouble);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodCabinetArmor);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodDisplaycase);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodDisplaycaseLarge);
		CoreWoodPlugin.TryAddPiece(AddAquarium);

        CoreWoodPlugin.TryAddPiece(AddParasol);
        CoreWoodPlugin.TryAddPiece(AddBarrel01);
        CoreWoodPlugin.TryAddPiece(AddKeg01);
        CoreWoodPlugin.TryAddPiece(AddKeg02);
        CoreWoodPlugin.TryAddPiece(AddPrivatePropertySign);
        CoreWoodPlugin.TryAddPiece(AddRestingAreaSign);
        CoreWoodPlugin.TryAddPiece(AddRepairStationSign);
        CoreWoodPlugin.TryAddPiece(AddDocksSign);
        CoreWoodPlugin.TryAddPiece(AddTavernSign);
        CoreWoodPlugin.TryAddPiece(AddHaldorSign);
        CoreWoodPlugin.TryAddPiece(AddHildirSign);
        CoreWoodPlugin.TryAddPiece(AddNoticeBoard);
        CoreWoodPlugin.TryAddPiece(AddPictureFrame);
        CoreWoodPlugin.TryAddPiece(AddPictureFrameVertical);
        CoreWoodPlugin.TryAddPiece(AddPictureFrameSquare);
        CoreWoodPlugin.TryAddPiece(AddWoodCarving01);
        CoreWoodPlugin.TryAddPiece(AddWoodCarving02);
        CoreWoodPlugin.TryAddPiece(AddStuffedCrow);
        CoreWoodPlugin.TryAddPiece(AddStuffedSeagul);
        CoreWoodPlugin.TryAddPiece(AddStuffedBoar);
        CoreWoodPlugin.TryAddPiece(AddStuffedDeer);
        CoreWoodPlugin.TryAddPiece(AddStuffedWolf);
        CoreWoodPlugin.TryAddPiece(AddStuffedVulture);
        CoreWoodPlugin.TryAddPiece(AddStuffedWerewolf);
        CoreWoodPlugin.TryAddPiece(AddCreatureStandSmall);
        CoreWoodPlugin.TryAddPiece(AddCreatureStandMedium);
        CoreWoodPlugin.TryAddPiece(AddCreatureStandLarge);
        CoreWoodPlugin.TryAddPiece(AddBookStack01);
        CoreWoodPlugin.TryAddPiece(AddBookStack02);
        CoreWoodPlugin.TryAddPiece(AddBookStack03);
        CoreWoodPlugin.TryAddPiece(AddBookStack04);
        CoreWoodPlugin.TryAddPiece(AddBookStack05);
        CoreWoodPlugin.TryAddPiece(AddBookStack06);
        CoreWoodPlugin.TryAddPiece(AddBowlStack01);
        CoreWoodPlugin.TryAddPiece(AddBowlStack02);
        CoreWoodPlugin.TryAddPiece(AddPlateStack01);
        CoreWoodPlugin.TryAddPiece(AddPlateStack02);
        CoreWoodPlugin.TryAddPiece(AddSaucepan01);
        CoreWoodPlugin.TryAddPiece(AddSaucepan02);
        CoreWoodPlugin.TryAddPiece(AddDecoGoblet);
        CoreWoodPlugin.TryAddPiece(AddDecoPitcher);
        CoreWoodPlugin.TryAddPiece(AddDecoPlate);
        CoreWoodPlugin.TryAddPiece(AddDecoBowl);
        CoreWoodPlugin.TryAddPiece(AddDecoPlateLarge);
        CoreWoodPlugin.TryAddPiece(AddDecoBowlLarge);
        CoreWoodPlugin.TryAddPiece(AddCutlerySet);
        CoreWoodPlugin.TryAddPiece(AddHayBale);

        CoreWoodPlugin.TryAddPiece(AddWallTorch);
		CoreWoodPlugin.TryAddPiece(AddDeerChandelier);
		CoreWoodPlugin.TryAddPiece(AddSkullCandles);
		CoreWoodPlugin.TryAddPiece(AddLavaLantern);
		CoreWoodPlugin.TryAddPiece(AddSurtlingLantern);
		CoreWoodPlugin.TryAddPiece(AddSurtlingLamppostSingle);
		CoreWoodPlugin.TryAddPiece(AddSurtlingLamppostDouble);
		CoreWoodPlugin.TryAddPiece(AddCrystalLight);
		CoreWoodPlugin.TryAddPiece(AddRopeLights);
		CoreWoodPlugin.TryAddPiece(AddBrazier);
		CoreWoodPlugin.TryAddPiece(AddBonemassBanner);
		CoreWoodPlugin.TryAddPiece(AddEikthyrBanner);
		CoreWoodPlugin.TryAddPiece(AddElderBanner);
		CoreWoodPlugin.TryAddPiece(AddFaderBanner);
		CoreWoodPlugin.TryAddPiece(AddModerBanner);
		CoreWoodPlugin.TryAddPiece(AddQueenBanner);
		CoreWoodPlugin.TryAddPiece(AddYagluthBanner);
		CoreWoodPlugin.TryAddPiece(AddHaldorBanner);
		CoreWoodPlugin.TryAddPiece(AddHildirBanner);
		CoreWoodPlugin.TryAddPiece(AddWallBanner01);
		CoreWoodPlugin.TryAddPiece(AddWallBanner02);
		CoreWoodPlugin.TryAddPiece(AddWallBanner03);
		CoreWoodPlugin.TryAddPiece(AddRug01);
		CoreWoodPlugin.TryAddPiece(AddRug02);
		CoreWoodPlugin.TryAddPiece(AddRug03);
	}

    public static void AddCoreWoodChest()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_chest_public");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Storage },
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
            Usage = new[] { PieceUsages.Storage },
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
                Usage = new[] { PieceUsages.Storage },
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

    public static void AddCoreWoodStackDynamic()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_dynamic_stack");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Storage, PieceUsages.Stacks },
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
        RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, new HashSet<string> { "RoundLog" });
    }

    public static void AddCoreWoodFeeder()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_trough");
        gameObject.AddComponent<TroughVisualState>();

        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Storage },
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
        RestrictContainers.SetRestriction(gameObject.GetComponent<Container>().m_name, troughItems);
    }


    public static void AddCoreWoodStack()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_stack");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Storage, PieceUsages.Stacks },
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

    public static void AddWaterFountain()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_water_fountain");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_stonecutter",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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

    public static void AddCoreWoodBench()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_logbench");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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

	public static void AddCoreWoodBookshelfSmall()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_corewood_bookshelf_small");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "piece_workbench",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Furniture },
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
            Usage = new[] { PieceUsages.Decor },
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

    public static void AddParasol()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_parasol");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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

    public static void AddWoodCarving01()
    {
        GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_wood_carving_01");
        CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
        {
            CraftingStation = "piece_workbench",
            PieceTable = "_HammerPieceTable",
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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
            Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor },
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


    public static void AddWallTorch()
	{
		GameObject gameObject = CoreWoodPlugin.cwextras.LoadAsset<GameObject>("mm_horn_walltorch");
		CustomPiece customPiece = new CustomPiece(gameObject, fixReference: true, new PieceConfig
		{
			CraftingStation = "forge",
			PieceTable = "_HammerPieceTable",
			Category = "CoreWood-Decor",
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor, PieceUsages.Lighting },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
            Usage = new[] { PieceUsages.Decor },
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
