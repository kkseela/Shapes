using ShapeCharacteristics.Shapes.interfaces;
using System.Xml.Serialization;

namespace ShapeCharacteristics.SerializationDeSerialization.XML
{
    internal class XmlWriter : FileChecker, IWriter
    {
        public void Write<T>(T obj, string filePath)
        {
            CreateDirectoryIfNotExist(filePath);
            CreateFileIfNotExist(filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }
    }
}
