using ShapeCharacteristics.Shapes.interfaces;
using ShapeCharacteristics.Shapes.ShapesCreator;
using ShapeCharacteristics.Shapes;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class ShapeFactoryTest
    {
        [TestMethod]
        public void ShapeInstanceCreator_ValidShapeType_ReturnsCorrectShapeInstance()
        {
            // Arrange
            ShapeFactory shapeFactory = new ShapeFactory();
            string shapeType = "circle";

            // Act
            IShape actualShapeInstance = shapeFactory.ShapeInstanceCreator(shapeType);

            // Assert
            Assert.IsInstanceOfType(actualShapeInstance, typeof(Circle));
        }

        [TestMethod]
        public void GetInstanceDetails_MultipleInstances_ReturnsCorrectInstanceCount()
        {
            // Arrange
            ShapeFactory shapeFactory = new ShapeFactory();
            string shapeType = "circle";

            // Act
            shapeFactory.ShapeInstanceCreator(shapeType);
            shapeFactory.ShapeInstanceCreator(shapeType);
            shapeFactory.ShapeInstanceCreator("triangle");
            Dictionary<string, int> actualInstanceCount = shapeFactory.GetInstanceDetails();

            // Assert
            Assert.AreEqual(2, actualInstanceCount[shapeType]);
            Assert.AreEqual(1, actualInstanceCount["triangle"]);
            Assert.IsFalse(actualInstanceCount.ContainsKey("invalid"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShapeInstanceCreator_InvalidShapeType_ThrowsArgumentException()
        {
            // Arrange
            ShapeFactory shapeFactory = new ShapeFactory();
            string shapeType = "invalid";

            // Act
            shapeFactory.ShapeInstanceCreator(shapeType);

            // Assert - Expects an exception to be thrown
        }
    }

}
