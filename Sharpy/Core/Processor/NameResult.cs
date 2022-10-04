using System.Diagnostics;

namespace Sharpy.Core.Processor
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class NameResult : Result
    {
        public string Name { get; init; }

        public NameResult(string name) : base() => Name = name;

        public override string ToString()
            => string.Format("NameResult(Name='{0}')", Name);

        public override bool Equals(object? obj)
            => obj is NameResult result && Name == result.Name;

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Name);

        private string GetDebuggerDisplay() => ToString();

        public IEnumerable<Result> ToEnumerable()
        {
            yield return this;
        }
    }
}
