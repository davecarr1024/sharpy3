using Sharpy.Core.Processor;

namespace SharpyTest.Core.Processor
{
    public record class IntMatcher : Processor<ImmutableList<int>, int>
    {
        public IntMatcher(string rootRuleName, IImmutableDictionary<string, Rule<ImmutableList<int>, int>> rules)
        : base(rootRuleName, rules)
        { }
    }
}