using System.Diagnostics.CodeAnalysis;

namespace Sharpy.Core.Processor;
public record class Scope<State, Result> : IImmutableDictionary<string, Rule<State, Result>>
{
    public Scope(IImmutableDictionary<string, Rule<State, Result>> rules) => Rules = rules;

    public IImmutableDictionary<string, Rule<State, Result>> Rules { get; init; }

    public IEnumerable<string> Keys => Rules.Keys;

    public IEnumerable<Rule<State, Result>> Values => Rules.Values;

    public int Count => Rules.Count;

    public Rule<State, Result> this[string key] => Rules[key];


    public IImmutableDictionary<string, Rule<State, Result>> Add(string key, Rule<State, Result> value)
        => this with { Rules = Rules.Add(key, value) };

    public IImmutableDictionary<string, Rule<State, Result>> AddRange(IEnumerable<KeyValuePair<string, Rule<State, Result>>> pairs)
        => this with { Rules = Rules.AddRange(pairs) };

    public IImmutableDictionary<string, Rule<State, Result>> Clear() => this with { Rules = Rules.Clear() };

    public bool Contains(KeyValuePair<string, Rule<State, Result>> pair) => Rules.Contains(pair);

    public IImmutableDictionary<string, Rule<State, Result>> Remove(string key) => this with { Rules = Rules.Remove(key) };

    public IImmutableDictionary<string, Rule<State, Result>> RemoveRange(IEnumerable<string> keys)
        => this with { Rules = Rules.RemoveRange(keys) };

    public IImmutableDictionary<string, Rule<State, Result>> SetItem(string key, Rule<State, Result> value)
        => this with { Rules = Rules.SetItem(key, value) };

    public IImmutableDictionary<string, Rule<State, Result>> SetItems(IEnumerable<KeyValuePair<string, Rule<State, Result>>> items)
        => this with { Rules = Rules.SetItems(items) };

    public bool TryGetKey(string equalKey, out string actualKey) => Rules.TryGetKey(equalKey, out actualKey);

    public bool ContainsKey(string key) => Rules.ContainsKey(key);
    public bool TryGetValue(string key, [MaybeNullWhen(false)] out Rule<State, Result> value) => Rules.TryGetValue(key, out value);

    public IEnumerator<KeyValuePair<string, Rule<State, Result>>> GetEnumerator() => Rules.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => Rules.GetEnumerator();

}
