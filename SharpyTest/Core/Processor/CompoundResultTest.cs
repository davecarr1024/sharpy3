namespace SharpyTest.Core.Processor;

using Sharpy.Core.Processor;

[TestClass]
public class CompoundResultTest
{
    [TestMethod]
    public void TestEq()
    {
        Assert.AreEqual(
            new CompoundResult(new NameResult("a")),
            new CompoundResult(new NameResult("a"))
        );
        Assert.AreNotEqual(
            new CompoundResult(new NameResult("a")),
            new CompoundResult(new NameResult("b"))
        );
    }

    [TestMethod]
    public void TestToEnumerable()
    {
        CollectionAssert.AreEqual(
            new CompoundResult(new NameResult("a")).ToEnumerable().ToList(),
            new List<Result> { new CompoundResult(new NameResult("a")), new NameResult("a") }
        );
    }
}
