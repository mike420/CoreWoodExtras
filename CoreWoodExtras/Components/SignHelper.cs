using Jotunn.Managers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CoreWoodExtras;

public static class SignHelper
{
	public static GameObject CreateSignCanvas(string name, Transform parent, Vector3 pos, Quaternion rot, Vector2 size)
	{
		GameObject gameObject = new GameObject(name, typeof(RectTransform));
		gameObject.transform.SetParent(parent);
		gameObject.transform.localPosition = pos;
		gameObject.transform.localRotation = rot;
		gameObject.transform.localScale = Vector3.one;
		gameObject.GetComponent<RectTransform>().sizeDelta = size;
		Canvas canvas = gameObject.AddComponent<Canvas>();
		canvas.renderMode = RenderMode.WorldSpace;
		canvas.scaleFactor = 10f;
		gameObject.AddComponent<CanvasRenderer>();
		gameObject.AddComponent<GraphicRaycaster>();
		return gameObject;
	}

	public static TextMeshProUGUI CreateText(Transform parent, string name)
	{
		GameObject gameObject = new GameObject(name, typeof(RectTransform));
		gameObject.transform.SetParent(parent);
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localScale = Vector3.one;
		RectTransform component = gameObject.GetComponent<RectTransform>();
		component.anchorMin = Vector2.zero;
		component.anchorMax = Vector2.one;
		component.offsetMin = Vector2.zero;
		component.offsetMax = Vector2.zero;
		TextMeshProUGUI textMeshProUGUI = gameObject.AddComponent<TextMeshProUGUI>();
		textMeshProUGUI.text = "";
		textMeshProUGUI.fontSize = 1f;
		textMeshProUGUI.alignment = TextAlignmentOptions.Center;
		textMeshProUGUI.textWrappingMode = TextWrappingModes.Normal;
		textMeshProUGUI.color = new Color32(20, 20, 20, byte.MaxValue);
		GameObject prefab = PrefabManager.Instance.GetPrefab("sign");
		if (prefab != null)
		{
			TextMeshProUGUI componentInChildren = prefab.GetComponentInChildren<TextMeshProUGUI>(includeInactive: true);
			if (componentInChildren != null)
			{
				textMeshProUGUI.font = componentInChildren.font;
				textMeshProUGUI.fontMaterial = new Material(componentInChildren.fontMaterial);
				textMeshProUGUI.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, 0.3f);
			}
		}
		textMeshProUGUI.outlineColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		textMeshProUGUI.outlineWidth = 0.02f;
		return textMeshProUGUI;
	}
}
