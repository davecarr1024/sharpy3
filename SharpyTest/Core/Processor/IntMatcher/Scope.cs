namespace SharpyTest.Core.Processor.IntMatcher;
using Sharpy.Core.Processor;

public record class Scope : Sharpy.Core.Processor.Scope<ImmutableList<int>, int>
{
    public Scope(IImmutableDictionary<string, Rule<ImmutableList<int>, int>> rules) : base(rules)
    {
    }
}