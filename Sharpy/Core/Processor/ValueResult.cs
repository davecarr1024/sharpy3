using System.Diagnostics;

namespace Sharpy.Core.Processor
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class ValueResult<ValueType> : Result
    {
        public ValueType Value { get; init; }

        public ValueResult(ValueType value) : base() => Value = value;

        public ValueResult(ValueType value, IReadOnlyList<Result> children) : base(children) => Value = value;

        public override string ToString()
        {
            return string.Format("ValueResult(Value='{0}',Children=[{1}])", Value, string.Join(", ", Children));
        }

        public override bool Equals(object? obj)
        {
            return obj is ValueResult<ValueType> result &&
                   base.Equals(obj) &&
                   EqualityComparer<ValueType>.Default.Equals(Value, result.Value);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Value);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}