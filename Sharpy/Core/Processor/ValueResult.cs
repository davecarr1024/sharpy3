namespace Sharpy.Core.Processor
{
    public class ValueResult<ValueType> : Result
    {
        public ValueType Value { get; init; }

        public ValueResult(ValueType value) : base() => Value = value;

        public ValueResult(ValueType value, IReadOnlyList<Result> children) : base(children) => Value = value;

        protected override string ToStringLine() => string.Format("ValueResult({0})", Value);

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
    }
}