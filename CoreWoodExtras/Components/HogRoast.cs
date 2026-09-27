using System;
using UnityEngine;

namespace CoreWoodExtras
{
	internal class HogRoast : MonoBehaviour, Hoverable, Interactable
	{
		private enum Status
		{
			Empty,
			Cooking,
			Ready
		}

		private const string RpcAdd = "RPC_MM_HogRoast_Add";

		private const string RpcCollect = "RPC_MM_HogRoast_Collect";

		private const string RpcGive = "RPC_MM_HogRoast_Give";

		private const string RpcEffect = "RPC_MM_HogRoast_Effect";

		private const int EffectAdd = 0;

		private const int EffectDone = 1;

		private const string FallbackName = "$piece_mm_corewood_hog_roast";

		private const string RawItem = "RawMeat";

		private const string CookedItem = "CookedMeat";

		private const int Amount = 5;

		private static readonly int s_status = "mm_hogroast_status".GetStableHashCode();

		private static readonly int s_progress = "mm_hogroast_progress".GetStableHashCode();

		private static readonly int s_lastTime = "mm_hogroast_time".GetStableHashCode();

		private static readonly int s_putOut = "mm_hogroast_putout".GetStableHashCode();

		public float m_hoverOffset = 0f;

		public EffectList m_addEffects = new EffectList();

		public EffectList m_doneEffects = new EffectList();

		public float m_spinSpeed = 30f;

		private ZNetView m_nview;

		private Piece m_piece;

		private Transform m_pig;

		private Transform m_handle;

		private bool m_spinning;

		private Quaternion m_pigStartRotation;

		private Quaternion m_handleStartRotation;

		private float m_shownProgress;

		private Transform m_fireCheckPoint;

		private bool IsValid => m_nview != null && m_nview.IsValid();

		private string DisplayName => m_piece != null ? m_piece.m_name : FallbackName;

		private void Awake()
		{
			m_nview = GetComponent<ZNetView>();
			m_piece = GetComponent<Piece>();
			m_pig = Utils.FindChild(transform, "Enabled");
			m_handle = Utils.FindChild(transform, "Rotate");
			m_pigStartRotation = m_pig != null ? m_pig.localRotation : Quaternion.identity;
			m_handleStartRotation = m_handle != null ? m_handle.localRotation : Quaternion.identity;
			m_fireCheckPoint = Utils.FindChild(transform, "FireCheckPoint");

			if (m_pig == null)
			{
				Jotunn.Logger.LogWarning($"[CoreWoodExtras] HogRoast on '{gameObject.name}' is missing its 'Enabled' child, the bore will not be shown.");
			}

			if (!IsValid)
			{
				return;
			}

			m_nview.Register<int>(RpcAdd, RPC_Add);
			m_nview.Register(RpcCollect, RPC_Collect);
			m_nview.Register<string, int>(RpcGive, RPC_Give);
			m_nview.Register<int>(RpcEffect, RPC_Effect);

			WearNTear wearNTear = GetComponent<WearNTear>();
			if (wearNTear != null)
			{
				wearNTear.m_onDestroyed += OnDestroyed;
			}

			SyncVisuals();
			InvokeRepeating(nameof(SyncVisuals), 0.5f, 0.5f);
			InvokeRepeating(nameof(UpdateCooking), 1f, 1f);
		}

		private Status GetStatus()
		{
			return (Status)m_nview.GetZDO().GetInt(s_status);
		}

		private void SetStatus(Status status)
		{
			m_nview.GetZDO().Set(s_status, (int)status);
		}

		private float GetProgress()
		{
			return m_nview.GetZDO().GetFloat(s_progress);
		}

		private bool HasFire()
		{
			Vector3 point = m_fireCheckPoint != null ? m_fireCheckPoint.position : transform.position;
			return EffectArea.IsPointInsideArea(point, EffectArea.Type.Burning, 0.25f) != null;
		}

		private const float FireSearchRadius = 0.5f;

		private const int FireOn = 1;

		private const int FireOff = 2;

		private static readonly Collider[] s_fireColliders = new Collider[32];

		private Fireplace FindFire()
		{
			Vector3 point = m_fireCheckPoint != null ? m_fireCheckPoint.position : transform.position;
			int count = Physics.OverlapSphereNonAlloc(point, FireSearchRadius, s_fireColliders, ~0, QueryTriggerInteraction.Collide);
			Fireplace nearest = null;
			float nearestDistance = float.MaxValue;
			for (int i = 0; i < count; i++)
			{
				Fireplace fire = s_fireColliders[i].GetComponentInParent<Fireplace>();
				if (fire == null || fire.m_nview == null || !fire.m_nview.IsValid())
				{
					continue;
				}
				float distance = Vector3.Distance(point, fire.transform.position);
				if (distance < nearestDistance)
				{
					nearest = fire;
					nearestDistance = distance;
				}
			}
			return nearest;
		}

