using System;
using System.Collections;
using System.Collections.Generic;
using CoreWoodExtras.Containers;
using UnityEngine;

namespace CoreWoodExtras
{
	internal class SeedBed : MonoBehaviour, Hoverable, Interactable
	{
		private enum Status
		{
			Empty,
			Germinating,
			Ready
		}

		private enum Layout
		{
			Grid5x5,
			Grid3x1,
			Vine
		}

		private class Conversion
		{
			public ItemDrop From;

			public ItemDrop To;

			public int SeedAmount;

			public int ProducedItems;
		}

		private const string RpcAdd = "RPC_MM_SeedBed_Add";

		private const string RpcHarvest = "RPC_MM_SeedBed_Harvest";

		private const string RpcRefund = "RPC_MM_SeedBed_Refund";

		private const string RpcEffect = "RPC_MM_SeedBed_Effect";

		private const string RpcHarvested = "RPC_MM_SeedBed_Harvested";

		private const int EffectAdd = 0;

		private const int EffectHarvest = 1;

		private const int EffectSpawn = 2;

		private const string FallbackName = "$piece_mm_corewood_seedbed";

		private static readonly int s_content = "mm_seedbed_content".GetStableHashCode();

		private static readonly int s_startTime = "mm_seedbed_start".GetStableHashCode();

		private static readonly int s_lastContent = "mm_seedbed_last".GetStableHashCode();

		private static readonly int s_pendingItem = "mm_seedbed_pending_item".GetStableHashCode();

		private static readonly int s_pendingAmount = "mm_seedbed_pending_amount".GetStableHashCode();

		private static readonly int s_pendingStore = "mm_seedbed_pending_store".GetStableHashCode();

		private const float ReplantRetrySeconds = 5f;

		private const int ClaimAttempts = 5;

		private static readonly Color SaplingColor = new Color(0f, 1f, 0.45f);

		public float m_hoverOffset = 0f;

		public EffectList m_addEffects = new EffectList();

		public EffectList m_harvestEffects = new EffectList();

		public EffectList m_spawnEffects = new EffectList();

		private ZNetView m_nview;

		private Piece m_piece;

		private Transform m_sapling;

		private Transform m_grown;

		private Transform m_sapling5x5;

		private Transform m_grown5x5;

		private Transform m_sapling3x1;

		private Transform m_grown3x1;

		private Transform m_saplingVine;

		private Transform m_grownVine;

		private Transform m_saplingDeco;

		private Transform m_grownDeco;

		private Transform m_spawnPoint;

		private readonly List<GameObject> m_visuals = new List<GameObject>();

		[NonSerialized]
		private readonly Dictionary<Material, Material> m_tintedMaterials = new Dictionary<Material, Material>();

		private string m_visualContent = "";

		private int m_visualVersion = -1;

		private float m_nextReplantCheck;

		private bool m_spawning;

		private bool IsValid => m_nview != null && m_nview.IsValid();

		private string DisplayName => m_piece != null ? m_piece.m_name : FallbackName;

		private void Awake()
		{
			m_nview = GetComponent<ZNetView>();
			m_piece = GetComponent<Piece>();
			FindChildren();
			
			if (!IsValid)
			{
				return;
			}

			m_nview.Register<string, int>(RpcAdd, RPC_Add);
			m_nview.Register(RpcHarvest, RPC_Harvest);
			m_nview.Register<string, int>(RpcRefund, RPC_Refund);
			m_nview.Register<int>(RpcEffect, RPC_Effect);
			m_nview.Register<string>(RpcHarvested, RPC_Harvested);

			WearNTear wearNTear = GetComponent<WearNTear>();
			if (wearNTear != null)
			{
				wearNTear.m_onDestroyed += OnDestroyed;
			}

			SyncVisuals();
			InvokeRepeating(nameof(SyncVisuals), 0.5f, 0.5f);
			InvokeRepeating(nameof(AutoHarvest), 1f, 1f);
			InvokeRepeating(nameof(ReplantFromContainers), 1f, 1f);
		}

