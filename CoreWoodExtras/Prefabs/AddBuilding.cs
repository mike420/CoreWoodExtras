using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;
using static CoreWoodExtras.PieceBuilder;

namespace CoreWoodExtras;

internal class AddBuilding
{
	public static void LoadPieces()
	{
		PieceAssets.Init();
		Add("mm_corewood_stake_wall", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 6)));
		Add("mm_corewood_stakes_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 2)));
		Add("mm_corewood_stakes_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 2)));
		Add("mm_corewood_stakes_03", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 4)));
		Add("mm_corewood_refined_sharpstakes", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 2)));
		Add("mm_corewood_palisadefence", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 6)));
		Add("mm_corewood_palisadefenceTall", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 6)));
		Add("mm_corewood_decking_2x2", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Floor }, Req("RoundLog", 2)));
		Add("mm_corewood_decking_4x4", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Floor }, Req("RoundLog", 4)));
		Add("mm_corewood_floor_half", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Floor }, Req("RoundLog", 1)));
		Add("mm_corewood_floor", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Floor }, Req("RoundLog", 2)));
		Add("mm_corewood_floor_4m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Floor }, Req("RoundLog", 4)));
		Add("mm_corewood_planks", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Floor }, Req("RoundLog", 1), Req("Wood", 1)));
		Add("mm_corewood_planks_4x4", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Floor }, Req("RoundLog", 2), Req("Wood", 2)));
		Add("mm_corewood_paving_straight", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1), Req("Stone", 5)));
		Add("mm_corewood_paving_cross", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 4), Req("Stone", 10)));
		Add("mm_corewood_paving_corner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("Stone", 8)));
		Add("mm_corewood_paving_curve", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("Stone", 8)));
		Add("mm_corewood_cross26", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_cross45", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wallroof26", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 1)));
		Add("mm_corewood_wallroof45", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 1)));
		Add("mm_corewood_wallroof_upsidedown26", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 1)));
		Add("mm_corewood_wallroof_upsidedown45", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 1)));
		Add("mm_corewood_roof26", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 2)));
		Add("mm_corewood_roof45", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 2)));
		Add("mm_corewood_roofICorner26", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 2)));
		Add("mm_corewood_roofICorner45", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 2)));
		Add("mm_corewood_roofOCorner26", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 2)));
		Add("mm_corewood_roofOCorner45", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 2)));
		Add("mm_corewood_roofTop26", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 2)));
		Add("mm_corewood_roofTop45", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 2)));
		Add("mm_corewood_quarterwall", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Wall }, Req("RoundLog", 1)));
		Add("mm_corewood_halfwall", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Roof }, Req("RoundLog", 1)));
		Add("mm_corewood_wall_v", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Wall }, Req("RoundLog", 2)));
		Add("mm_corewood_wall_4m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Wall }, Req("RoundLog", 4)));
		CoreWoodPlugin.TryAddPiece(AddCoreWoodGateLeft);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodGateRight);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodGateSmallLeft);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodGateSmallRight);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodTrapdoor);
		Add("mm_corewood_window_single", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 1), Req("Crystal", 1)));
		Add("mm_corewood_window_double", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 2), Req("Crystal", 2)));
		Add("mm_corewood_window_tall", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 2), Req("Crystal", 2)));
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowSmallAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowMediumAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodWindowLargeAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodShutterSmallAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodShutterMediumAnimated);
		CoreWoodPlugin.TryAddPiece(AddCoreWoodShutterLargeAnimated);
		Add("mm_corewood_window_large_01", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 4), Req("Crystal", 4)));
		Add("mm_corewood_window_large_02", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 4), Req("Crystal", 4)));
		Add("mm_corewood_window_large_03", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 4), Req("Crystal", 4)));
		Add("mm_corewood_window_medium_01", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 2), Req("Crystal", 2)));
		Add("mm_corewood_window_medium_02", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 2), Req("Crystal", 2)));
		Add("mm_corewood_window_medium_03", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 2), Req("Crystal", 2)));
		Add("mm_corewood_window_small_01", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 1), Req("Crystal", 1)));
		Add("mm_corewood_window_small_02", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 1), Req("Crystal", 1)));
		Add("mm_corewood_window_small_03", PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 1), Req("Crystal", 1)));
		Add("mm_corewood_wattle_fence", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1), Req("Wood", 4)));
		Add("mm_corewood_fencepost", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_fence_large", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_fence_small", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_fence_small_alt", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_fence_small_alt_gate", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_rope_fence", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("LinenThread", 1)));
		Add("mm_corewood_rope_fence_angled", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2), Req("LinenThread", 1)));
		Add("mm_corewood_stairs", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Stairs }, Req("RoundLog", 4)));
		Add("mm_corewood_stepladder", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Stairs }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_pole_log_1m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_wood_pole_log_2m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_wood_pole_log_3m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_pole_log_4m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_wall_log_1m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_wood_wall_log_2m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_wood_wall_log_3m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_wall_log_4m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_pole_log_thin_1m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_wood_pole_log_thin_2m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_wood_pole_log_thin_3m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_pole_log_thin_4m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_wall_log_thin_1m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_wood_wall_log_thin_2m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 1)));
		Add("mm_corewood_wood_wall_log_thin_3m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_wall_log_thin_4m", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_log_26", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
		Add("mm_corewood_wood_log_45", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building }, Req("RoundLog", 2)));
	}





































	public static void AddCoreWoodGateLeft()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_gate_left");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 6)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodGateRight()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_gate_right");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 6)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodGateSmallLeft()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_gate_small_left");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 4)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodGateSmallRight()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_gate_small_right");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 4)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodTrapdoor()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_trapDoor");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 4)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}




	public static void AddCoreWoodWindowSmallAnimated()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_window_animated_s");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 1), Req("Crystal", 1)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWindowMediumAnimated()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_window_animated_m");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 2), Req("Crystal", 2)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodWindowLargeAnimated()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_window_animated_l");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Glass, Config("forge", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 3), Req("Crystal", 3)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodShutterSmallAnimated()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_shutter_animated_s");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 2)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodShutterMediumAnimated()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_shutter_animated_m");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 3)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}

	public static void AddCoreWoodShutterLargeAnimated()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_shutter_animated_l");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Building", new[] { PieceUsages.Building, PieceUsages.Doors }, Req("RoundLog", 4)));
		Door component2 = gameObject.GetComponent<Door>();
		component2.m_openEffects = doorOpen;
		component2.m_closeEffects = doorClose;
		PieceManager.Instance.AddPiece(customPiece);
	}





































}
