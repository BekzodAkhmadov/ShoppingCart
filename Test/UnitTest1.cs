using System;
using Xunit;
namespace Test;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var actualValue = 2;
        Assert.Equal(2, actualValue);
    }
    [Fact]
    public void DoTheThing()
    {
        var x = 1;
        Assert.Equal(1, x);
    }
}
