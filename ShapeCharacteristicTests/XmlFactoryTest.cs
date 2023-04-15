using ShapeCharacteristics.SerializationDeSerialization.XML;
using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristicTests
{
    [TestClass]
    public class XmlFactoryTest
    {
        [TestMethod]
        public void CreateReader_ReturnsXmlReaderInstance()
        {
            // Arrange
            IFormatFactory xmlFactory = new XmlFactory();

            // Act
            IReader actualReaderInstance = xmlFactory.CreateReader();

            // Assert
            Assert.IsInstanceOfType(actualReaderInstance, typeof(XmlReader));
        }

        [TestMethod]
        public void CreateWriter_ReturnsXmlWriterInstance()
        {
            // Arrange
            IFormatFactory xmlFactory = new XmlFactory();

            // Act
            IWriter actualWriterInstance = xmlFactory.CreateWriter();

            // Assert
            Assert.IsInstanceOfType(actualWriterInstance, typeof(XmlWriter));
        }
    }

}
