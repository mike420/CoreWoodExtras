using Jotunn.Managers;
using UnityEngine;

namespace CoreWoodExtras.Updates;

internal class UpdateMainSettings
{
	public static void MainSettingsChanged()
	{
		GameObject prefab = PrefabManager.Instance.GetPrefab("mm_corewood_outhouse");
		Transform transform = Utils.FindChild(prefab.transform, "Effects");
		if (MainConfig.disableHDTextures.Value)
		{
			TexturePatches.ChangeTextureFilter();
		}
		if (MainConfig.toiletEffects.Value && prefab != null)
		{
			transform.gameObject.SetActive(value: true);
		}
		else
		{
			transform.gameObject.SetActive(value: false);
		}
	}
}
