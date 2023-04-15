using ShapeCharacteristics.Shapes.interfaces;
using System.Xml.Serialization;

namespace ShapeCharacteristics.SerializationDeSerialization.XML
{
    internal class XmlReader : IReader
    {
        public T Read<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(fileStream);
            }
        }
    }
}
