namespace Sharpy.Core.Processor;

public record class Or<State, Result> : NaryRule<State, Result>
{
    public Or(IImmutableList<Rule<State, Result>> children) : base(children)
    {
    }

    public override (State, Result) Apply(Scope<State, Result> scope, State state)
    {
        var errors = new List<Errors.Error>();
        foreach (var child in Children)
        {
            try
            {
                return child.Apply(scope, state);
            }
            catch (Errors.Error error)
            {
                errors.Add(error);
            }
        }
        throw new Errors.CompoundError(errors.ToImmutableList());
    }
}
