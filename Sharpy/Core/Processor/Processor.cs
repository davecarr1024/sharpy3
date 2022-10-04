namespace Sharpy.Core.Processor
{
    public record class Processor<StateValue, ResultValue> : Rule<StateValue, ResultValue>
    {
        public string RootRuleName { get; init; }

        public IReadOnlyDictionary<string, Rule<StateValue, ResultValue>> Rules { get; init; }

        public Processor(string rootRuleName, IReadOnlyDictionary<string, Rule<StateValue, ResultValue>> rules)
        {
            RootRuleName = rootRuleName;
            Rules = rules;
        }

        public ResultAndState<StateValue, ResultValue> Apply(string ruleName, State<StateValue, ResultValue> state) => Rules[ruleName].Apply(state);

        public ResultAndState<StateValue, ResultValue> Apply(State<StateValue, ResultValue> state) => Apply(RootRuleName, state);
    }
}