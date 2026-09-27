using Jotunn.Managers;

namespace CoreWoodExtras.Updates;

internal class UpdateLightSettings
{
	public static void LightSettingsChanged()
	{
		LightPatches.ApplyAll(PrefabManager.Instance.GetPrefab);
		LightPatches.ApplyToLiveInstances();
	}
}
