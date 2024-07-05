namespace Shapes;

public static class AreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        if (shape is null)
            throw new ShapeIsNullException();
            
        return shape.CalculateArea();
    }
}