		private void FindChildren()
		{
			m_sapling = FindByName(transform, "_sapling");
			m_grown = FindByName(transform, "_grown");
			m_sapling5x5 = FindByName(m_sapling, "_sapling5x5");
			m_sapling3x1 = FindByName(m_sapling, "_sapling3x1");
			m_saplingVine = FindByName(m_sapling, "_saplingvine");
			m_saplingDeco = FindByName(m_sapling, "deco");
			m_grown5x5 = FindByName(m_grown, "_grown5x5");
			m_grown3x1 = FindByName(m_grown, "_grown3x1");
			m_grownVine = FindByName(m_grown, "_grownvine");
			m_grownDeco = FindByName(m_grown, "deco");
			m_spawnPoint = FindByName(transform, "spawnpoint");

			if (m_sapling == null || m_grown == null)
			{
				Jotunn.Logger.LogWarning($"[CoreWoodExtras] SeedBed on '{gameObject.name}' is missing its '_sapling' or '_grown' child, no plants will be shown.");
			}

			DestroySwitch(FindByName(transform, "add_seeds"));
			DestroySwitch(FindByName(transform, "collect_produce"));
		}

		private static Transform FindByName(Transform root, string name)
		{
			return root != null ? Utils.FindChild(root, name) : null;
		}

		private static void DestroySwitch(Transform child)
		{
			Switch component = child != null ? child.GetComponent<Switch>() : null;
			if (component != null)
			{
				Destroy(component);
			}
		}

		private static List<Conversion> s_conversions = new List<Conversion>();

		private static int s_conversionsVersion = -1;

		private static ObjectDB s_conversionsDb;

		private static List<Conversion> GetConversions()
		{
			ObjectDB db = ObjectDB.instance;
			if (db == null)
			{
				return s_conversions;
			}
			if (s_conversionsVersion != SeedBedConversions.Version || s_conversionsDb != db)
			{
				s_conversionsVersion = SeedBedConversions.Version;
				s_conversionsDb = db;
				List<Conversion> list = new List<Conversion>();
				foreach (SeedBedConversions.Conversion entry in SeedBedConversions.Items)
				{
					ItemDrop from = GetItemDrop(db, entry.from);
					ItemDrop to = GetItemDrop(db, entry.to);
					if (from == null || to == null)
					{
						Jotunn.Logger.LogWarning($"[CoreWoodExtras] Seed bed conversion '{entry.from}' -> '{entry.to}' skipped, unknown item.");
						continue;
					}
					list.Add(new Conversion
					{
						From = from,
						To = to,
						SeedAmount = entry.seedAmount,
						ProducedItems = entry.producedItems,
					});
				}
				s_conversions = list;
			}
			return s_conversions;
		}

		private static ItemDrop GetItemDrop(ObjectDB db, string prefabName)
		{
			GameObject prefab = db.GetItemPrefab(prefabName);
			return prefab != null ? prefab.GetComponent<ItemDrop>() : null;
		}

		private static Conversion FindConversion(string prefabName)
		{
			return GetConversions().Find(conversion => conversion.From.gameObject.name == prefabName);
		}

		private static bool HasSeeds(Inventory inventory, Conversion conversion)
		{
			return inventory.CountItems(conversion.From.m_itemData.m_shared.m_name) >= conversion.SeedAmount;
		}

		private static bool FindPlantableSeed(Inventory inventory, out Conversion conversion)
		{
			foreach (Conversion candidate in GetConversions())
			{
				if (HasSeeds(inventory, candidate))
				{
					conversion = candidate;
					return true;
				}
			}
			conversion = null;
			return false;
		}

		private string GetContent()
		{
			return m_nview.GetZDO().GetString(s_content, "");
		}

