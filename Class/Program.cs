using GeometryLibrary;

class Program
{
    // Можно это так же всё было бы сделать с одной фронтовой реализацией
    // написать интерфейсов и сделать каждую форму отдельным классом с наследованием
    // но я думаю данный подход излишен и привёл бы к излишней сложности расширения кода в будующем
    static void Main(string[] args)
    {
        double circleArea = GeometryCalculator.CalculateCircleArea(5);
        double circlePerimeter = GeometryCalculator.CalculateCirclePerimeter(circleArea);
        Console.WriteLine("Circle Area: " + circleArea);
        Console.WriteLine("Circle Perimeter: " + circlePerimeter);

        Shape circle = new Shape(Shape.ShapeType.Circle, 5);
        double circleArea2 = circle.CalculateArea();
        double circlePerimeter2 = circle.CalculatePerimeter();
        Console.WriteLine("Circle Area (using Shape class): " + circleArea2);
        Console.WriteLine("Circle Perimeter (using Shape class): " + circlePerimeter2);

        double squareArea = GeometryCalculator.CalculateSquareArea(5);
        double squarePerimeter = GeometryCalculator.CalculateSquarePerimeter(5);
        Console.WriteLine("Square Area: " + squareArea);
        Console.WriteLine("Square Perimeter: " + squarePerimeter);


        Shape square = new Shape(Shape.ShapeType.Square, 5);
        double squareArea2 = square.CalculateArea();
        double squarePerimeter2 = square.CalculatePerimeter();
        Console.WriteLine("Square Area (using Shape class): " + squareArea2);
        Console.WriteLine("Square Perimeter (using Shape class): " + squarePerimeter2);

        double rectangleArea = GeometryCalculator.CalculateRectangleArea(5,5);
        double rectanglePerimeter = GeometryCalculator.CalculateRectanglePerimeter(5, 5);
        Console.WriteLine("Ractangle Area: " + rectangleArea);
        Console.WriteLine("Ractangle Perimeter: " + rectanglePerimeter);

        Shape rectangle = new Shape(Shape.ShapeType.Rectangle, 5, 5);
        double rectangleArea2 = rectangle.CalculateArea();
        double rectanglePerimeter2 = rectangle.CalculatePerimeter();
        Console.WriteLine("Ractangle Area (using Shape class): " + rectangleArea2);
        Console.WriteLine("Ractangle Perimeter (using Shape class): " + rectanglePerimeter2);

    }
}