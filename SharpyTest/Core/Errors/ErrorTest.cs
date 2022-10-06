namespace SharpyTest.Core.Errors;

using Sharpy.Core.Errors;

[TestClass]
public class ErrorTest
{
    [TestMethod]
    public void TestEq()
    {
        Assert.AreEqual(new Error("a"), new Error("a"));
        Assert.AreNotEqual(new Error("a"), new Error("b"));
    }
}
