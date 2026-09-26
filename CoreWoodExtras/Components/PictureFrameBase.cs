using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using BepInEx;
using CoreWoodExtras.TextureUtils;
using UnityEngine;
using UnityEngine.UI;

namespace CoreWoodExtras;

public abstract class PictureFrameBase : MonoBehaviour, Hoverable, Interactable, TextReceiver
{
	private static char pds = Path.DirectorySeparatorChar;

	private static readonly string _basePath = Paths.ConfigPath + pds + "CoreWoodExtras" + pds + "Images";

	private Renderer _frameRenderer;

	private int _characterLimit = 100;

	private float _interval = 5f;

	// Shared by every frame, so an image shown on several frames (or on a frame that is loaded again) is only read once.
	private static TextureCache textureCache;

	private Renderer _pictureRenderer;

	// The picture's own copy of its material, made the first time a texture is set.
	private Material _pictureMaterial;

	// Bumped on every SetTexture, so a web image that arrives after the frame moved on is ignored.
	private int _textureRequest;

	private ZNetView _nview;

	private string[] _textureNames = new string[0];

	private int _nextIndex;

	public Text TextWidget { get; set; }

	public abstract Vector3 PivotOffset { get; set; }

	public abstract string Name { get; set; }

    public float m_hoverOffset;

