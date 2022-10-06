namespace SharpyTest.Core.Processor;

using Sharpy.Core.Processor;
using Sharpy.Core.Errors;

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

    [TestMethod]
    [ExpectedException(typeof(Error))]
    public void TestApplyEmpty()
    {
        new Eq { Value = 1 }
            .Apply(
                new Scope(ImmutableDictionary.Create<string, Rule<ImmutableList<int>, int>>()),
                ImmutableList.Create<int>()
            );
    }


    [TestMethod]
    [ExpectedException(typeof(Error))]
    public void TestApplyMismatch()
    {
        new Eq { Value = 1 }
            .Apply(
                new Scope(ImmutableDictionary.Create<string, Rule<ImmutableList<int>, int>>()),
                ImmutableList.Create<int>(2)
            );
    }
}
