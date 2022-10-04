namespace SharpyTest.Core.Processor;

using Sharpy.Core.Processor;

[TestClass]
public class NameResultTest
{
    [TestMethod]
    public void TestEq()
    {
        Assert.AreEqual(
            new NameResult("a"),
            new NameResult("a")
        );
        Assert.AreNotEqual(
            new NameResult("a"),
            new NameResult("b")
        );
    }

    [TestMethod]
    public void TestToEnumerable()
    {
        CollectionAssert.AreEqual(
            new NameResult("a").ToEnumerable().ToList(),
            new List<Result> { new NameResult("a") }
        );
    }
}
