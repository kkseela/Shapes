using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;
using ShapeCharacteristics.Shapes;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void CalculateShapeParameters_For_Square_ValidInput_ReturnsCorrectShapeData()
        {
            // Arrange
            IShape square = new Square();
            SquareParams squareParams = new SquareParams(40);
            Shape expectedShapeData = new Shape("Square", 160.0, 1600.0);

            // Act
            Shape actualShapeData = square.CalculateShapeParameters(squareParams);

            // Assert
            Assert.AreEqual(expectedShapeData.Name, actualShapeData.Name);
            Assert.AreEqual(expectedShapeData.Perimeter, actualShapeData.Perimeter);
            Assert.AreEqual(expectedShapeData.SurfaceArea, actualShapeData.SurfaceArea);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculateShapeParameters_For_Square_InvalidInput_ThrowsNotSupportedException()
        {
            // Arrange
            IShape square = new Square();
            CircleParams circleParams = new CircleParams(5);

            // Act
            square.CalculateShapeParameters(circleParams);

            // Assert - Expects an exception to be thrown
        }
    }
}
