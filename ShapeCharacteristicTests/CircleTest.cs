using ShapeCharacteristics.Shapes;
using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateShapeParameters_For_Circle_ValidInput_ReturnsCorrectShapeData()
        {
            // Arrange
            IShape circle = new Circle();
            CircleParams circleParams = new CircleParams(5);
            Shape expectedShapeData = new Shape("Circle", 31.41592653589793, 78.53981633974483);

            // Act
            Shape actualShapeData = circle.CalculateShapeParameters(circleParams);

            // Assert
            Assert.AreEqual(expectedShapeData.Name, actualShapeData.Name);
            Assert.AreEqual(expectedShapeData.Perimeter, actualShapeData.Perimeter);
            Assert.AreEqual(expectedShapeData.SurfaceArea, actualShapeData.SurfaceArea);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculateShapeParameters_For_Circle_InvalidInput_ThrowsNotSupportedException()
        {
            // Arrange
            IShape circle = new Circle();
            SquareParams squareParams = new SquareParams(5);

            // Act
            circle.CalculateShapeParameters(squareParams);

            // Assert - Expects an exception to be thrown
        }
    }

}