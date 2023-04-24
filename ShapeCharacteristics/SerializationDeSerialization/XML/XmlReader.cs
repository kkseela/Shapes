using ShapeCharacteristics.Shapes.interfaces;
using System.Xml;
using System.Xml.Serialization;

namespace ShapeCharacteristics.SerializationDeSerialization.XML
{
    internal class XmlReader : IReader, IXmlReaderAsync
    {
        public T Read<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(fileStream);
            }
        }

        public async Task<T> ReadAsync<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return await Task.Run(() => (T)serializer.Deserialize(fileStream));
            }
        }
    }

    internal interface IXmlReaderAsync
    {
        Task<T> ReadAsync<T>(string filePath);
    }
}
