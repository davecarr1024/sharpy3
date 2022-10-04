using System.Diagnostics;

namespace Sharpy.Core.Processor
{
    [DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
    public class ValueResult<ValueType> : Result<ValueType>
    {
        public ValueType Value { get; init; }

        public ValueResult(ValueType value) : base() => Value = value;

        public override string ToString() => string.Format("ValueResult(Value='{0}')", Value);

        public override bool Equals(object? obj)
            => obj is ValueResult<ValueType> result &&
                EqualityComparer<ValueType>.Default.Equals(Value, result.Value);

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Value);

        private string DebuggerDisplay => ToString();

        public ValueType Evaluate() => Value;
    }
}