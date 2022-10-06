namespace SharpyTest.Core.Processor.IntMatcher;
using Sharpy.Core.Errors;
using Sharpy.Core.Processor;

public record class Eq : Rule<ImmutableList<int>, int>
{
    public int Value { get; init; }

    public (ImmutableList<int>, int)
        Apply(IScope<ImmutableList<int>, int> scope, ImmutableList<int> state)
    {
        if (state.IsEmpty)
        {
            throw new Error("empty state");
        }
        if (state.First() != Value)
        {
            throw new Error($"state {state.First()} != {Value}");
        }
        return (state.Skip(1).ToImmutableList(), Value);
    }
}
