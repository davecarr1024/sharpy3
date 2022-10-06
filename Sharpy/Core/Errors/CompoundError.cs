namespace Sharpy.Core.Errors
{
    public class CompoundError : Error
    {
        public IImmutableList<Error> Children { get; init; }

        public CompoundError(IImmutableList<Error> children) => Children = children;

        public override bool Equals(object? obj) => obj is CompoundError error && Children.SequenceEqual(error.Children) && base.Equals(obj);

        public override int GetHashCode() => HashCode.Combine(Children.GetHashCode(), base.GetHashCode());
    }
}