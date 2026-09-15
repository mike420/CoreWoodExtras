using TMPro;
using UnityEngine;

namespace CoreWoodExtras;

public class NamedChest : MonoBehaviour
{
	public Sign sign;

	public TextMeshProUGUI textFront;

	private string _lastText;

	private void Update()
	{
		if ((bool)sign && (bool)sign.m_textWidget)
		{
			string text = sign.GetText();
			if (!(text == _lastText))
			{
				_lastText = text;
				UpdateDisplay(text);
			}
		}
	}

	private void UpdateDisplay(string text)
	{
		if (text != null)
		{
			GameObject gameObject = ObjectDB.instance?.GetItemPrefab(text);
			if (gameObject != null)
			{
				ItemDrop component = gameObject.GetComponent<ItemDrop>();
				if (component != null)
				{
					textFront.text = null;
					textFront.text = Localization.instance.Localize(component.m_itemData.m_shared.m_name);
					return;
				}
			}
		}
		textFront.text = text;
	}
}
