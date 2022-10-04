using System.Text;

namespace Sharpy.Core.Processor
{
    public class Result
    {
        public IReadOnlyList<Result> Children { get; init; }

        public Result() => Children = new List<Result>();

        public Result(IReadOnlyList<Result> children) => Children = children;

        public IList<Result> AsList()
        {
            List<Result> results = new List<Result> { this };
            foreach (Result child in Children)
            {
                results.AddRange(child.AsList());
            }
            return results;
        }

        protected virtual string ToStringLine() => "Result()";

        private string ToString(int indent)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Insert(0, "  ", indent);
            sb.Append(ToStringLine());
            foreach (Result child in Children)
            {
                sb.Append(child.ToString(indent + 1));
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            //test
            return ToString(0);
        }

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

        public override bool Equals(object? obj)
        {
            return obj is Result result &&
            Children.SequenceEqual(result.Children);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Children);
        }
    }
}