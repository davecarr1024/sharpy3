using System.Collections;
using System.Diagnostics;
using System.Text;

namespace Sharpy.Core.Processor
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class Result
    {
        public IReadOnlyList<Result> Children { get; init; }

        public Result() => Children = new List<Result>();

        public Result(IReadOnlyList<Result> children) => Children = children;

        public override string ToString()
        {
            return string.Format("Result(children=[{0}])", string.Join(", ", Children));
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
            return obj is Result result && Children.SequenceEqual(result.Children);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Children);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}