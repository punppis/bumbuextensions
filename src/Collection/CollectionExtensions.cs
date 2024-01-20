namespace bumbuextensions.Collections;

static public class CollectionExtensions
{
    static public void AddOrReplaceRange<TKey, TValue>(this IDictionary<TKey, TValue> dict, IEnumerable<TValue> newValues, Func<TValue, TKey> getKeyFunc) where TKey : notnull
    {
        foreach (var val in newValues)
        {
            TKey key = getKeyFunc(val);
            dict[key] = val;
        }
    }

    static public void AddOrReplaceRange<TKey, TValue>(this IDictionary<TKey, TValue> dict, IDictionary<TKey, TValue> addOrReplaceData) where TKey : notnull
    {
        foreach (var val in addOrReplaceData)
        {
            dict[val.Key] = val.Value;
        }
    }

    static public TValue? GetValue<TKey, TValue>(this IDictionary<TKey, object> dict, TKey key, TValue? defaultValue = default) where TKey : notnull
    {
        if (dict.ContainsKey(key))
        {
            return (TValue)dict[key];
        }
        return defaultValue;
    }
}