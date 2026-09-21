namespace CoreWoodExtras.Updates;

internal class UpdateScarecrowSettings
{
	public static void ScarecrowSettingsChanged()
	{
		Scarecrow.ApplySettingsToAll();
	}
}
