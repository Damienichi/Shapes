namespace Shapes;

public record Circle(double Radius) : IShape
{
    public static Circle Create(double radius)
    {
        if (radius <= 0)
           throw MustBePositiveException.Create("радиус");
        
        return new Circle(radius);
    }

    public double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
}