    private static Dictionary<string, string> ParseOptions(string[] args)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < args.Length; i++)
		{
			string[] array = args[i].Split(new char[1] { '=' });
			if (array.Length == 2)
			{
				dictionary[array[0]] = array[1];
			}
		}
		return dictionary;
	}

	public string GetHoverName()
	{
		return Name;
	}

	public string GetHoverText()
	{
		if (!PrivateArea.CheckAccess(base.transform.position, 0f, flash: false))
		{
			return Localization.instance.Localize(Name);
		}
		return Localization.instance.Localize(Name + "\n[<color=yellow><b>$KEY_Use</b></color>] $piece_use");
	}

	public string GetText()
	{
		return _nview.GetZDO().GetString("text");
	}

	public bool Interact(Humanoid user, bool hold, bool alt)
	{
		if (hold)
		{
			return false;
		}
		if (!PrivateArea.CheckAccess(base.transform.position))
		{
			return false;
		}
		TextInput.instance.RequestText(this, "$piece_sign_input", _characterLimit);
		return true;
	}

	public void SetText(string text)
	{
		if (PrivateArea.CheckAccess(base.transform.position))
		{
			// Saved first, so the text still reaches the other players if the picture cannot be shown.
			_nview.ClaimOwnership();
			_nview.GetZDO().Set("text", text);
			TextWidget.text = text;
			UpdatePicture();
		}
	}

	public void SetTexture(string fileName)
	{
		int request = ++_textureRequest;
		if (IsUrl(fileName))
		{
			SetPicture(null);
			// Sign text is set by other players, so each player can choose not to download images from their links.
			if (MainConfig.pictureFrameWebImages.Value)
			{
				StartCoroutine(textureCache.FetchFromWeb(fileName, delegate(Texture texture)
				{
					if (request == _textureRequest)
					{
						SetPicture(texture);
					}
				}));
			}
			return;
		}
		SetPicture(textureCache.Load(fileName));
	}

	private void SetPicture(Texture texture)
	{
		if (!_pictureRenderer)
		{
			return;
		}
		if (!_pictureMaterial)
		{
			_pictureMaterial = _pictureRenderer.material;
		}
		_pictureMaterial.mainTexture = texture;
	}

	private void OnDestroy()
	{
		// Unity does not free the renderer's material copy along with the renderer.
		if (_pictureMaterial)
		{
			Destroy(_pictureMaterial);
		}
	}

	public void StartAnimation(string[] textureNames)
	{
		_textureNames = textureNames;
		_nextIndex = 0;
		StartCoroutine("NextPicture");
	}

	public void StopAnimation()
	{
		StopCoroutine("NextPicture");
	}

	public bool UseItem(Humanoid user, ItemDrop.ItemData item)
	{
		return false;
	}

	private void Awake()
	{
		_frameRenderer = base.transform.Find("Pivot/New/PictureFrame").gameObject.GetComponent<Renderer>();
		TextWidget = base.transform.Find("Pivot/Canvas/Text").GetComponent<Text>();
		_pictureRenderer = base.transform.Find("Pivot/New/Picture").gameObject.GetComponent<Renderer>();
		textureCache ??= new TextureCache(_basePath);
		_nview = GetComponent<ZNetView>();
		if (_nview.GetZDO() != null)
		{
			UpdateText();
			InvokeRepeating("UpdateText", 2f, 2f);
		}
	}

	private IEnumerator NextPicture()
	{
		while (_textureNames != null && _textureNames.Length != 0)
		{
			_nextIndex %= _textureNames.Length;
			SetTexture(_textureNames[_nextIndex]);
			_nextIndex++;
			yield return new WaitForSeconds(_interval);
		}
	}

	private void UpdatePicture()
	{
		string[] array = TextWidget.text.Split(new char[1] { ':' });
		Transform transform = base.transform.Find("Pivot");
		base.transform.localScale = Vector3.one;
		transform.transform.localPosition = Vector3.zero;
		_frameRenderer.enabled = true;
		string text = array[0].Trim();
		if (text.StartsWith("http") && array.Length > 1)
		{
			text = array[0] + ":" + array[1];
		}
		StopAnimation();
		if (array.Length == 2 || array.Length == 3)
		{
			int num = array.Length - 1;
			Dictionary<string, string> dictionary = ParseOptions(array[num].Split(new char[1] { ' ' }));
			Vector3 vector = new Vector3(0f, 0f, 0f);
			if (dictionary.ContainsKey("pivot") || dictionary.ContainsKey("p"))
			{
				string key = (dictionary.ContainsKey("pivot") ? "pivot" : "p");
				string[] array2 = dictionary[key].Split(new char[1] { ',' });
				foreach (string text2 in array2)
				{
					if (text2 == null)
					{
						continue;
					}
					switch (text2.Length)
					{
					case 1:
					{
						char c = text2[0];
						if (c <= 'l')
						{
							if (c != 'b')
							{
								if (c != 'l')
								{
									continue;
								}
								break;
							}
							goto IL_021b;
						}
						if (c != 'r')
						{
							if (c != 't')
							{
								continue;
							}
							goto IL_01f0;
						}
						goto IL_0240;
					}
					case 3:
						if (!(text2 == "top"))
						{
							continue;
						}
						goto IL_01f0;
					case 4:
						if (!(text2 == "left"))
						{
							continue;
						}
						break;
					case 5:
						if (!(text2 == "right"))
						{
							continue;
						}
						goto IL_0240;
					case 6:
						if (!(text2 == "bottom"))
						{
							continue;
						}
						goto IL_021b;
					default:
						continue;
						IL_0240:
						vector += new Vector3(PivotOffset.x, 0f, 0f);
						continue;
						IL_01f0:
						vector += new Vector3(0f, 0f - PivotOffset.y, 0f);
						continue;
						IL_021b:
						vector += new Vector3(0f, PivotOffset.y, 0f);
						continue;
					}
					vector += new Vector3(0f - PivotOffset.x, 0f, 0f);
				}
				vector += new Vector3(0f, 0f, 0.023f);
			}
			if (dictionary.ContainsKey("scale") || dictionary.ContainsKey("s"))
			{
				string key2 = (dictionary.ContainsKey("scale") ? "scale" : "s");
				if (TryParseFloat(dictionary[key2], out float scale))
				{
					float num2 = Math.Max(Math.Min(scale, 10f), 0.1f);
					transform.transform.localPosition = vector;
					base.transform.localScale = Vector3.one * num2;
					transform.transform.localPosition -= vector / num2;
				}
			}
			if (dictionary.ContainsKey("interval") || dictionary.ContainsKey("i"))
			{
				string key3 = (dictionary.ContainsKey("interval") ? "interval" : "i");
				if (TryParseFloat(dictionary[key3], out float parsedInterval))
				{
					_interval = Math.Max(parsedInterval, 0.01f);
				}
			}
			if (dictionary.ContainsKey("frame") || dictionary.ContainsKey("f"))
			{
				string key4 = (dictionary.ContainsKey("frame") ? "frame" : "f");
				if (dictionary[key4] == "none")
				{
					_frameRenderer.enabled = false;
				}
			}
		}
		// The text is used as a file path, and characters Windows does not allow in paths (" < > |) make that throw.
		try
		{
			if (textureCache.IsDirectory(text))
			{
				StartAnimation(textureCache.LoadTextureNames(text));
			}
			else
			{
				SetTexture(text);
			}
		}
		catch (ArgumentException)
		{
			SetPicture(null);
		}
	}

	private void UpdateText()
	{
		string text = GetText();
		if (!(TextWidget.text == text))
		{
			TextWidget.text = text;
			UpdatePicture();
		}
	}

	// Sign text is user input (and synced from other players), so parse it culture-independently and never throw.
	private static bool TryParseFloat(string text, out float value)
	{
		return float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
	}

	private static bool IsUrl(string text)
	{
		if (Uri.TryCreate(text, UriKind.Absolute, out var result))
		{
			if (!(result.Scheme == Uri.UriSchemeHttp))
			{
				return result.Scheme == Uri.UriSchemeHttps;
			}
			return true;
		}
		return false;
    }

    public float GetHoverOffset()
    {
        return m_hoverOffset;
    }
}
