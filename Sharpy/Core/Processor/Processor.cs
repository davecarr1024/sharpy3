namespace Sharpy.Core.Processor
{
    public record class Processor<StateValue>
    {
        public string RootRuleName { get; init; }

        public IReadOnlyDictionary<string, Rule<StateValue>> Rules { get; init; }

        public Processor(string rootRuleName, IReadOnlyDictionary<string, Rule<StateValue>> rules)
        {
            RootRuleName = rootRuleName;
            Rules = rules;
        }
    }
}