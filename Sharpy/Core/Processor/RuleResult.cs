namespace Sharpy.Core.Processor
{
    public class RuleResult : Result
    {
        public string RuleName { get; init; }

        public RuleResult(string ruleName) : base() => RuleName = ruleName;

        public RuleResult(string ruleName, IReadOnlyList<Result> children) : base(children) => RuleName = ruleName;

        protected override string ToStringLine() => string.Format("RuleResult({0})", RuleName);

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
    }
}
