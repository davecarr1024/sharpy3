namespace Sharpy.Core.Processor;

public record struct Ref<State, Result> : Rule<State, Result>
{
    public string Name { get; init; }

    public (State, Result) Apply(IScope<State, Result> scope, State state)
        => scope[Name].Apply(scope, state);
}
