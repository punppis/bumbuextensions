using System.Text.Json;

namespace bumbuextensions.Json;

public class DotNetJsonParser : IJsonParser
{
    static public JsonSerializerOptions DefaultOptions = new JsonSerializerOptions()
    {
        WriteIndented = false
    };

    JsonSerializerOptions GetOptions(JsonParserOptions? options)
    {
        return options == null ? DefaultOptions : new JsonSerializerOptions()
        {
            WriteIndented = options.WriteIndented
        };
    }

    public string GetJsonString(object o, JsonParserOptions? options = default)
    {
        return JsonSerializer.Serialize(o, GetOptions(options));
    }

    public T? ParseJson<T>(string json, JsonParserOptions? options = default)
    {
        return JsonSerializer.Deserialize<T>(json, GetOptions(options));
    }
}
