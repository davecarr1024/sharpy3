namespace Sharpy.Core.Processor;

public abstract record class NaryRule<State, Result> : Rule<State, Result>
{
    protected NaryRule(IImmutableList<Rule<State, Result>> children) => Children = children;

    public IImmutableList<Rule<State, Result>> Children { get; init; }

    public abstract (State, Result) Apply(Scope<State, Result> scope, State state);
}