		private double GetElapsedSeconds()
		{
			long ticks = m_nview.GetZDO().GetLong(s_startTime, 0L);
			if (ticks == 0L)
			{
				return -1.0;
			}
			return (ZNet.instance.GetTime() - new DateTime(ticks)).TotalSeconds;
		}

		private Status GetStatus()
		{
			if (string.IsNullOrEmpty(GetContent()))
			{
				return Status.Empty;
			}
			return GetElapsedSeconds() >= MainConfig.SeedBedGerminationDuration.Value ? Status.Ready : Status.Germinating;
		}

		public string GetHoverName()
		{
			return DisplayName;
		}

		public string GetHoverText()
		{
			if (!IsValid)
			{
				return "";
			}
			if (!PrivateArea.CheckAccess(transform.position, 0f, flash: false))
			{
				return Localization.instance.Localize(DisplayName + "\n$text_no_access_mm");
			}
			switch (GetStatus())
			{
				case Status.Ready:
					return Localization.instance.Localize(DisplayName + "\n( " + GetHarvestName() + ", $text_seedbed_ready_mm )\n[<color=yellow><b>$KEY_Use</b></color>] $text_seedbed_harvest_mm");
				case Status.Germinating:
					return Localization.instance.Localize(DisplayName + " <color=orange><b>" + GetTimeLeft() + "</b></color>\n( " + GetHarvestName() + ", $text_seedbed_germinating_mm )");
				default:
					return Localization.instance.Localize(DisplayName + " ( $text_seedbed_empty_mm )\n[<color=yellow><b>$KEY_Use</b></color>] $text_seedbed_add_mm");
			}
		}

		private string GetHarvestName()
		{
			Conversion conversion = FindConversion(GetContent());
			return conversion != null ? conversion.To.m_itemData.m_shared.m_name : "";
		}

		private string GetTimeLeft()
		{
			int seconds = Mathf.Max(0, Mathf.CeilToInt((float)(MainConfig.SeedBedGerminationDuration.Value - GetElapsedSeconds())));
			return $"({seconds / 60:00}:{seconds % 60:00})";
		}

		public bool Interact(Humanoid user, bool hold, bool alt)
		{
			if (hold || !IsValid || !PrivateArea.CheckAccess(transform.position))
			{
				return false;
			}
			switch (GetStatus())
			{
				case Status.Empty:
					if (!FindPlantableSeed(user.GetInventory(), out Conversion conversion))
					{
						user.Message(MessageHud.MessageType.Center, "$text_seedbed_no_seeds_mm");
						return false;
					}
					return Plant(user, conversion);
				case Status.Ready:
					m_nview.InvokeRPC(RpcHarvest);
					return true;
				default:
					return false;
			}
		}

		private static readonly Skills.SkillType FarmingSkill = (Skills.SkillType)Mathf.Abs("Farming".GetStableHashCode());

		private static readonly Skills.SkillType HerbalistSkill = (Skills.SkillType)Mathf.Abs("Herbalist".GetStableHashCode());

		private static void RaiseHarvestSkills(Humanoid user, Conversion harvested)
		{
			RaiseSkill(user, FarmingSkill, MainConfig.SeedBedFarmingExp.Value);
			if (harvested != null && SeedBedConversions.IsHerb(harvested.To.gameObject.name, harvested.To.m_itemData.m_shared.m_name))
			{
				RaiseSkill(user, HerbalistSkill, MainConfig.SeedBedHerbalistExp.Value);
			}
		}

		private static void RaiseSkill(Humanoid user, Skills.SkillType skill, float amount)
		{
			Skills skills = user.GetSkills();
			if (skills == null || skills.GetSkillDef(skill) == null)
			{
				return;
			}
			user.RaiseSkill(skill, amount);
		}

