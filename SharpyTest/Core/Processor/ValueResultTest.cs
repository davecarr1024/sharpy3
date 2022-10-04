namespace SharpyTest.Core.Processor;

using Sharpy.Core.Processor;

[TestClass]
public class ValueResultTest
{
    [TestMethod]
    public void TestEq()
    {
        Assert.AreEqual(
            new ValueResult<int>(1),
            new ValueResult<int>(1)
        );
        Assert.AreNotEqual(
            new ValueResult<int>(1),
            new ValueResult<int>(2)
        );
    }

    [TestMethod]
    public void TestToEnumerable()
    {
        CollectionAssert.AreEqual(
            new ValueResult<int>(1).ToEnumerable().ToList(),
            new List<Result> { new ValueResult<int>(1) }
        );
    }
}
