namespace Sharpy.Core.Processor;
public record class Processor<State, Result> : Scope<State, Result>, Rule<State, Result>
{
    public Processor(string rootRuleName, IImmutableDictionary<string, Rule<State, Result>> rules)
        : base(rules)
        => RootRuleName = rootRuleName;

    public string RootRuleName { get; init; }

    public (State, Result) Apply(State state) => Apply(RootRuleName, state);

    public (State, Result) Apply(string ruleName, State state) => Apply(this, ruleName, state);

    public (State, Result) Apply(IScope<State, Result> scope, State state) => Apply(scope, RootRuleName, state);

    public (State, Result) Apply(IScope<State, Result> scope, string ruleName, State state)
    {
        try
        {
            return Rules[ruleName].Apply(scope, state);
        }
        catch (Errors.Error error)
        {
            throw new Errors.RuleError(ruleName, error);
        }
    }
}