		public bool UseItem(Humanoid user, ItemDrop.ItemData item)
		{
			if (!IsValid || item == null || item.m_dropPrefab == null || !PrivateArea.CheckAccess(transform.position))
			{
				return false;
			}
			Conversion conversion = FindConversion(item.m_dropPrefab.name);
			if (conversion == null)
			{
				return false;
			}
			if (!HasSeeds(user.GetInventory(), conversion))
			{
				user.Message(MessageHud.MessageType.Center, "$text_seedbed_no_seeds_mm");
				return false;
			}
			return Plant(user, conversion);
		}

		public float GetHoverOffset()
		{
			return m_hoverOffset;
		}

		private bool Plant(Humanoid user, Conversion conversion)
		{
			Inventory inventory = user.GetInventory();
			if (GetStatus() != Status.Empty || !HasSeeds(inventory, conversion))
			{
				return false;
			}
			inventory.RemoveItem(conversion.From.m_itemData.m_shared.m_name, conversion.SeedAmount);
			m_nview.InvokeRPC(RpcAdd, conversion.From.gameObject.name, conversion.SeedAmount);
			return true;
		}

		private void RPC_Add(long sender, string prefabName, int amount)
		{
			if (!m_nview.IsOwner())
			{
				return;
			}
			Conversion conversion = FindConversion(prefabName);
			if (conversion == null || GetStatus() != Status.Empty || amount < conversion.SeedAmount)
			{
				m_nview.InvokeRPC(sender, RpcRefund, prefabName, amount);
				return;
			}
			if (amount > conversion.SeedAmount)
			{
				m_nview.InvokeRPC(sender, RpcRefund, prefabName, amount - conversion.SeedAmount);
			}
			StartGrowing(prefabName);
			PlayEffect(EffectAdd);
		}

		private void RPC_Effect(long sender, int effect)
		{
			EffectList effects = effect switch
			{
				EffectHarvest => m_harvestEffects,
				EffectSpawn => m_spawnEffects,
				_ => m_addEffects,
			};
			effects?.Create(transform.position, effect == EffectSpawn ? Quaternion.identity : transform.rotation);
		}

		private void PlayEffect(int effect)
		{
			m_nview.InvokeRPC(ZNetView.Everybody, RpcEffect, effect);
		}

		private void RPC_Refund(long sender, string prefabName, int amount)
		{
			GameObject prefab = ObjectDB.instance != null ? ObjectDB.instance.GetItemPrefab(prefabName) : null;
			if (prefab == null || amount <= 0)
			{
				return;
			}
			GameObject drop = Instantiate(prefab, GetSpawnPosition(), Quaternion.identity);
			ItemDrop.OnCreateNew(drop);
			ItemDrop itemDrop = drop.GetComponent<ItemDrop>();
			if (itemDrop != null)
			{
				itemDrop.SetStack(amount);
			}
		}

		private void RPC_Harvest(long sender)
		{
			Conversion harvested = HarvestAsOwner(store: false);
			if (harvested != null)
			{
				m_nview.InvokeRPC(sender, RpcHarvested, harvested.From.gameObject.name);
			}
		}

		private void RPC_Harvested(long sender, string prefabName)
		{
			if (Player.m_localPlayer != null)
			{
				RaiseHarvestSkills(Player.m_localPlayer, FindConversion(prefabName));
			}
		}

		private void AutoHarvest()
		{
			ResumePendingProduce();
			if (MainConfig.SeedBedAutoHarvest.Value)
			{
				HarvestAsOwner(store: MainConfig.SeedBedAutoStore.Value);
			}
		}

