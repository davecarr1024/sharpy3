namespace SharpyTest.Core.Errors;

using Sharpy.Core.Errors;

[TestClass]
public class RuleErrorTest
{
    [TestMethod]
    public void TestEq()
    {
        Assert.AreEqual(new RuleError("a", new Error("e")), new RuleError("a", new Error("e")));
        Assert.AreNotEqual(new RuleError("a", new Error("e")), new RuleError("b", new Error("e")));
        Assert.AreNotEqual(new RuleError("a", new Error("e")), new RuleError("a", new Error("f")));
    }
}
