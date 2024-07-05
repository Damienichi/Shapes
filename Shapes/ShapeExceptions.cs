namespace Shapes;

public class MustBePositiveException(string message) : Exception(message)
{
    public static MustBePositiveException Create(string element) => new($"Ожидалось что {element} > 0");
}
public class NotValidTriangleException(string message) : Exception(message)
{
    public static NotValidTriangleException Create(double sideA, double sideB, double sideC) 
        => new($"Нельзя построить валидный треугольник по заданным сторонам: {sideA}, {sideB}, {sideC}");
}
public class ShapeIsNullException() : Exception("Фигура не должна быть null");