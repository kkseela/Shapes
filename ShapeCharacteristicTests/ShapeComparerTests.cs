using ShapeCharacteristics.Shapes.ShapeComparer;
using ShapeCharacteristics.Shapes;
using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;
using System.Drawing;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class ShapeComparerTests
    {
        [TestMethod]
        public void SortBySurfaceArea_ShouldSortShapesBySurfaceArea()
        {
            // Arrange
            var comparer = new ShapeComparer { SortByProperty = ShapeComparer.SortBy.SurfaceArea };
            IShape shape1 = new Triangle();
            TriangleParams shape1Params = new TriangleParams(20.4, 40, 20.4);
            IShape shape2 = new Square();
            SquareParams shape2Params = new SquareParams(40);
            IShape shape3 = new Square();
            SquareParams shape3Params = new SquareParams(80);

            
            Shape actualShap1 = shape1.CalculateShapeParameters(shape1Params);
            Shape actualShape2 = shape2.CalculateShapeParameters(shape2Params);
            Shape actualShape3 = shape2.CalculateShapeParameters(shape3Params);
            var shapes = new List<Shape> { actualShap1, actualShape2, actualShape3};

            // Act
            shapes.Sort(comparer);


            // Assert
            Assert.AreEqual("Isosceles Triangle", shapes[0].Name);
            Assert.AreEqual("Square", shapes[1].Name);
            Assert.AreEqual("Square", shapes[2].Name);
        }

        [TestMethod]
        public void SortByPerimeter_ShouldSortShapesByPerimeter()
        {
            // Arrange
            var comparer = new ShapeComparer { SortByProperty = ShapeComparer.SortBy.Perimeter };
            IShape shape1 = new Triangle();
            TriangleParams shape1Params = new TriangleParams(20.4, 40, 20.4);
            IShape shape2 = new Square();
            SquareParams shape2Params = new SquareParams(40);
            IShape shape3 = new Square();
            SquareParams shape3Params = new SquareParams(80);


            Shape actualShap1 = shape1.CalculateShapeParameters(shape1Params);
            Shape actualShape2 = shape2.CalculateShapeParameters(shape2Params);
            Shape actualShape3 = shape2.CalculateShapeParameters(shape3Params);
            var shapes = new List<Shape> { actualShap1, actualShape2, actualShape3 };

            // Act
            shapes.Sort(comparer);


            // Assert
            Assert.AreEqual("Isosceles Triangle", shapes[0].Name);
            Assert.AreEqual("Square", shapes[1].Name);
            Assert.AreEqual("Square", shapes[2].Name);
        }
    }
}
