namespace Shapes;

public static class ShapeFactory
{
    public static IShape CreateCircle(double radius) => Circle.Create(radius);
    public static IShape CreateTriangle(double sideA, double sideB, double sideC) => Triangle.Create(sideA, sideB, sideC);
}