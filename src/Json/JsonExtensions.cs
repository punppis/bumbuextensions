namespace bumbuextensions.Json;

static public class JsonExtensions
{
    static public IJsonParser JsonParser = new DotNetJsonParser();
    
    static public readonly JsonParserOptions HumanReadableJson = new ()
    {
        WriteIndented = true
    };

    static public string GetJsonString(this object o, JsonParserOptions? options = default) => JsonParser.GetJsonString(o, options);
    static public T? ParseJson<T>(this string json, JsonParserOptions? options = default) => JsonParser.ParseJson<T>(json, options);
}
