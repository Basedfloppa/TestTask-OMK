namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateCirclePerimeter(double radius)
        {
            return Math.PI * radius * 2;
        }

        public static double CalculateRectangleArea(double side1, double side2)
        {
            return side1 * side2;
        }

        public static double CalculateRectanglePerimeter(double side1, double side2)
        {
            return (side1 + side2) * 2;
        }

        public static double CalculateSquareArea(double side) 
        {
            return side * side;
        }

        public static double CalculateSquarePerimeter(double side)
        {
            return side * 4;
        }
    }

    public class Shape
    {
        public enum ShapeType { Circle, Square, Rectangle }
        public ShapeType Type { get; private set; }
        public double[] Parameters { get; private set; }

        public Shape(ShapeType type, params double[] parameters)
        {
            Type = type;
            Parameters = parameters;
        }

        public double CalculateArea()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    return GeometryCalculator.CalculateCircleArea(Parameters[0]);
                case ShapeType.Square:
                    return GeometryCalculator.CalculateSquareArea(Parameters[0]);
                case ShapeType.Rectangle:
                    return GeometryCalculator.CalculateRectangleArea(Parameters[0], Parameters[1]);
                default:
                    throw new InvalidOperationException("Unknown shape type");
            }
        }

        public double CalculatePerimeter()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    return GeometryCalculator.CalculateCirclePerimeter(Parameters[0]);
                case ShapeType.Square:
                    return GeometryCalculator.CalculateSquarePerimeter(Parameters[0]);
                case ShapeType.Rectangle:
                    return GeometryCalculator.CalculateRectanglePerimeter(Parameters[0], Parameters[1]);
                default:
                    throw new InvalidOperationException("Unknown shape type");
            }
        }
    }
}