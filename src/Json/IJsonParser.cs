namespace bumbuextensions.Json;

public interface IJsonParser
{
    string GetJsonString(object o, JsonParserOptions? options = default);
    T? ParseJson<T>(string json, JsonParserOptions? options = default);

}