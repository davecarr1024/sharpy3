using System.Diagnostics;

namespace Sharpy.Core.Processor
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class RuleResult : Result
    {
        public string RuleName { get; init; }

        public RuleResult(string ruleName) : base() => RuleName = ruleName;

        public RuleResult(string ruleName, IReadOnlyList<Result> children) : base(children) => RuleName = ruleName;

        public override string ToString()
        {
            return string.Format("RuleResult(RuleName='{0}',Children=[{1}])", RuleName, string.Join(", ", Children));
        }

        public override bool Equals(object? obj)
        {
            return obj is RuleResult result &&
                   base.Equals(obj) &&
                   RuleName == result.RuleName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), RuleName);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
