namespace Sharpy.Core.Processor;

public interface Rule<State, Result>
{
    public (State, Result) Apply(IScope<State, Result> scope, State state);
}
