using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CoreWoodExtras;

// Small JSON reader for the mod's config files. Objects become Dictionary<string, object>, arrays List<object>,
// numbers double, and strings/bools/null map to their .NET equivalents.
internal static class MiniJson
{
    public static object Parse(string json)
    {
        int index = 0;
        object value = ParseValue(json, ref index);
        return value;
    }

    private static object ParseValue(string json, ref int index)
    {
        SkipWhitespace(json, ref index);
        char c = json[index];

        if (c == '{')
        {
            return ParseObject(json, ref index);
        }
        if (c == '[')
        {
            return ParseArray(json, ref index);
        }
        if (c == '"')
        {
            return ParseString(json, ref index);
        }
        if (c == 't' || c == 'f')
        {
            return ParseBool(json, ref index);
        }
        if (c == 'n')
        {
            index += 4; // "null"
            return null;
        }

        return ParseNumber(json, ref index);
    }

    private static Dictionary<string, object> ParseObject(string json, ref int index)
    {
        Dictionary<string, object> result = new Dictionary<string, object>();
        index++; // skip '{'
        SkipWhitespace(json, ref index);

        if (json[index] == '}')
        {
            index++;
            return result;
        }

        while (true)
        {
            SkipWhitespace(json, ref index);
            string key = ParseString(json, ref index);
            SkipWhitespace(json, ref index);
            index++; // skip ':'
            object value = ParseValue(json, ref index);
            result[key] = value;

            SkipWhitespace(json, ref index);
            if (json[index] == ',')
            {
                index++;
                continue;
            }

            index++; // skip '}'
            break;
        }

        return result;
    }

    private static List<object> ParseArray(string json, ref int index)
    {
        List<object> result = new List<object>();
        index++; // skip '['
        SkipWhitespace(json, ref index);

        if (json[index] == ']')
        {
            index++;
            return result;
        }

        while (true)
        {
            object value = ParseValue(json, ref index);
            result.Add(value);

            SkipWhitespace(json, ref index);
            if (json[index] == ',')
            {
                index++;
                continue;
            }

            index++; // skip ']'
            break;
        }

        return result;
    }

    private static string ParseString(string json, ref int index)
    {
        index++; // skip opening quote
        StringBuilder sb = new StringBuilder();

        while (json[index] != '"')
        {
            char c = json[index];
            if (c == '\\')
            {
                index++;
                char esc = json[index];
                switch (esc)
                {
                    case '"': sb.Append('"'); break;
                    case '\\': sb.Append('\\'); break;
                    case '/': sb.Append('/'); break;
                    case 'b': sb.Append('\b'); break;
                    case 'f': sb.Append('\f'); break;
                    case 'n': sb.Append('\n'); break;
                    case 'r': sb.Append('\r'); break;
                    case 't': sb.Append('\t'); break;
                    case 'u':
                        string hex = json.Substring(index + 1, 4);
                        sb.Append((char)Convert.ToInt32(hex, 16));
                        index += 4;
                        break;
                    default:
                        sb.Append(esc);
                        break;
                }
            }
            else
            {
                sb.Append(c);
            }

            index++;
        }

        index++; // skip closing quote
        return sb.ToString();
    }

    private static bool ParseBool(string json, ref int index)
    {
        if (json[index] == 't')
        {
            index += 4; // "true"
            return true;
        }

        index += 5; // "false"
        return false;
    }

    private static double ParseNumber(string json, ref int index)
    {
        int start = index;
        while (index < json.Length && IsNumberChar(json[index]))
        {
            index++;
        }

        string numberText = json.Substring(start, index - start);
        return double.Parse(numberText, CultureInfo.InvariantCulture);
    }

    private static bool IsNumberChar(char c)
    {
        return char.IsDigit(c) || c == '-' || c == '+' || c == '.' || c == 'e' || c == 'E';
    }

    private static void SkipWhitespace(string json, ref int index)
    {
        while (index < json.Length && char.IsWhiteSpace(json[index]))
        {
            index++;
        }
    }

    public static string GetString(Dictionary<string, object> entry, string key, string fallback)
    {
        return entry.TryGetValue(key, out object value) && value is string s ? s : fallback;
    }

    public static int GetInt(Dictionary<string, object> entry, string key, int fallback)
    {
        return entry.TryGetValue(key, out object value) && value is double d ? (int)d : fallback;
    }

    public static bool GetBool(Dictionary<string, object> entry, string key, bool fallback)
    {
        return entry.TryGetValue(key, out object value) && value is bool b ? b : fallback;
    }
}
