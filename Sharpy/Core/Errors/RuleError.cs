namespace Sharpy.Core.Errors
{
    public class RuleError : Error
    {
        public string RuleName { get; init; }

        public Error Child { get; init; }

        public RuleError(string ruleName, Error child) : base() => (RuleName, Child) = (ruleName, child);

        public override bool Equals(object? obj) => obj is RuleError error && RuleName == error.RuleName && Child.Equals(error.Child) && base.Equals(obj);

        public override int GetHashCode() => HashCode.Combine(RuleName, Child.GetHashCode(), base.GetHashCode());
    }
}