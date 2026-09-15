using System.Collections.Generic;
using HarmonyLib;
using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras;

internal class TraderPatches
{
	[HarmonyPatch(typeof(Trader), "GetAvailableItems")]
	public static class GetAvailableItemsPatch
	{
		[HarmonyPriority(200)]
		private static void Postfix(Trader __instance, ref List<Trader.TradeItem> __result)
		{
			if (!__instance.name.Contains("Burt"))
			{
				string name = PrefabManager.Cache.GetPrefab<GameObject>("mm_mystical_seed").name;
				__result.Add(CreateTraderItem(name, 10, 10, "none"));
			}
			if (!MainConfig.traderEnabled.Value || !__instance.name.Contains("Burt"))
			{
				return;
			}
			if (MainConfig.barleyWineEnabled.Value)
			{
				int value = MainConfig.barleyWineStack.Value;
				int value2 = MainConfig.barleyWinePrice.Value;
				if (MainConfig.barleyWineKey.Value != "")
				{
					key = MainConfig.barleyWineKey.Value;
				}
				string name2 = PrefabManager.Cache.GetPrefab<GameObject>("BarleyWine").name;
				__result.Add(CreateTraderItem(name2, value, value2, key));
			}
			if (MainConfig.frostResistEnabled.Value)
			{
				int value3 = MainConfig.frostResistStack.Value;
				int value4 = MainConfig.frostResistPrice.Value;
				if (MainConfig.frostResistKey.Value != "")
				{
					key = MainConfig.frostResistKey.Value;
				}
				string name3 = PrefabManager.Cache.GetPrefab<GameObject>("MeadFrostResist").name;
				__result.Add(CreateTraderItem(name3, value3, value4, key));
			}
			if (MainConfig.poisonResistEnabled.Value)
			{
				int value5 = MainConfig.poisonResistStack.Value;
				int value6 = MainConfig.poisonResistPrice.Value;
				if (MainConfig.poisonResistKey.Value != "")
				{
					key = MainConfig.poisonResistKey.Value;
				}
				string name4 = PrefabManager.Cache.GetPrefab<GameObject>("MeadPoisonResist").name;
				__result.Add(CreateTraderItem(name4, value5, value6, key));
			}
			if (MainConfig.healthMinorEnabled.Value)
			{
				int value7 = MainConfig.healthMinorStack.Value;
				int value8 = MainConfig.healthMinorPrice.Value;
				if (MainConfig.healthMinorKey.Value != "")
				{
					key = MainConfig.healthMinorKey.Value;
				}
				string name5 = PrefabManager.Cache.GetPrefab<GameObject>("MeadHealthMinor").name;
				__result.Add(CreateTraderItem(name5, value7, value8, key));
			}
			if (MainConfig.healthMediumEnabled.Value)
			{
				int value9 = MainConfig.healthMediumStack.Value;
				int value10 = MainConfig.healthMediumPrice.Value;
				if (MainConfig.healthMediumKey.Value != "")
				{
					key = MainConfig.healthMediumKey.Value;
				}
				string name6 = PrefabManager.Cache.GetPrefab<GameObject>("MeadHealthMedium").name;
				__result.Add(CreateTraderItem(name6, value9, value10, key));
			}
			if (MainConfig.healthMajorEnabled.Value)
			{
				int value11 = MainConfig.healthMajorStack.Value;
				int value12 = MainConfig.healthMajorPrice.Value;
				if (MainConfig.healthMajorKey.Value != "")
				{
					key = MainConfig.healthMajorKey.Value;
				}
				string name7 = PrefabManager.Cache.GetPrefab<GameObject>("MeadHealthMajor").name;
				__result.Add(CreateTraderItem(name7, value11, value12, key));
			}
			if (MainConfig.healthLingeringEnabled.Value)
			{
				int value13 = MainConfig.healthLingeringStack.Value;
				int value14 = MainConfig.healthLingeringPrice.Value;
				if (MainConfig.healthLingeringKey.Value != "")
				{
					key = MainConfig.healthLingeringKey.Value;
				}
				string name8 = PrefabManager.Cache.GetPrefab<GameObject>("MeadHealthLingering").name;
				__result.Add(CreateTraderItem(name8, value13, value14, key));
			}
			if (MainConfig.staminaMinorEnabled.Value)
			{
				int value15 = MainConfig.staminaMinorStack.Value;
				int value16 = MainConfig.staminaMinorPrice.Value;
				if (MainConfig.staminaMinorKey.Value != "")
				{
					key = MainConfig.staminaMinorKey.Value;
				}
				string name9 = PrefabManager.Cache.GetPrefab<GameObject>("MeadStaminaMinor").name;
				__result.Add(CreateTraderItem(name9, value15, value16, key));
			}
			if (MainConfig.staminaMediumEnabled.Value)
			{
				int value17 = MainConfig.staminaMediumStack.Value;
				int value18 = MainConfig.staminaMediumPrice.Value;
				if (MainConfig.staminaMediumKey.Value != "")
				{
					key = MainConfig.staminaMediumKey.Value;
				}
				string name10 = PrefabManager.Cache.GetPrefab<GameObject>("MeadStaminaMedium").name;
				__result.Add(CreateTraderItem(name10, value17, value18, key));
			}
			if (MainConfig.staminaLingeringEnabled.Value)
			{
				int value19 = MainConfig.staminaLingeringStack.Value;
				int value20 = MainConfig.staminaLingeringPrice.Value;
				if (MainConfig.staminaLingeringKey.Value != "")
				{
					key = MainConfig.staminaLingeringKey.Value;
				}
				string name11 = PrefabManager.Cache.GetPrefab<GameObject>("MeadStaminaLingering").name;
				__result.Add(CreateTraderItem(name11, value19, value20, key));
			}
			if (MainConfig.eitrMinorEnabled.Value)
			{
				int value21 = MainConfig.eitrMinorStack.Value;
				int value22 = MainConfig.eitrMinorPrice.Value;
				if (MainConfig.eitrMinorKey.Value != "")
				{
					key = MainConfig.eitrMinorKey.Value;
				}
				string name12 = PrefabManager.Cache.GetPrefab<GameObject>("MeadEitrMinor").name;
				__result.Add(CreateTraderItem(name12, value21, value22, key));
			}
			if (MainConfig.eitrLingeringEnabled.Value)
			{
				int value23 = MainConfig.eitrLingeringStack.Value;
				int value24 = MainConfig.eitrLingeringPrice.Value;
				if (MainConfig.eitrLingeringKey.Value != "")
				{
					key = MainConfig.eitrLingeringKey.Value;
				}
				string name13 = PrefabManager.Cache.GetPrefab<GameObject>("MeadEitrLingering").name;
				__result.Add(CreateTraderItem(name13, value23, value24, key));
			}
			if (MainConfig.meadBzerkerEnabled.Value)
			{
				int value25 = MainConfig.meadBzerkerStack.Value;
				int value26 = MainConfig.meadBzerkerPrice.Value;
				if (MainConfig.meadBzerkerKey.Value != "")
				{
					key = MainConfig.meadBzerkerKey.Value;
				}
				string name14 = PrefabManager.Cache.GetPrefab<GameObject>("MeadBzerker").name;
				__result.Add(CreateTraderItem(name14, value25, value26, key));
			}
			if (MainConfig.bugRepellentEnabled.Value)
			{
				int value27 = MainConfig.bugRepellentStack.Value;
				int value28 = MainConfig.bugRepellentPrice.Value;
				if (MainConfig.bugRepellentKey.Value != "")
				{
					key = MainConfig.bugRepellentKey.Value;
				}
				string name15 = PrefabManager.Cache.GetPrefab<GameObject>("MeadBugRepellent").name;
				__result.Add(CreateTraderItem(name15, value27, value28, key));
			}
			if (MainConfig.trollPheromonesEnabled.Value)
			{
				int value29 = MainConfig.trollPheromonesStack.Value;
				int value30 = MainConfig.trollPheromonesPrice.Value;
				if (MainConfig.trollPheromonesKey.Value != "")
				{
					key = MainConfig.trollPheromonesKey.Value;
				}
				string name16 = PrefabManager.Cache.GetPrefab<GameObject>("MeadTrollPheromones").name;
				__result.Add(CreateTraderItem(name16, value29, value30, key));
			}
			if (MainConfig.meadTastyEnabled.Value)
			{
				int value31 = MainConfig.meadTastyStack.Value;
				int value32 = MainConfig.meadTastyPrice.Value;
				if (MainConfig.meadTastyKey.Value != "")
				{
					key = MainConfig.meadTastyKey.Value;
				}
				string name17 = PrefabManager.Cache.GetPrefab<GameObject>("MeadTasty").name;
				__result.Add(CreateTraderItem(name17, value31, value32, key));
			}
			if (MainConfig.meadSwimmerEnabled.Value)
			{
				int value33 = MainConfig.meadSwimmerStack.Value;
				int value34 = MainConfig.meadSwimmerPrice.Value;
				if (MainConfig.meadSwimmerKey.Value != "")
				{
					key = MainConfig.meadSwimmerKey.Value;
				}
				string name18 = PrefabManager.Cache.GetPrefab<GameObject>("MeadSwimmer").name;
				__result.Add(CreateTraderItem(name18, value33, value34, key));
			}
			if (MainConfig.meadHastyEnabled.Value)
			{
				int value35 = MainConfig.meadHastyStack.Value;
				int value36 = MainConfig.meadHastyPrice.Value;
				if (MainConfig.meadHastyKey.Value != "")
				{
					key = MainConfig.meadHastyKey.Value;
				}
				string name19 = PrefabManager.Cache.GetPrefab<GameObject>("MeadHasty").name;
				__result.Add(CreateTraderItem(name19, value35, value36, key));
			}
			if (MainConfig.meadStrengthEnabled.Value)
			{
				int value37 = MainConfig.meadStrengthStack.Value;
				int value38 = MainConfig.meadStrengthPrice.Value;
				if (MainConfig.meadStrengthKey.Value != "")
				{
					key = MainConfig.meadStrengthKey.Value;
				}
				string name20 = PrefabManager.Cache.GetPrefab<GameObject>("MeadStrength").name;
				__result.Add(CreateTraderItem(name20, value37, value38, key));
			}
			if (MainConfig.meadTamerEnabled.Value)
			{
				int value39 = MainConfig.meadTamerStack.Value;
				int value40 = MainConfig.meadTamerPrice.Value;
				if (MainConfig.meadTamerKey.Value != "")
				{
					key = MainConfig.meadTamerKey.Value;
				}
				string name21 = PrefabManager.Cache.GetPrefab<GameObject>("MeadTamer").name;
				__result.Add(CreateTraderItem(name21, value39, value40, key));
			}
			if (MainConfig.meadLightfootEnabled.Value)
			{
				int value41 = MainConfig.meadLightfootStack.Value;
				int value42 = MainConfig.meadLightfootPrice.Value;
				if (MainConfig.meadLightfootKey.Value != "")
				{
					key = MainConfig.meadLightfootKey.Value;
				}
				string name22 = PrefabManager.Cache.GetPrefab<GameObject>("MeadLightfoot").name;
				__result.Add(CreateTraderItem(name22, value41, value42, key));
			}
		}

		private static Trader.TradeItem CreateTraderItem(string itemName, int stackSize, int price, string key)
		{
			ItemDrop component = ObjectDB.instance.GetItemPrefab(itemName).GetComponent<ItemDrop>();
			return new Trader.TradeItem
			{
				m_prefab = component,
				m_stack = stackSize,
				m_price = price,
				m_requiredGlobalKey = key
			};
		}
	}

	public static string key = "none";
}
