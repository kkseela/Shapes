using ShapeCharacteristics.SerializationDeSerialization.JSON;
using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class JsonFactoryTest
    {
        [TestMethod]
        public void CreateReader_ReturnsJsonReaderInstance()
        {
            // Arrange
            IFormatFactory jsonFactory = new JsonFactory();

            // Act
            IReader actualReaderInstance = jsonFactory.CreateReader();

            // Assert
            Assert.IsInstanceOfType(actualReaderInstance, typeof(JsonReader));
        }

        [TestMethod]
        public void CreateWriter_ReturnsJsonWriterInstance()
        {
            // Arrange
            IFormatFactory jsonFactory = new JsonFactory();

            // Act
            IWriter actualWriterInstance = jsonFactory.CreateWriter();

            // Assert
            Assert.IsInstanceOfType(actualWriterInstance, typeof(JsonWriter));
        }
    }
}
