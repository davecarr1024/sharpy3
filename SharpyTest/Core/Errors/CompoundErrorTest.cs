namespace SharpyTest.Core.Errors;

using Sharpy.Core.Errors;

[TestClass]
public class CompoundErrorTest
{
    [TestMethod]
    public void TestEq()
    {
        Assert.AreEqual(
            new CompoundError(ImmutableList.Create<Error>()),
            new CompoundError(ImmutableList.Create<Error>())
        );
        Assert.AreEqual(
            new CompoundError(ImmutableList.Create<Error>(new Error("a"))),
            new CompoundError(ImmutableList.Create<Error>(new Error("a")))
        );
        Assert.AreNotEqual(
            new CompoundError(ImmutableList.Create<Error>(new Error("a"))),
            new CompoundError(ImmutableList.Create<Error>(new Error("b")))
        );
        Assert.AreNotEqual(
            new CompoundError(ImmutableList.Create<Error>(new Error("a"))),
            new CompoundError(ImmutableList.Create<Error>())
        );
    }
}
