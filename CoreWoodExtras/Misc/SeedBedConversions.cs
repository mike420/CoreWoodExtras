using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Jotunn.Entities;
using Jotunn.Managers;

namespace CoreWoodExtras;

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

    private static readonly string[] DefaultHerbs =
    {
        "$bh_boswellia", "$bh_chamomile", "$bh_chicory", "$bh_daisy", "$bh_echinacea", "$bh_lavender", "$item_dandelion", "$item_thistle"
    };

    private static volatile List<Conversion> s_items = new List<Conversion>();

    private static volatile HashSet<string> s_herbs = new HashSet<string>(DefaultHerbs, StringComparer.OrdinalIgnoreCase);

    private static int s_version;

    private static volatile string s_localJson;

    private static volatile bool s_usingServerItems;

    private static volatile bool s_broadcastPending;

    private static CustomRPC s_rpc;

    public static IReadOnlyList<Conversion> Items => s_items;

    public static bool IsHerb(string prefabName, string sharedName)
    {
        HashSet<string> herbs = s_herbs;
        return herbs.Contains(prefabName) || herbs.Contains(sharedName);
    }

    public static int Version => Volatile.Read(ref s_version);

    private static string FilePath => CoreWoodPlugin._basePath + Path.DirectorySeparatorChar + FileName;

    public static void Load()
    {
        s_rpc = NetworkManager.Instance.AddRPC("MM_SeedBedItems", OnServerReceive, OnClientReceive);
        Reload();
        FileWatcher.WatchFileChanges(FilePath, Reload);
    }

    private static void Reload()
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, DefaultFileContents());
                Jotunn.Logger.LogInfo($"[CoreWoodExtras] Created default seed bed items file at {FilePath}");
            }

            string json = File.ReadAllText(FilePath);
            List<Conversion> parsed = ParseItems(json, out HashSet<string> herbs);
            s_localJson = json;
            s_broadcastPending = true;
            if (s_usingServerItems)
            {
                Jotunn.Logger.LogInfo($"[CoreWoodExtras] {FileName} changed, but the server's seed bed items are in use until you disconnect.");
                return;
            }
            Apply(parsed, herbs, FileName);
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError($"[CoreWoodExtras] Failed to load {FileName}: {ex.Message}");
        }
    }

    private static void Apply(List<Conversion> items, HashSet<string> herbs, string source)
    {
        s_items = items;
        s_herbs = herbs;
        Interlocked.Increment(ref s_version);
        Jotunn.Logger.LogInfo($"[CoreWoodExtras] Loaded {items.Count} seed bed conversion(s) and {herbs.Count} herb(s) from {source}.");
    }

    public static void SendToPeer(ZNetPeer peer)
    {
        string json = s_localJson;
        if (s_rpc != null && peer != null && !string.IsNullOrEmpty(json))
        {
            s_rpc.SendPackage(peer.m_uid, CreatePackage(json));
        }
    }

    public static void BroadcastIfChanged()
    {
        if (!s_broadcastPending)
        {
            return;
        }
        s_broadcastPending = false;
        string json = s_localJson;
        ZNet znet = ZNet.instance;
        if (s_rpc != null && znet != null && znet.IsServer() && znet.m_peers.Count > 0 && !string.IsNullOrEmpty(json))
        {
            s_rpc.SendPackage(znet.m_peers, CreatePackage(json));
        }
    }

    public static void UseLocalItems()
    {
        if (!s_usingServerItems)
        {
            return;
        }
        s_usingServerItems = false;
        string json = s_localJson;
        if (string.IsNullOrEmpty(json))
        {
            return;
        }
        try
        {
            Apply(ParseItems(json, out HashSet<string> herbs), herbs, FileName);
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError($"[CoreWoodExtras] Failed to load {FileName}: {ex.Message}");
        }
    }

    private static ZPackage CreatePackage(string json)
    {
        ZPackage package = new ZPackage();
        package.Write(json);
        return package;
    }

    private static IEnumerator OnServerReceive(long sender, ZPackage package)
    {
        yield break;
    }

    private static IEnumerator OnClientReceive(long sender, ZPackage package)
    {
        try
        {
            List<Conversion> parsed = ParseItems(package.ReadString(), out HashSet<string> herbs);
            s_usingServerItems = true;
            Apply(parsed, herbs, "the server");
        }
        catch (Exception ex)
        {
            Jotunn.Logger.LogError($"[CoreWoodExtras] Failed to load the server's seed bed items: {ex.Message}");
        }
        yield break;
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
