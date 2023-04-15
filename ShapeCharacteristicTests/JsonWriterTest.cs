using ShapeCharacteristics.SerializationDeSerialization.JSON;
using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class JsonWriterTest
    {
        [TestMethod]
        [DeploymentItem(@"IOFiles\output2.json")]
        public void Write_ValidObjectAndFilePath_WritesToFile()
        {
            // Arrange
            IWriter xmlWriter = new JsonWriter();
            MyClass myObject = new MyClass() { Property1 = "value1", Property2 = 123 };
            string validFilePath = "IOFiles\\output2.json";

            // Act
            xmlWriter.Write(myObject, validFilePath);

            // Assert
            Assert.IsTrue(File.Exists(validFilePath));
        }
    }
}
