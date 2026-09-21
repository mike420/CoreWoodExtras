using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras.Updates;

internal class UpdateMainSettings
{
	private const string ToiletPrefab = "mm_corewood_outhouse";

	public static void MainSettingsChanged()
	{
		TexturePatches.ChangeTextureFilter();
		ApplyToiletEffects();
	}

	private static void ApplyToiletEffects()
	{
		bool enabled = MainConfig.toiletEffects.Value;

		// Prefab covers toilets placed from now on, live instances cover toilets already in the world.
		SetToiletEffects(PrefabManager.Instance.GetPrefab(ToiletPrefab), enabled);
		foreach (ZNetView nview in Object.FindObjectsByType<ZNetView>(FindObjectsSortMode.None))
		{
			if (Utils.GetPrefabName(nview.gameObject) == ToiletPrefab)
			{
				SetToiletEffects(nview.gameObject, enabled);
			}
		}
	}

	private static void SetToiletEffects(GameObject toilet, bool enabled)
	{
		if (!toilet)
		{
			return;
		}
		Transform effects = Utils.FindChild(toilet.transform, "Effects");
		if (effects)
		{
			effects.gameObject.SetActive(enabled);
		}
	}
}
