namespace Shapes;

public record Triangle(double SideA, double SideB, double SideC) : IShape
{
    public static Triangle Create(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw MustBePositiveException.Create("стороны");
        if (!IsValidTriangle(sideA, sideB, sideC))
            throw NotValidTriangleException.Create(sideA, sideB, sideC);
        
        return new Triangle(sideA, sideB, sideC);
    }

    private static bool IsValidTriangle(double a, double b, double c) => a + b > c && a + c > b && b + c > a;

    public double CalculateArea()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public bool IsRightTriangle()
    {
        double[] sides = [SideA, SideB, SideC];
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
}