namespace SharpyTest.Core.Processor.IntMatcher;

using Sharpy.Core.Processor;

[TestClass]
public class EqTest
{
    [TestMethod]
    public void TestApply()
    {
        Assert.AreEqual(
            new Eq { Value = 1 }.Apply(
                new Scope(ImmutableDictionary.Create<string, Rule<ImmutableList<int>, int>>()),
                ImmutableList.Create<int>(1)
            ),
            (ImmutableList.Create<int>(), 1)
        );
    }
}
