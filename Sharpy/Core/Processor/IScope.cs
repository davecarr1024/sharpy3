namespace Sharpy.Core.Processor;

public interface IScope<State, Result>
: IImmutableDictionary<string, Rule<State, Result>>
{ }
