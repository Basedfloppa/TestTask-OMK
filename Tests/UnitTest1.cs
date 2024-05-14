using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryLibraryTests
{
    [TestClass]
    public class GeometryCalculatorTests
    {
        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void TestCalculateCircleArea(double radius)
        {
            double expectedArea = Math.PI * radius * radius;
            double actualArea = GeometryCalculator.CalculateCircleArea(radius);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void TestCalculateCirclePerimeter(double radius)
        {
            double expectedPerimeter = Math.PI * 2 * radius;
            double actualPerimeter = GeometryCalculator.CalculateCirclePerimeter(radius);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void TestCalculateSquareArea(double side)
        {
            double expectedArea = side * side;
            double actualArea = GeometryCalculator.CalculateSquareArea(side);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void TestCalculateSquarePerimeter(double side)
        {
            double expectedPerimeter = side * 4;
            double actualPerimeter = GeometryCalculator.CalculateSquarePerimeter(side);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        [DataRow(5,5)]
        [DataRow(10,10)]
        [DataRow(0,0)]
        [DataRow(6,6)]
        [DataRow(8,8)]
        public void TestCalculateRectangleArea(double side1, double side2)
        {
            double expectedArea = side1 * side2;
            double actualArea = GeometryCalculator.CalculateRectangleArea(side1,side2);
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [DataRow(5, 5)]
        [DataRow(10, 10)]
        [DataRow(0, 0)]
        [DataRow(6, 6)]
        [DataRow(8, 8)]
        public void TestCalculateRectanglePerimeter(double side1, double side2)
        {
            double expectedPerimeter = 2 * (side1 + side2);
            double actualPerimeter = GeometryCalculator.CalculateRectanglePerimeter(side1, side2);
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }

    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void TestCalculateCircleAreaWithShapeClass(double radius)
        {
            double expectedArea = Math.PI * radius * radius;
            Shape circle = new Shape(Shape.ShapeType.Circle, radius);
            double actualArea = circle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void TestCalculateCirclePerimeterWithShapeClass(double radius)
        {
            double expectedPerimeter = Math.PI * 2 * radius;
            Shape circle = new Shape(Shape.ShapeType.Circle, radius);
            double actualPerimeter = circle.CalculatePerimeter();
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void TestCalculateSquareAreaWithShapeClass(double side)
        {
            double expectedArea = side * side;
            Shape square = new Shape(Shape.ShapeType.Square, side);
            double actualArea = square.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(0)]
        [DataRow(6)]
        [DataRow(8)]
        public void TestCalculateSquarePerimeterWithShapeClass(double side)
        {
            double expectedPerimeter = 4 * side;
            Shape square = new Shape(Shape.ShapeType.Square, side);
            double actualPerimeter = square.CalculatePerimeter();
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestMethod]
        [DataRow(5, 5)]
        [DataRow(10, 10)]
        [DataRow(0, 0)]
        [DataRow(6, 6)]
        [DataRow(8, 8)]
        public void TestCalculateRectangleAreaWithShapeClass(double side1, double side2)
        {
            double expectedArea = side1 * side2;
            Shape rectangle = new Shape(Shape.ShapeType.Rectangle, side1, side2);
            double actualArea = rectangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        [DataRow(5, 5)]
        [DataRow(10, 10)]
        [DataRow(0, 0)]
        [DataRow(6, 6)]
        [DataRow(8, 8)]
        public void TestCalculateRectanglePerimeterWithShapeClass(double side1, double side2)
        {
            double expectedPerimeter = 2 * (side1 + side2);
            Shape rectangle = new Shape(Shape.ShapeType.Rectangle, side1, side2);
            double actualPerimeter = rectangle.CalculatePerimeter();
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }
    }
}