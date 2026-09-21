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

	// Cache key: the name with a lowercase extension, so "a.PNG" and "a.png" share an entry.
	// Only the key is normalised; files are always opened with the name as written, because paths are case sensitive on Linux.
	private static string NormalizeKey(string name)
	{
		return Path.ChangeExtension(name, Path.GetExtension(name).ToLower());
	}

	public Texture Load(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		string text = NormalizeKey(name);
		if (cache.TryGetValue(text, out Texture cached))
		{
			return cached;
		}
		if (!text.EndsWith(".jpg") && !text.EndsWith(".png"))
		{
			return null;
		}
		string path = Path.Combine(ImageBasePath, name);
		if (!File.Exists(path))
		{
			return null;
		}
		byte[] data = File.ReadAllBytes(path);
		Texture2D texture2D = new Texture2D(2, 2);
		if (!texture2D.LoadImage(data))
		{
			UnityEngine.Object.Destroy(texture2D);
			return null;
		}
		texture2D.name = text;
		cache.Add(text, texture2D);
		return texture2D;
	}

	public IEnumerator FetchFromWeb(string url, Action<Texture> callback)
	{
		string textureName = NormalizeKey(url);
		if (cache.TryGetValue(textureName, out Texture cached))
		{
			callback(cached);
			yield break;
		}
		using UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture(url);
		yield return webRequest.SendWebRequest();
		if (webRequest.result != UnityWebRequest.Result.Success)
		{
			Jotunn.Logger.LogError(webRequest.error);
			yield break;
		}
		Texture texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
		// Another request for the same url may have finished first.
		if (!cache.ContainsKey(textureName))
		{
			cache.Add(textureName, texture);
		}
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
