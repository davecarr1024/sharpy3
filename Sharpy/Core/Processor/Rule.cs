namespace Sharpy.Core.Processor;

public interface Rule<State, Result>
{
    public (State, Result) Apply(Scope<State, Result> scope, State state);
}
