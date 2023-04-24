using ShapeCharacteristics.SerializationDeSerialization.JSON;
using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class JsonReaderTest
    {
        [TestMethod]
        [DeploymentItem(@"IOFiles/output1.json")]
        public void Read_ValidFilePath_ReturnsDeserializedObject()
        {
            // Arrange
            IReader jsonReader = new JsonReader();
            string validFilePath = "IOFiles/output1.json";

            // Act
            MyClass actualDeserializedObject = jsonReader.Read<MyClass>(validFilePath);

            // Assert
            Assert.IsNotNull(actualDeserializedObject);
            Assert.AreEqual("value1", actualDeserializedObject.Property1);
            Assert.AreEqual(123, actualDeserializedObject.Property2);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void Read_InvalidFilePath_ThrowsFileNotFoundException()
        {
            // Arrange
            IReader jsonReader = new JsonReader();
            string invalidFilePath = @"C:\nonexistent.json";

            // Act
            jsonReader.Read<MyClass>(invalidFilePath);

            // Assert - Expects an exception to be thrown
        }
    }
}

