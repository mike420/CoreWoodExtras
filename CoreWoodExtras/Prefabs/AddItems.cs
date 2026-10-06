using static CoreWoodExtras.PieceBuilder;

namespace CoreWoodExtras;

internal class AddItems
{
	public static void LoadItems()
	{
		AddItem("mm_corewood_planter_small", "mm_corewood_greenhouse_workbench", Req("RoundLog", 1));
		AddItem("mm_corewood_planter_large", "mm_corewood_greenhouse_workbench", Req("RoundLog", 2));
		AddItem("mm_vase_01", "mm_corewood_greenhouse_workbench", Req("Stone", 1));
		AddItem("mm_vase_02", "mm_corewood_greenhouse_workbench", Req("Stone", 1));
		AddItem("mm_vase_03", "mm_corewood_greenhouse_workbench", Req("Stone", 1));
	}
}
