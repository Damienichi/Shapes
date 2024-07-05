using FluentAssertions;

namespace Shapes.Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_ShouldReturnCorrectResult()
    {
        var circle = Circle.Create(5);
        var area = circle.CalculateArea();
        area.Should().Be(Math.PI * 25);
    }

    [Fact]
    public void Constructor_ShouldThrowExceptionForNonPositiveRadius()
    {
        Assert.Throws<MustBePositiveException>(() => Circle.Create(0));
    }
}