using FluentAssertions;

namespace Shapes.Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_ShouldReturnCorrectResult()
    {
        var triangle = new Triangle(3, 4, 5);
        var area = triangle.CalculateArea();
        area.Should().Be(6);
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnTrueForRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        triangle.IsRightTriangle().Should().Be(true);
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnFalseForNonRightTriangle()
    {
        var triangle = new Triangle(3, 4, 6);
        triangle.IsRightTriangle().Should().Be(false);
    }

    [Fact]
    public void Constructor_ShouldThrowExceptionForInvalidTriangle()
    {
        Assert.Throws<NotValidTriangleException>(() => Triangle.Create(1, 1, 3));
    }
}