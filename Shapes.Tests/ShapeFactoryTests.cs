using FluentAssertions;

namespace Shapes.Tests;

public class ShapeFactoryTests
{
    [Fact]
    public void CreateCircle_ShouldReturnCircleInstance()
    {
        var shape = ShapeFactory.CreateCircle(5);
        shape.Should().BeOfType<Circle>();
    }

    [Fact]
    public void CreateTriangle_ShouldReturnTriangleInstance()
    {
        var shape = ShapeFactory.CreateTriangle(3, 4, 5);
        shape.Should().BeOfType<Triangle>();
    }
}