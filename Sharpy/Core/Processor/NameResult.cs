using System.Diagnostics;

namespace Sharpy.Core.Processor
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class NameResult<ValueType> : Result<ValueType>
    {
        public string Name { get; init; }

        public Result<ValueType> Child { get; init; }

        public NameResult(string name, Result<ValueType> child) => (Name, Child) = (name, child);

        public override string ToString()
            => string.Format("NameResult(Name='{0}',Child={1})", Name, Child);

        public override bool Equals(object? obj)
            => obj is NameResult<ValueType> result && Name == result.Name && Child.Equals(result.Child);

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Name);

        private string GetDebuggerDisplay() => ToString();

        public ValueType Evaluate() => Child.Evaluate();
    }
}
