namespace SharpyTest.Core.Processor;

using Sharpy.Core.Processor;
using Sharpy.Core.Errors;

[TestClass]
public class RefTest
{
    [TestMethod]
    public void TestApply()
    {
        Assert.AreEqual(
            new Ref<ImmutableList<int>, int>("a").Apply(
                new Scope<ImmutableList<int>, int>(
                    new Dictionary<string, Rule<ImmutableList<int>, int>> {
                        {"a", new Eq(1)},
                    }.ToImmutableDictionary()
                ),
                ImmutableList.Create<int>(1)
            ),
            (ImmutableList.Create<int>(), 1)
        );
    }
}