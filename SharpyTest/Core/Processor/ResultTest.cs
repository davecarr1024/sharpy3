using NUnit.Framework;

namespace SharpyTest;

using System.Collections.Generic;
using System.Linq;
using Sharpy.Core.Processor;

public class ResultTest
{
    [Test]
    public void TestNeq()
    {
        Assert.AreNotEqual(
            new Result(new List<Result> { }),
            new Result(new List<Result> { new Result(new List<Result> { }) })
        );
    }

    [Test]
    public void TestEq()
    {
        Assert.AreEqual(
            new Result(new List<Result> { }).ToEnumerable(),
            new Result(new List<Result> { }).ToEnumerable()
        );
    }

    [Test]
    public void TestToEnumerable()
    {
        Assert.AreEqual(
            new Result(new List<Result>{
                new RuleResult("a"),
                new RuleResult("b"),
            }).ToEnumerable(),
            new List<Result>() {
                new Result(new List<Result>{
                new RuleResult("a"),
                new RuleResult("b"),
            }),
            new RuleResult("a"),
            new RuleResult("b"),
            }
        );
    }

    [Test]
    public void TestLinq()
    {
        Assert.AreEqual(
            new Result(new List<Result>{
                new RuleResult("a"),
                new ValueResult<int>(1),
            }).ToEnumerable().OfType<ValueResult<int>>().First(),
            new ValueResult<int>(1)
        );
        Assert.AreEqual(
            new Result(new List<Result>{
                new RuleResult("a", new List<Result>{new ValueResult<int>(1)}),
                new RuleResult("b", new List<Result>{new ValueResult<int>(2)}),
            })
            .ToEnumerable()
            .OfType<RuleResult>()
            .Where(result => result.RuleName == "a")
            .First(),
            new RuleResult("a", new List<Result> { new ValueResult<int>(1) })
        );
    }
}