using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Jotunn;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreWoodExtras.TextureUtils;

public class TextureCache
{
	private readonly Dictionary<string, Texture> cache = new Dictionary<string, Texture>();

	public string ImageBasePath { get; }

	public TextureCache(string imageBasePath)
	{
		ImageBasePath = imageBasePath;
	}

	public Texture Load(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		string text = Path.ChangeExtension(name, Path.GetExtension(name).ToLower());
		if (cache.ContainsKey(text))
		{
			return cache[text];
		}
		if (!text.EndsWith(".jpg") && !text.EndsWith(".png"))
		{
			return null;
		}
		string path = Path.Combine(ImageBasePath, text);
		if (!File.Exists(path))
		{
			return null;
		}
		byte[] data = File.ReadAllBytes(path);
		Texture2D texture2D = new Texture2D(2, 2);
		texture2D.LoadImage(data);
		if (texture2D == null)
		{
			return null;
		}
		texture2D.name = text;
		cache.Add(text, texture2D);
		return texture2D;
	}

	public IEnumerator FetchFromWeb(string url, Action<Texture> callback)
	{
		string textureName = Path.ChangeExtension(url, Path.GetExtension(url).ToLower());
		if (cache.ContainsKey(textureName))
		{
			yield break;
		}
		using UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture(url);
		yield return webRequest.SendWebRequest();
		if (webRequest.result == UnityWebRequest.Result.ProtocolError || webRequest.result == UnityWebRequest.Result.ConnectionError)
		{
			Jotunn.Logger.LogError(webRequest.error);
			yield break;
		}
		Texture texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
		cache.Add(textureName, texture);
		callback(texture);
	}

	public string[] LoadTextureNames(string dirPath)
	{
		string path = Path.Combine(ImageBasePath, dirPath);
		try
		{
			return (from s in Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly)
				where s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
				select s).ToArray();
		}
		catch (DirectoryNotFoundException)
		{
			return null;
		}
	}

	public bool IsDirectory(string path)
	{
		if (string.IsNullOrWhiteSpace(path))
		{
			return false;
		}
		return Directory.Exists(Path.Combine(ImageBasePath, path));
	}
}