		private Conversion HarvestAsOwner(bool store)
		{
			if (!IsValid || !m_nview.IsOwner() || GetStatus() != Status.Ready)
			{
				return null;
			}
			string content = GetContent();
			Conversion conversion = FindConversion(content);
			PlayEffect(EffectHarvest);

			int replanted = CanReplant(conversion) ? conversion.SeedAmount : 0;
			if (replanted > 0)
			{
				StartGrowing(content);
				PlayEffect(EffectAdd);
			}
			else
			{
				ClearContent();
				if (MainConfig.SeedBedAutoReplant.Value && conversion != null)
				{
					m_nview.GetZDO().Set(s_lastContent, content);
					m_nextReplantCheck = 0f;
				}
			}
			if (conversion != null)
			{
				DropPendingProduce();
				ZDO zdo = m_nview.GetZDO();
				zdo.Set(s_pendingItem, conversion.To.gameObject.name);
				zdo.Set(s_pendingAmount, conversion.ProducedItems - replanted);
				zdo.Set(s_pendingStore, store);
				StartSpawning();
			}
			return conversion;
		}

		private void StartSpawning()
		{
			if (!m_spawning)
			{
				m_spawning = true;
				StartCoroutine(SpawnProduce());
			}
		}

		private void ResumePendingProduce()
		{
			if (IsValid && m_nview.IsOwner() && !m_spawning && m_nview.GetZDO().GetInt(s_pendingAmount) > 0)
			{
				StartSpawning();
			}
		}

		private bool GetPendingProduce(out ItemDrop item, out int amount, out bool store)
		{
			ZDO zdo = m_nview.GetZDO();
			amount = zdo.GetInt(s_pendingAmount);
			store = zdo.GetBool(s_pendingStore);
			item = ObjectDB.instance != null ? GetItemDrop(ObjectDB.instance, zdo.GetString(s_pendingItem, "")) : null;
			return item != null && amount > 0;
		}

		private void ClearPendingProduce()
		{
			ZDO zdo = m_nview.GetZDO();
			zdo.Set(s_pendingItem, "");
			zdo.Set(s_pendingAmount, 0);
			zdo.Set(s_pendingStore, false);
		}

		private void DropPendingProduce()
		{
			bool found = GetPendingProduce(out ItemDrop item, out int amount, out _);
			ClearPendingProduce();
			if (found)
			{
				SpawnDrops(item, amount);
			}
		}

		private void SpawnDrops(ItemDrop item, int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				ItemDrop.OnCreateNew(Instantiate(item.gameObject, GetSpawnPosition(), Quaternion.identity));
			}
		}

		private static bool CanReplant(Conversion conversion)
		{
			return MainConfig.SeedBedAutoReplant.Value
				&& conversion != null
				&& conversion.From.gameObject.name == conversion.To.gameObject.name
				&& conversion.ProducedItems > conversion.SeedAmount;
		}

		private IEnumerator SpawnProduce()
		{
			yield return new WaitForSeconds(MainConfig.SeedBedHarvestDelay.Value);
			if (!IsValid || !m_nview.IsOwner() || !GetPendingProduce(out ItemDrop item, out int amount, out bool store))
			{
				if (IsValid && m_nview.IsOwner())
				{
					ClearPendingProduce();
				}
				m_spawning = false;
				yield break;
			}
			PlayEffect(EffectSpawn);

			if (store && Player.m_localPlayer != null)
			{
				foreach (Container chest in GetNearbyContainers(includeTroughs: true))
				{
					if (amount <= 0)
					{
						break;
					}
					if (!CanHold(chest, item))
					{
						continue;
					}
					for (int attempt = 0; attempt < ClaimAttempts && chest != null && !chest.IsOwner() && !UtilityMethods.IsInUse(chest); attempt++)
					{
						chest.m_nview.ClaimOwnership();
						if (!chest.IsOwner())
						{
							yield return new WaitForSeconds(0.2f);
						}
					}
					if (!IsValid || !m_nview.IsOwner())
					{
						m_spawning = false;
						yield break;
					}
					if (chest != null && chest.IsOwner() && !UtilityMethods.IsInUse(chest))
					{
						amount -= StoreInContainer(chest, item, amount);
						m_nview.GetZDO().Set(s_pendingAmount, amount);
					}
				}
			}

			if (IsValid && m_nview.IsOwner())
			{
				ClearPendingProduce();
				SpawnDrops(item, amount);
			}
			m_spawning = false;
		}

