using HandsOn12;

using FluentAssertions;
using Xunit;


public class TestBasic
{
    [Fact]
    public void adding_3_and_4()
    {
        BasicMath.add(3.0, 4.0).Should().Be(7.0);
    }
}