		private static int GetFireState(Fireplace fire)
		{
			return fire.m_nview.GetZDO().GetInt(ZDOVars.s_state, FireOn);
		}

		private static bool HasFuel(Fireplace fire)
		{
			return fire.m_infiniteFuel || fire.m_nview.GetZDO().GetFloat(ZDOVars.s_fuel) > 0f;
		}

		private bool CanRelight(out Fireplace fire)
		{
			fire = FindFire();
			return fire != null && GetFireState(fire) == FireOff && HasFuel(fire);
		}

		private bool HasOrCanLightFire()
		{
			return HasFire() || CanRelight(out _);
		}

		private static void SetFireLit(Fireplace fire, bool lit)
		{
			if (fire != null && GetFireState(fire) == (lit ? FireOff : FireOn))
			{
				fire.m_nview.InvokeRPC("RPC_ToggleOn");
			}
		}

		private void PutOutFire()
		{
			Fireplace fire = FindFire();
			if (fire != null && GetFireState(fire) == FireOn)
			{
				SetFireLit(fire, false);
				m_nview.GetZDO().Set(s_putOut, true);
			}
		}

		private void RPC_Effect(long sender, int effect)
		{
			EffectList effects = effect == EffectDone ? m_doneEffects : m_addEffects;
			effects?.Create(transform.position, transform.rotation);
		}

		private void PlayEffect(int effect)
		{
			m_nview.InvokeRPC(ZNetView.Everybody, RpcEffect, effect);
		}

		private static ItemDrop GetItemDrop(string prefabName)
		{
			GameObject prefab = ObjectDB.instance != null ? ObjectDB.instance.GetItemPrefab(prefabName) : null;
			return prefab != null ? prefab.GetComponent<ItemDrop>() : null;
		}

		private void SyncVisuals()
		{
			if (!IsValid || m_pig == null)
			{
				return;
			}
			bool show = GetStatus() != Status.Empty;
			if (m_pig.gameObject.activeSelf != show)
			{
				m_pig.gameObject.SetActive(show);
			}
			m_spinning = GetStatus() == Status.Cooking && HasFire();
		}

		private void Update()
		{
			if (!IsValid || m_pig == null)
			{
				return;
			}
			float duration = MainConfig.HogRoastCookDuration.Value;
			float progress = GetStatus() == Status.Cooking ? GetProgress() : 0f;
			if (m_spinning)
			{
				m_shownProgress += Time.deltaTime;
			}
			if (Mathf.Abs(m_shownProgress - progress) > 1.5f)
			{
				m_shownProgress = progress;
			}
			m_shownProgress = Mathf.Clamp(m_shownProgress, 0f, duration);
			int turns = Mathf.Max(1, Mathf.RoundToInt(duration * m_spinSpeed / 360f));
			float angle = m_shownProgress / duration * turns * 360f;
			Quaternion spin = Quaternion.Euler(0f, 0f, angle);
			m_pig.localRotation = m_pigStartRotation * spin;
			if (m_handle != null)
			{
				m_handle.localRotation = m_handleStartRotation * spin;
			}
		}

		private void UpdateCooking()
		{
			if (!IsValid || !m_nview.IsOwner() || GetStatus() != Status.Cooking)
			{
				return;
			}
			ZDO zdo = m_nview.GetZDO();
			DateTime now = ZNet.instance.GetTime();
			long lastTicks = zdo.GetLong(s_lastTime, now.Ticks);
			float delta = Mathf.Max(0f, (float)(now - new DateTime(lastTicks)).TotalSeconds);
			zdo.Set(s_lastTime, now.Ticks);
			if (!HasFire())
			{
				return;
			}
			float progress = GetProgress() + delta;
			zdo.Set(s_progress, progress);
			if (progress >= MainConfig.HogRoastCookDuration.Value)
			{
				SetStatus(Status.Ready);
				PlayEffect(EffectDone);
				PutOutFire();
			}
		}

		private void StartCooking()
		{
			ZDO zdo = m_nview.GetZDO();
			SetStatus(Status.Cooking);
			zdo.Set(s_progress, 0f);
			zdo.Set(s_lastTime, ZNet.instance.GetTime().Ticks);
		}

		private void ClearState()
		{
			SetStatus(Status.Empty);
			m_nview.GetZDO().Set(s_progress, 0f);
		}

		private void SpawnItem(string prefabName, int amount)
		{
			ItemDrop item = GetItemDrop(prefabName);
			if (item == null || amount <= 0)
			{
				return;
			}
			GameObject drop = Instantiate(item.gameObject, GetSpawnPosition(), Quaternion.identity);
			ItemDrop.OnCreateNew(drop);
			drop.GetComponent<ItemDrop>().SetStack(amount);
		}

