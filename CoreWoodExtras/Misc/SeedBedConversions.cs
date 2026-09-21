using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace CoreWoodExtras;

// What the seed bed can germinate ("conversions") and which harvested items count as herbs for Herbalist XP ("herbs"),
// loaded from BepInEx/config/CoreWoodExtras/SeedBedItems.json.
// The file is watched and re-read when it changes; each SeedBed rebuilds its list when Version changes.
internal static class SeedBedConversions
{
    public class Conversion
    {
        public string from = "";
        public string to = "";
        public int seedAmount = 5;
        public int producedItems = 15;
    }

    private const string FileName = "SeedBedItems.json";

    // Used when the file has no "herbs" array (for example a file written by an older version).
    private static readonly string[] DefaultHerbs =
    {
        "$bh_boswellia", "$bh_chamomile", "$bh_chicory", "$bh_daisy", "$bh_echinacea", "$bh_lavender", "$item_dandelion", "$item_thistle"
    };

    private static volatile List<Conversion> s_items = new List<Conversion>();

    private static volatile HashSet<string> s_herbs = new HashSet<string>(DefaultHerbs, StringComparer.OrdinalIgnoreCase);

    private static int s_version;

    public static IReadOnlyList<Conversion> Items => s_items;

    // An entry in "herbs" can be the item's prefab name (Dandelion) or its shared name ($item_dandelion).
    public static bool IsHerb(string prefabName, string sharedName)
    {
        HashSet<string> herbs = s_herbs;
        return herbs.Contains(prefabName) || herbs.Contains(sharedName);
    }

    // Bumped every time the file is (re)loaded successfully.
    public static int Version => Volatile.Read(ref s_version);

    private static string FilePath => CoreWoodPlugin._basePath + Path.DirectorySeparatorChar + FileName;

    public static void Load()
    {
        Reload();
        FileWatcher.WatchFileChanges(FilePath, Reload);
    }

    // Runs on the file watcher's thread as well, so it only touches plain data and swaps the list in one step.
    private static void Reload()
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, DefaultFileContents());
                Jotunn.Logger.LogInfo($"[CoreWoodExtras] Created default seed bed items file at {FilePath}");
            }

            List<Conversion> parsed = ParseItems(File.ReadAllText(FilePath), out HashSet<string> herbs);
            s_items = parsed;
            s_herbs = herbs;
            Interlocked.Increment(ref s_version);
            Jotunn.Logger.LogInfo($"[CoreWoodExtras] Loaded {parsed.Count} seed bed conversion(s) and {herbs.Count} herb(s) from {FileName}.");
        }
        catch (Exception ex)
        {
            // Keep the previous list so a half-saved file never empties the seed bed.
            Jotunn.Logger.LogError($"[CoreWoodExtras] Failed to load {FileName}: {ex.Message}");
        }
    }

    private static List<Conversion> ParseItems(string json, out HashSet<string> herbs)
    {
        List<Conversion> result = new List<Conversion>();

        if (!(MiniJson.Parse(json) is Dictionary<string, object> root))
        {
            throw new FormatException("the top level must be a JSON object");
        }
        if (!root.TryGetValue("conversions", out object raw) || !(raw is List<object> list))
        {
            throw new FormatException("there is no 'conversions' array");
        }

        // A missing "herbs" array keeps the defaults; an empty one means no item gives Herbalist XP.
        herbs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        if (root.TryGetValue("herbs", out object herbsRaw) && herbsRaw is List<object> herbList)
        {
            foreach (object herb in herbList)
            {
                if (herb is string name && !string.IsNullOrWhiteSpace(name))
                {
                    herbs.Add(name.Trim());
                }
            }
        }
        else
        {
            herbs.UnionWith(DefaultHerbs);
        }

        foreach (object entryRaw in list)
        {
            if (!(entryRaw is Dictionary<string, object> entry))
            {
                continue;
            }
            string from = MiniJson.GetString(entry, "from", "");
            string to = MiniJson.GetString(entry, "to", "");
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
            {
                continue;
            }
            result.Add(new Conversion
            {
                from = from,
                to = to,
                seedAmount = Math.Max(1, MiniJson.GetInt(entry, "seedAmount", 5)),
                producedItems = Math.Max(1, MiniJson.GetInt(entry, "producedItems", 15)),
            });
        }

        return result;
    }

    private static string DefaultFileContents()
    {
        string[][] defaults =
        {
            new[] { "Barley", "Barley" },
            new[] { "CarrotSeeds", "Carrot" },
            new[] { "Dandelion", "Dandelion" },
            new[] { "Fiddleheadfern", "Fiddleheadfern" },
            new[] { "Flax", "Flax" },
            new[] { "Mushroom", "Mushroom" },
            new[] { "MushroomMagecap", "MushroomMagecap" },
            new[] { "MushroomYellow", "MushroomYellow" },
            new[] { "MushroomJotunPuffs", "MushroomJotunPuffs" },
            new[] { "OnionSeeds", "Onion" },
            new[] { "Carrot", "CarrotSeeds" },
            new[] { "Onion", "OnionSeeds" },
            new[] { "Turnip", "TurnipSeeds" },
            new[] { "MushroomSmokePuff", "MushroomSmokePuff" },
            new[] { "Thistle", "Thistle" },
            new[] { "TurnipSeeds", "Turnip" },
            new[] { "Blueberries", "Blueberries" },
            new[] { "Cloudberry", "Cloudberry" },
            new[] { "Raspberry", "Raspberry" },
            new[] { "Vineberry", "Vineberry" },
        };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("{");
        sb.AppendLine("  \"herbs\": [");
        for (int i = 0; i < DefaultHerbs.Length; i++)
        {
            sb.Append("    \"").Append(DefaultHerbs[i]).AppendLine(i < DefaultHerbs.Length - 1 ? "\"," : "\"");
        }
        sb.AppendLine("  ],");
        sb.AppendLine("  \"conversions\": [");
        for (int i = 0; i < defaults.Length; i++)
        {
            sb.Append("    { \"from\": \"").Append(defaults[i][0]).Append("\", \"to\": \"").Append(defaults[i][1]);
            sb.Append("\", \"seedAmount\": 5, \"producedItems\": 15 }").AppendLine(i < defaults.Length - 1 ? "," : "");
        }
        sb.AppendLine("  ]");
        sb.AppendLine("}");
        return sb.ToString();
    }
}
