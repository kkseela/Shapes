using ShapeCharacteristics.SerializationDeSerialization.XML;
using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class XmlReaderTest
    {
        [TestMethod]
        [DeploymentItem(@"IOFiles/output1.xml")]
        public void Read_ValidFilePath_ReturnsDeserializedObject()
        {
            // Arrange
            IReader xmlReader = new XmlReader();
            string validFilePath = "IOFiles/output1.xml";

            // Act
            MyClass actualDeserializedObject = xmlReader.Read<MyClass>(validFilePath);

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
            IReader xmlReader = new XmlReader();
            string invalidFilePath = @"C:\nonexistent.xml";

            // Act
            xmlReader.Read<MyClass>(invalidFilePath);

            // Assert - Expects an exception to be thrown
        }
    }

}
