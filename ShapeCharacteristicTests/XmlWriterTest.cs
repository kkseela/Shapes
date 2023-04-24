using ShapeCharacteristics.SerializationDeSerialization.XML;
using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class XmlWriterTests
    {
        [TestMethod]
        [DeploymentItem(@"IOFiles/output2.xml")]
        public void Write_ValidObjectAndFilePath_WritesToFile()
        {
            // Arrange
            IWriter xmlWriter = new XmlWriter();
            MyClass myObject = new MyClass() { Property1 = "value1", Property2 = 123 };
            string validFilePath = "IOFiles\\output2.xml";

            // Act
            xmlWriter.Write(myObject, validFilePath);

            // Assert
            Assert.IsTrue(File.Exists(validFilePath));
        }
    }

    public class MyClass
    {
        public string Property1 { get; set;}

        public int Property2 { get; set;}
    }

}
