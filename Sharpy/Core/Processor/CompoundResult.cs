namespace Sharpy.Core.Processor
{
    public class CompoundResult : Result
    {
        public IReadOnlyList<Result> Children { get; init; }

        public CompoundResult(IReadOnlyList<Result> children) => Children = children;

        public CompoundResult(params Result[] children) => Children = children;

        public override bool Equals(object? obj) => obj is CompoundResult result && Children.SequenceEqual(result.Children);

        public override int GetHashCode() => HashCode.Combine(Children);

        public IEnumerable<Result> ToEnumerable()
        {
            yield return this;
            foreach (Result child in Children)
            {
                foreach (Result result in child.ToEnumerable())
                {
                    yield return result;
                }
            }
        }
    }
}