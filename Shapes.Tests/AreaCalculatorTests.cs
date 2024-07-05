using FluentAssertions;

namespace Shapes.Tests;

public class AreaCalculatorTests
{
    [Fact]
    public void CalculateArea_ShouldReturnCorrectResultForCircle()
    {
        var circle = new Circle(5);
        var area = AreaCalculator.CalculateArea(circle);
        area.Should().Be(Math.PI * 25);
    }

    [Fact]
    public void CalculateArea_ShouldReturnCorrectResultForTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        var area = AreaCalculator.CalculateArea(triangle);
        area.Should().Be(6);
    }

    [Fact]
    public void CalculateArea_ShouldThrowExceptionForNullShape()
    {
        Assert.Throws<MustBePositiveException>(() => AreaCalculator.CalculateArea(null));
    }
}