		private static bool CanHold(Container chest, ItemDrop item)
		{
			return !RestrictContainers.IsRestrictedContainer(chest.GetInventory().m_name, out HashSet<string> allowed) || allowed.Contains(item.gameObject.name);
		}

		private static int StoreInContainer(Container chest, ItemDrop item, int amount)
		{
			Inventory inventory = chest.GetInventory();
			string sharedName = item.m_itemData.m_shared.m_name;
			int maxStack = Mathf.Max(1, item.m_itemData.m_shared.m_maxStackSize);
			int before = inventory.CountItems(sharedName);
			for (int added = 0; added < amount; added += maxStack)
			{
				ItemDrop.ItemData data = item.m_itemData.Clone();
				data.m_dropPrefab = item.gameObject;
				data.m_stack = Mathf.Min(maxStack, amount - added);
				if (!inventory.HaveEmptySlot())
				{
					int room = inventory.FindFreeStackSpace(sharedName, data.m_worldLevel);
					if (room <= 0)
					{
						break;
					}
					data.m_stack = Mathf.Min(data.m_stack, room);
				}
				if (!inventory.AddItem(data))
				{
					break;
				}
			}
			int stored = inventory.CountItems(sharedName) - before;
			if (stored > 0)
			{
				chest.Save();
			}
			return stored;
		}

		private void StartGrowing(string prefabName)
		{
			ZDO zdo = m_nview.GetZDO();
			zdo.Set(s_content, prefabName);
			zdo.Set(s_startTime, ZNet.instance.GetTime().Ticks);
			zdo.Set(s_lastContent, "");
		}

		private void ReplantFromContainers()
		{
			if (!MainConfig.SeedBedAutoReplant.Value || !IsValid || !m_nview.IsOwner() || Time.time < m_nextReplantCheck)
			{
				return;
			}
			string last = m_nview.GetZDO().GetString(s_lastContent, "");
			if (string.IsNullOrEmpty(last) || Player.m_localPlayer == null || GetStatus() != Status.Empty)
			{
				return;
			}
			Conversion conversion = FindConversion(last);
			if (conversion == null)
			{
				return;
			}

			string sharedName = conversion.From.m_itemData.m_shared.m_name;
			Container nearest = GetNearbyContainers(includeTroughs: false).Find(chest => chest.GetInventory().CountItems(sharedName) >= conversion.SeedAmount);
			if (nearest == null)
			{
				m_nextReplantCheck = Time.time + ReplantRetrySeconds;
				return;
			}
			if (!nearest.IsOwner())
			{
				nearest.m_nview.ClaimOwnership();
				return;
			}
			nearest.GetInventory().RemoveItem(sharedName, conversion.SeedAmount);
			nearest.Save();
			StartGrowing(last);
			PlayEffect(EffectAdd);
		}

		private List<Container> GetNearbyContainers(bool includeTroughs)
		{
			float range = MainConfig.SeedBedChestRange.Value;
			long creator = m_piece != null ? m_piece.GetCreator() : 0L;
			List<Container> chests = new List<Container>();
			foreach (Container container in UtilityMethods.RegisteredContainers)
			{
				if (container != null
					&& container.m_nview != null
					&& container.m_nview.IsValid()
					&& !UtilityMethods.IsInUse(container)
					&& (container.transform.position - transform.position).sqrMagnitude <= range * range
					&& container.GetInventory() != null
					&& (includeTroughs || !UtilityMethods.IsTrough(container))
					&& container.GetComponent<TombStone>() == null
					&& container.CheckAccess(creator))
				{
					chests.Add(container);
				}
			}
			chests.Sort((a, b) =>
			{
				bool troughA = UtilityMethods.IsTrough(a);
				if (troughA != UtilityMethods.IsTrough(b))
				{
					return troughA ? -1 : 1;
				}
				return (a.transform.position - transform.position).sqrMagnitude.CompareTo((b.transform.position - transform.position).sqrMagnitude);
			});
			return chests;
		}

