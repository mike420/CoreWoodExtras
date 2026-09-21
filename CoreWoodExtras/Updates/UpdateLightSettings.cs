using Jotunn.Managers;

namespace CoreWoodExtras.Updates;

internal class UpdateLightSettings
{
	public static void LightSettingsChanged()
	{
		// Prefabs cover lights placed from now on, live instances cover lights already in the world.
		LightPatches.ApplyAll(PrefabManager.Instance.GetPrefab);
		LightPatches.ApplyToLiveInstances();
	}
}
