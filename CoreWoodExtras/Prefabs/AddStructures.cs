using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;
using static CoreWoodExtras.PieceAssets;
using static CoreWoodExtras.PieceBuilder;

namespace CoreWoodExtras;

internal class AddStructures
{

    public static void LoadPieces()
	{
        PieceAssets.Init();
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBar);

        Add("mm_corewood_palisade_tower", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 20), Req("Wood", 4)));
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeBeacon);
        Add("mm_corewood_palisade_entrance", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 30), Req("Wood", 8)));
        Add("mm_corewood_palisade_wall", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 40), Req("Wood", 8)));
        Add("mm_corewood_palisade_corner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 30), Req("Wood", 8)));
        CoreWoodPlugin.TryAddPiece(AddCoreWoodPalisadeGates);

        Add("mm_corewood_bridge_part", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 10)));
        Add("mm_corewood_bridge_part_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 8)));
        Add("mm_corewood_bridge_tjunction", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 25)));
        Add("mm_corewood_bridge_cross_junction", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 32)));
        Add("mm_corewood_bridge_foundation", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 8)));
        Add("mm_corewood_bridge_foundation_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 4)));
        Add("mm_corewood_bridge_ramp", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 6)));
        CoreWoodPlugin.TryAddPiece(AddCoreWoodBridgeDrawbridge);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodTowerDrawbridge);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodDrawbridge);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodDrawbridge2);

        CoreWoodPlugin.TryAddPiece(AddCoreWoodLiftGate);

        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevatorSmall);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevatorSmall9);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevatorLarge);
        CoreWoodPlugin.TryAddPiece(AddCoreWoodElevatorLarge9);
        Add("mm_corewood_elevator_01", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 4), Req("Wood", 2)));
        Add("mm_corewood_elevator_02", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 8), Req("Wood", 4)));
        Add("mm_corewood_elevator_03", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 12), Req("Wood", 6)));
        Add("mm_corewood_elevator_04", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 16), Req("Wood", 8)));

        Add("mm_corewood_gazebo", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 15), Req("Wood", 15)));
        Add("mm_corewood_pergola", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 12), Req("Wood", 12)));


        CoreWoodPlugin.TryAddPiece(AddCoreWoodOuthouse);
        Add("mm_corewood_shower", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 12), Req("Wood", 10), Req("Iron", 4)));
        Add("mm_corewood_well", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 10), Req("Wood", 10)));
        Add("mm_corewood_pool", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 80), Req("Stone", 40), Req("Wood", 40)));
        Add("mm_corewood_large_aquarium", PieceSfx.Wood, Config("piece_stonecutter", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 12), Req("Crystal", 8)));


        CoreWoodPlugin.TryAddPiece(AddFishPond);
        Add("mm_corewood_log_arch", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 6)));
        Add("mm_corewood_log_arch_ivy", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 6)));
        Add("mm_corewood_arch_corner", PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 14)));
    }

	public static void AddCoreWoodBar()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_bar");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 10), Req("Wood", 10), Req("Bronze", 2), Req("Coins", 1000, recover: false)));
		Transform burt = Utils.FindChild(gameObject.transform, "Burt");
		if (burt != null)
		{
			gameObject.AddComponent<TraderToggle>().m_trader = burt.gameObject;
		}
		PieceManager.Instance.AddPiece(customPiece);
    }


    public static void AddCoreWoodPalisadeBeacon()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_palisade_beacon");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 4), Req("Wood", 2), Req("Iron", 2), Req("Coal", 5)));
        Fireplace component2 = gameObject.GetComponent<Fireplace>();
        component2.m_fuelItem = fuelCoal;
        component2.m_fuelAddedEffects = addFuel;
        PieceManager.Instance.AddPiece(customPiece);
    }




    public static void AddCoreWoodPalisadeGates()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_palisadefence_gates");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 10), Req("Wood", 6)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = doorOpen;
        component2.m_closeEffects = doorClose;
        PieceManager.Instance.AddPiece(customPiece);
    }








    public static void AddCoreWoodBridgeDrawbridge()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_bridge_drawbridge");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 12), Req("Wood", 5)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = bridgeOC;
        component2.m_closeEffects = bridgeOC;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodTowerDrawbridge()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_tower_drawbridge");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 40), Req("Iron", 10)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = towerOC;
        component2.m_closeEffects = towerOC;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodDrawbridge()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_drawbridge");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 8), Req("Wood", 20), Req("Iron", 6)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = bridgeOC;
        component2.m_closeEffects = bridgeOC;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodDrawbridge2()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_drawbridge2");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 8), Req("Wood", 20), Req("Iron", 6)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = bridgeOC;
        component2.m_closeEffects = bridgeOC;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodLiftGate()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_liftgate");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building, PieceUsages.Defense }, Req("RoundLog", 10), Req("Wood", 20), Req("Bronze", 8)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = gateOpen;
        component2.m_closeEffects = gateClose;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevatorSmall()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_elevator_small");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 4), Req("Wood", 5), Req("Iron", 4)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = elevator;
        component2.m_closeEffects = elevator;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevatorSmall9()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_elevator_small_9m");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 4), Req("Wood", 5), Req("Iron", 8)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = elevatorLong;
        component2.m_closeEffects = elevatorLong;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevatorLarge()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_elevator_large");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 8), Req("Wood", 10), Req("Iron", 4)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = elevator;
        component2.m_closeEffects = elevator;
        PieceManager.Instance.AddPiece(customPiece);
    }

    public static void AddCoreWoodElevatorLarge9()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_elevator_large_9m");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("forge", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 8), Req("Wood", 10), Req("Iron", 8)));
        Door component2 = gameObject.GetComponent<Door>();
        component2.m_openEffects = elevatorLong;
        component2.m_closeEffects = elevatorLong;
        PieceManager.Instance.AddPiece(customPiece);
    }










    public static void AddFishPond()
    {
        GameObject gameObject = LoadPrefab("mm_corewood_pond");
        CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 12), Req("Stone", 10)));
        Utils.FindChild(gameObject.transform, "sfx_frog_croaking").gameObject.GetComponent<AudioSource>().outputAudioMixerGroup = AudioMan.instance.m_ambientMixer;
        PieceManager.Instance.AddPiece(customPiece);
    }



    public static void AddCoreWoodOuthouse()
	{
		GameObject gameObject = LoadPrefab("mm_corewood_outhouse");
		CustomPiece customPiece = CreatePiece(gameObject, PieceSfx.Wood, Config("piece_workbench", "CoreWood-Structure", new[] { PieceUsages.Building }, Req("RoundLog", 6), Req("Wood", 4), Req("Iron", 1)));
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


}
