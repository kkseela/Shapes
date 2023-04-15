using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;
using ShapeCharacteristics.Shapes;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalculateShapeParameters_For_Triangle_ValidInput_ReturnsCorrectShapeData()
        {
            // Arrange
            IShape triangle = new Triangle();
            TriangleParams triangleParams = new TriangleParams(20.2, 40);
            Shape expectedShapeData = new Shape("Triangle", 105.01115932443614, 404.0);

            // Act
            Shape actualShapeData = triangle.CalculateShapeParameters(triangleParams);

            // Assert
            Assert.AreEqual(expectedShapeData.Name, actualShapeData.Name);
            Assert.AreEqual(expectedShapeData.Perimeter, actualShapeData.Perimeter);
            Assert.AreEqual(expectedShapeData.SurfaceArea, actualShapeData.SurfaceArea);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculateShapeParameters_For_Triangle_InvalidInput_ThrowsNotSupportedException()
        {
            // Arrange
            IShape triangle = new Triangle();
            SquareParams squareParams = new SquareParams(5);

            // Act
            triangle.CalculateShapeParameters(squareParams);

            // Assert - Expects an exception to be thrown
        }
    }
}
