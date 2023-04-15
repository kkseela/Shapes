using ShapeCharacteristics.Shapes;
using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapeBasedRecords;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class RectangleTest
    {

        [TestMethod]
        public void CalculateShapeParameters_For_Rectangle_With_ValidInput_ReturnsCorrectShapeData()
        {
            // Arrange
            IShape rectangle = new Rectangle();
            RectangleParams rectParams = new RectangleParams(20.2, 40);
            Shape expectedShapeData = new Shape("Rectangle", 120.4, 808.0);

            // Act
            Shape actualShapeData = rectangle.CalculateShapeParameters(rectParams);

            // Assert
            Assert.AreEqual(expectedShapeData.Name, actualShapeData.Name);
            Assert.AreEqual(expectedShapeData.Perimeter, actualShapeData.Perimeter);
            Assert.AreEqual(expectedShapeData.SurfaceArea, actualShapeData.SurfaceArea);
        }

        [TestMethod]
        public void CalculateShapeParameters_For_Square_In_Rectangle_With_ValidInput_ReturnsCorrectShapeData()
        {
            // Arrange
            IShape rectangle = new Rectangle();
            RectangleParams rectParams = new RectangleParams(40,40);
            Shape expectedShapeData = new Shape("Square", 160.0, 1600.0);

            // Act
            Shape actualShapeData = rectangle.CalculateShapeParameters(rectParams);

            // Assert
            Assert.AreEqual(expectedShapeData.Name, actualShapeData.Name);
            Assert.AreEqual(expectedShapeData.Perimeter, actualShapeData.Perimeter);
            Assert.AreEqual(expectedShapeData.SurfaceArea, actualShapeData.SurfaceArea);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculateShapeParameters_For_Rectangle_With_InvalidInput_ThrowsNotSupportedException()
        {
            // Arrange
            IShape rectangle = new Rectangle();
            CircleParams squareParams = new CircleParams(5);

            // Act
            rectangle.CalculateShapeParameters(squareParams);

            // Assert - Expects an exception to be thrown
        }
    }
}