		private void ClearContent()
		{
			ZDO zdo = m_nview.GetZDO();
			zdo.Set(s_content, "");
			zdo.Set(s_startTime, 0L);
		}

		private Vector3 GetSpawnPosition()
		{
			Vector3 origin = m_spawnPoint != null ? m_spawnPoint.position : transform.position;
			return origin + Vector3.up * 0.3f;
		}

		private void OnDestroyed()
		{
			if (!IsValid || !m_nview.IsOwner())
			{
				return;
			}
			DropPendingProduce();
			Conversion conversion = FindConversion(GetContent());
			if (conversion == null)
			{
				return;
			}
			bool ready = GetStatus() == Status.Ready;
			ItemDrop item = ready ? conversion.To : conversion.From;
			int amount = ready ? conversion.ProducedItems : conversion.SeedAmount;
			for (int i = 0; i < amount; i++)
			{
				Vector3 position = transform.position + Vector3.up + UnityEngine.Random.insideUnitSphere * 0.3f;
				Quaternion rotation = Quaternion.Euler(0f, UnityEngine.Random.Range(0, 360), 0f);
				ItemDrop.OnCreateNew(Instantiate(item.gameObject, position, rotation));
			}
			ClearContent();
		}

		private void SyncVisuals()
		{
			if (!IsValid)
			{
				return;
			}
			string content = GetContent();
			if (content != m_visualContent || m_visualVersion != SeedBedConversions.Version)
			{
				m_visualContent = content;
				m_visualVersion = SeedBedConversions.Version;
				ClearVisuals();
				if (!string.IsNullOrEmpty(content))
				{
					BuildVisuals(content);
				}
			}

			Status status = string.IsNullOrEmpty(content) ? Status.Empty : GetStatus();
			SetActive(m_sapling, status == Status.Germinating);
			SetActive(m_grown, status == Status.Ready);
		}

		private static void SetActive(Transform target, bool active)
		{
			if (target != null && target.gameObject.activeSelf != active)
			{
				target.gameObject.SetActive(active);
			}
		}

		private void ClearVisuals()
		{
			foreach (GameObject visual in m_visuals)
			{
				if (visual != null)
				{
					Destroy(visual);
				}
			}
			m_visuals.Clear();

			foreach (Material tinted in m_tintedMaterials.Values)
			{
				Destroy(tinted);
			}
			m_tintedMaterials.Clear();
		}

		private void OnDestroy()
		{
			ClearVisuals();
		}

		private void BuildVisuals(string prefabName)
		{
			Conversion conversion = FindConversion(prefabName);
			GameObject plant = conversion != null ? FindPlant(conversion.To.m_itemData.m_shared.m_name) ?? FindPlant(conversion.From.m_itemData.m_shared.m_name) : null;
			if (plant == null)
			{
				return;
			}

			switch (GetLayout(plant.name))
			{
				case Layout.Grid5x5:
					Place(m_sapling5x5, plant, sapling: true, 1f, resetPosition: true);
					Place(m_grown5x5, plant, sapling: false, 1f, resetPosition: true);
					SetDeco(false);
					break;
				case Layout.Grid3x1:
					Place(m_sapling3x1, plant, sapling: true, 1f, resetPosition: true);
					Place(m_grown3x1, plant, sapling: false, 1f, resetPosition: true);
					SetDeco(false);
					break;
				case Layout.Vine:
					Place(m_saplingVine, plant, sapling: true, 0.4f, resetPosition: false);
					Place(m_grownVine, plant, sapling: false, 1f, resetPosition: false);
					SetDeco(true);
					break;
			}
		}

		private void SetDeco(bool active)
		{
			if (m_saplingDeco != null)
			{
				m_saplingDeco.gameObject.SetActive(active);
			}
			if (m_grownDeco != null)
			{
				m_grownDeco.gameObject.SetActive(active);
			}
		}

