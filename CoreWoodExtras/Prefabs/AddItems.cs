using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras;

internal class AddItems
{
	public static void LoadItems()
	{
		CoreWoodPlugin.TryAddPiece(AddPlanterSmall);
		CoreWoodPlugin.TryAddPiece(AddPlanterLarge);
		CoreWoodPlugin.TryAddPiece(AddVase01);
		CoreWoodPlugin.TryAddPiece(AddVase02);
		CoreWoodPlugin.TryAddPiece(AddVase03);
	}

	public static void AddPlanterSmall()
	{
		CustomItem customItem = new CustomItem(CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_small"), fixReference: true, new ItemConfig
		{
			Amount = 1,
			CraftingStation = "mm_corewood_greenhouse_workbench",
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
		ItemManager.Instance.AddItem(customItem);
	}

	public static void AddPlanterLarge()
	{
		CustomItem customItem = new CustomItem(CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_corewood_planter_large"), fixReference: true, new ItemConfig
		{
			Amount = 1,
			CraftingStation = "mm_corewood_greenhouse_workbench",
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
		ItemManager.Instance.AddItem(customItem);
	}

	public static void AddVase01()
	{
		CustomItem customItem = new CustomItem(CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_vase_01"), fixReference: true, new ItemConfig
		{
			Amount = 1,
			CraftingStation = "mm_corewood_greenhouse_workbench",
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
		ItemManager.Instance.AddItem(customItem);
	}

	public static void AddVase02()
	{
		CustomItem customItem = new CustomItem(CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_vase_02"), fixReference: true, new ItemConfig
		{
			Amount = 1,
			CraftingStation = "mm_corewood_greenhouse_workbench",
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
		ItemManager.Instance.AddItem(customItem);
	}

	public static void AddVase03()
	{
		CustomItem customItem = new CustomItem(CoreWoodPlugin.cwextras_new.LoadAsset<GameObject>("mm_vase_03"), fixReference: true, new ItemConfig
		{
			Amount = 1,
			CraftingStation = "mm_corewood_greenhouse_workbench",
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
		ItemManager.Instance.AddItem(customItem);
	}
}
