using ShapeCharacteristics.Shapes.interfaces;
using System.Xml;

namespace ShapeCharacteristics.SerializationDeSerialization.XML
{
    internal class XmlFactory : IFormatFactory
    {
        public IReader CreateReader()
        {
            return new XmlReader();
        }

        public IWriter CreateWriter()
        {
            return new XmlWriter();
        }
    }
}
