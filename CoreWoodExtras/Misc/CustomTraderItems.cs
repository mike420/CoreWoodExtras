using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CoreWoodExtras;

internal static class CustomTraderItems
{
    public class CustomTraderItem
    {
        public string prefabName = "";
        public int stack = 1;
        public int price = 100;
        public string requiredGlobalKey = "";
        public bool enabled = true;
    }

    private const string FileName = "BurtItems.json";

    public static List<CustomTraderItem> Items { get; private set; } = new List<CustomTraderItem>();

    public static bool HasAnyEnabledItem { get; private set; }

    public static void Load()
    {
        string filePath = CoreWoodPlugin._basePath + Path.DirectorySeparatorChar + FileName;

        try
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, DefaultFileContents);
                Jotunn.Logger.LogInfo($"[CoreWoodExtras] Created default custom trader items file at {filePath}");
            }

            string json = File.ReadAllText(filePath);
            Items = ParseItems(json);

            Jotunn.Logger.LogInfo($"[CoreWoodExtras] Loaded {Items.Count} custom trader item(s) from {FileName}.");
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError($"[CoreWoodExtras] Failed to load {FileName}: {ex}");
            Items = new List<CustomTraderItem>();
        }

        HasAnyEnabledItem = false;
        foreach (CustomTraderItem item in Items)
        {
            if (item.enabled && !string.IsNullOrEmpty(item.prefabName))
            {
                HasAnyEnabledItem = true;
                break;
            }
        }

        if (!HasAnyEnabledItem)
        {
            Jotunn.Logger.LogWarning($"[CoreWoodExtras] {FileName} has no enabled items - Burt will be disabled until at least one item is enabled.");
        }
    }

    private static List<CustomTraderItem> ParseItems(string json)
    {
        List<CustomTraderItem> result = new List<CustomTraderItem>();

        object root = MiniJson.Parse(json);
        if (!(root is Dictionary<string, object> rootObject))
        {
            Jotunn.Logger.LogWarning($"[CoreWoodExtras] {FileName} does not contain a JSON object at the top level.");
            return result;
        }

        if (!rootObject.TryGetValue("items", out object itemsRaw) || !(itemsRaw is List<object> itemsArray))
        {
            Jotunn.Logger.LogWarning($"[CoreWoodExtras] {FileName} has no 'items' array.");
            return result;
        }

        foreach (object entryRaw in itemsArray)
        {
            if (!(entryRaw is Dictionary<string, object> entry))
            {
                continue;
            }

            result.Add(new CustomTraderItem
            {
                prefabName = MiniJson.GetString(entry, "prefabName", ""),
                stack = MiniJson.GetInt(entry, "stack", 1),
                price = MiniJson.GetInt(entry, "price", 100),
                requiredGlobalKey = MiniJson.GetString(entry, "requiredGlobalKey", ""),
                enabled = MiniJson.GetBool(entry, "enabled", true),
            });
        }

        return result;
    }

    private const string DefaultFileContents = @"{
	  ""items"": [
		{
		  ""prefabName"": ""ExampleItemPrefabName"",
		  ""stack"": 1,
		  ""price"": 100,
		  ""requiredGlobalKey"": """",
		  ""enabled"": false
		}
	  ]
	}
	";
}