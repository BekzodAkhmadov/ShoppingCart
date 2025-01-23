using System;
using Xunit;
namespace Test;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var actualValue = 3;
        Assert.Equal(3, actualValue);
    }
    [Fact]
    public void DoTheThing()
    {
        var x = 1;
        Assert.Equal(1, x);
    }
}
