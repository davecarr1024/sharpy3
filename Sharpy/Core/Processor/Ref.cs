namespace Sharpy.Core.Processor;

public record class Ref<State, Result> : Rule<State, Result>
{
    public Ref(string name) => Name = name;

    public string Name { get; init; }

    public (State, Result) Apply(Scope<State, Result> scope, State state)
        => scope[Name].Apply(scope, state);
}