		private Vector3 GetSpawnPosition()
		{
			Vector3 origin = m_pig != null ? m_pig.position : transform.position;
			return origin + Vector3.up * 0.3f;
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
					return Localization.instance.Localize(DisplayName + " ( $text_hogroast_ready_mm )\n[<color=yellow><b>$KEY_Use</b></color>] $text_hogroast_collect_mm");
				case Status.Cooking:
					if (!HasFire())
					{
						return Localization.instance.Localize(DisplayName + " <color=#888888><b>" + GetTimeLeft() + "</b></color>\n( $text_hogroast_paused_mm, $text_hogroast_no_fire_mm )");
					}
					return Localization.instance.Localize(DisplayName + " <color=orange><b>" + GetTimeLeft() + "</b></color>\n( $text_hogroast_cooking_mm )");
				default:
					if (!HasOrCanLightFire())
					{
						return Localization.instance.Localize(DisplayName + " ( $text_hogroast_empty_mm )\n$text_hogroast_no_fire_mm");
					}
					return Localization.instance.Localize(DisplayName + " ( $text_hogroast_empty_mm )\n[<color=yellow><b>$KEY_Use</b></color>] $text_hogroast_add_mm");
			}
		}

		private string GetTimeLeft()
		{
			int seconds = Mathf.Max(0, Mathf.CeilToInt(MainConfig.HogRoastCookDuration.Value - GetProgress()));
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
				case Status.Ready:
					m_nview.InvokeRPC(RpcCollect);
					return true;
				case Status.Empty:
					return AddMeat(user);
				default:
					return false;
			}
		}

		public bool UseItem(Humanoid user, ItemDrop.ItemData item)
		{
			if (!IsValid || item == null || item.m_dropPrefab == null || item.m_dropPrefab.name != RawItem || !PrivateArea.CheckAccess(transform.position))
			{
				return false;
			}
			return AddMeat(user);
		}

		public float GetHoverOffset()
		{
			return m_hoverOffset;
		}

		private bool AddMeat(Humanoid user)
		{
			if (GetStatus() != Status.Empty)
			{
				return false;
			}
			if (!HasOrCanLightFire())
			{
				user.Message(MessageHud.MessageType.Center, "$text_hogroast_no_fire_mm");
				return false;
			}
			ItemDrop raw = GetItemDrop(RawItem);
			if (raw == null)
			{
				return false;
			}
			Inventory inventory = user.GetInventory();
			string sharedName = raw.m_itemData.m_shared.m_name;
			if (inventory.CountItems(sharedName) < Amount)
			{
				user.Message(MessageHud.MessageType.Center, "$text_hogroast_no_meat_mm");
				return false;
			}
			inventory.RemoveItem(sharedName, Amount);
			m_nview.InvokeRPC(RpcAdd, Amount);
			return true;
		}

		private void RPC_Add(long sender, int amount)
		{
			if (!m_nview.IsOwner())
			{
				return;
			}
			if (GetStatus() != Status.Empty)
			{
				m_nview.InvokeRPC(sender, RpcGive, RawItem, amount);
				return;
			}
			StartCooking();
			SyncVisuals();
			SetFireLit(FindFire(), true);
			m_nview.GetZDO().Set(s_putOut, false);
			PlayEffect(EffectAdd);
		}

		private void RPC_Collect(long sender)
		{
			if (!m_nview.IsOwner() || GetStatus() != Status.Ready)
			{
				return;
			}
			ClearState();
			SyncVisuals();
			m_nview.InvokeRPC(sender, RpcGive, CookedItem, Amount);
		}

		private void RPC_Give(long sender, string prefabName, int amount)
		{
			ItemDrop item = GetItemDrop(prefabName);
			Player player = Player.m_localPlayer;
			if (item == null || amount <= 0)
			{
				return;
			}
			if (player != null)
			{
				ItemDrop.ItemData data = item.m_itemData.Clone();
				data.m_dropPrefab = item.gameObject;
				data.m_stack = amount;
				Inventory inventory = player.GetInventory();
				if (inventory.CanAddItem(data) && inventory.AddItem(data))
				{
					player.ShowPickupMessage(data, amount);
					return;
				}
			}
			SpawnItem(prefabName, amount);
		}

		private void OnDestroyed()
		{
			if (!IsValid || !m_nview.IsOwner())
			{
				return;
			}
			switch (GetStatus())
			{
				case Status.Ready:
					SpawnItem(CookedItem, Amount);
					break;
				case Status.Cooking:
					SpawnItem(RawItem, Amount);
					break;
			}
			Fireplace fire = FindFire();
			if (fire != null && (!fire.m_canTurnOff || m_nview.GetZDO().GetBool(s_putOut)))
			{
				SetFireLit(fire, true);
			}
		}
	}
}