		private void Place(Transform container, GameObject plant, bool sapling, float scale, bool resetPosition)
		{
			if (container == null)
			{
				return;
			}
			foreach (Transform slot in container)
			{
				foreach (Transform part in plant.transform)
				{
					GameObject visual = Instantiate(part.gameObject, slot);
					if (resetPosition)
					{
						visual.transform.localPosition = Vector3.zero;
					}
					if (scale != 1f)
					{
						visual.transform.localScale = Vector3.one * scale;
					}
					if (sapling)
					{
						MakeSapling(visual);
					}
					m_visuals.Add(visual);
				}
			}
		}

		private void MakeSapling(GameObject visual)
		{
			foreach (LightLod lightLod in visual.GetComponentsInChildren<LightLod>(true))
			{
				Destroy(lightLod);
			}
			foreach (LightFlicker flicker in visual.GetComponentsInChildren<LightFlicker>(true))
			{
				Destroy(flicker);
			}
			foreach (Light light in visual.GetComponentsInChildren<Light>(true))
			{
				Destroy(light);
			}
			foreach (ParticleSystem particles in visual.GetComponentsInChildren<ParticleSystem>(true))
			{
				Destroy(particles);
			}
			foreach (Renderer renderer in visual.GetComponentsInChildren<Renderer>(true))
			{
				Material[] materials = renderer.sharedMaterials;
				if (materials.Length == 0 || materials[0] == null || !materials[0].HasProperty("_Color"))
				{
					continue;
				}
				if (!m_tintedMaterials.TryGetValue(materials[0], out Material tinted))
				{
					tinted = new Material(materials[0]);
					tinted.SetColor("_Color", SaplingColor);
					m_tintedMaterials.Add(materials[0], tinted);
				}
				materials[0] = tinted;
				renderer.sharedMaterials = materials;
			}
		}

		private static Layout GetLayout(string plantName)
		{
			string name = plantName.ToLower();
			if (name.Contains("pickable_"))
			{
				return Layout.Grid5x5;
			}
			if (name.Contains("cloudberrybush"))
			{
				return Layout.Grid5x5;
			}
			if (name.Contains("bush") || name.EndsWith("plant"))
			{
				return Layout.Grid3x1;
			}
			if (name.Contains("vineash"))
			{
				return Layout.Vine;
			}
			return Layout.Grid5x5;
		}

		private static Dictionary<string, GameObject> s_plants;

		private static ZNetScene s_plantsScene;

		private static GameObject FindPlant(string sharedName)
		{
			ZNetScene scene = ZNetScene.instance;
			if (scene == null)
			{
				return null;
			}
			if (s_plants == null || s_plantsScene != scene)
			{
				s_plants = BuildPlantLookup(scene);
				s_plantsScene = scene;
			}
			s_plants.TryGetValue(sharedName, out GameObject plant);
			return plant;
		}

		private static Dictionary<string, GameObject> BuildPlantLookup(ZNetScene scene)
		{
			Dictionary<string, GameObject> plants = new Dictionary<string, GameObject>();
			foreach (GameObject prefab in scene.m_prefabs)
			{
				Pickable pickable = prefab != null ? prefab.GetComponent<Pickable>() : null;
				if (pickable == null || pickable.m_itemPrefab == null)
				{
					continue;
				}
				string name = prefab.name.ToLower();
				if (name.EndsWith("_wild") || name.Contains("_wild_") || name.Contains("dvergerthing"))
				{
					continue;
				}
				ItemDrop drop = pickable.m_itemPrefab.GetComponent<ItemDrop>();
				if (drop == null)
				{
					continue;
				}
				string key = drop.m_itemData.m_shared.m_name;
				if (!plants.ContainsKey(key))
				{
					plants.Add(key, prefab);
				}
			}
			return plants;
		}
	}
}
