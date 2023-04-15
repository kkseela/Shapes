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
            TriangleParams triangleParams = new TriangleParams(20.2, 40, 20.4);
            Shape expectedShapeData = new Shape("Triangle", 80.6, 69.54048533048898);

            // Act
            Shape actualShapeData = triangle.CalculateShapeParameters(triangleParams);

            // Assert
            Assert.AreEqual(expectedShapeData.Name, actualShapeData.Name);
            Assert.AreEqual(expectedShapeData.Perimeter, actualShapeData.Perimeter);
            Assert.AreEqual(expectedShapeData.SurfaceArea, actualShapeData.SurfaceArea);
        }

        [TestMethod]
        public void CalculateShapeParameters_For_EquilateralTriangle_ValidInput_ReturnsCorrectShapeData()
        {
            // Arrange
            IShape triangle = new Triangle();
            TriangleParams triangleParams = new TriangleParams(20, 20, 20);
            Shape expectedShapeData = new Shape("Equilateral Triangle", 60, 173.2050807568877);

            // Act
            Shape actualShapeData = triangle.CalculateShapeParameters(triangleParams);

            // Assert
            Assert.AreEqual(expectedShapeData.Name, actualShapeData.Name);
            Assert.AreEqual(expectedShapeData.Perimeter, actualShapeData.Perimeter);
            Assert.AreEqual(expectedShapeData.SurfaceArea, actualShapeData.SurfaceArea);
        }

        [TestMethod]
        public void CalculateShapeParameters_For_IsoscelesTriangle_ValidInput_ReturnsCorrectShapeData()
        {
            // Arrange
            IShape triangle = new Triangle();
            TriangleParams triangleParams = new TriangleParams(20.4, 40, 20.4);
            Shape expectedShapeData = new Shape("Isosceles Triangle", 80.8, 80.39900496896698);

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
