using ShapeCharacteristics.Shapes.interfaces;
using System.IO;
using System.Xml.Serialization;

namespace ShapeCharacteristics.SerializationDeSerialization.XML
{
    internal class XmlWriter : FileChecker, IWriter, IWriterAsync
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

        public async Task WriteAsync<T>(T obj, string filePath)
        {
            CreateDirectoryIfNotExist(filePath);
            CreateFileIfNotExist(filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextWriter writer = new StreamWriter(filePath))
            {
                await Task.Run(() => serializer.Serialize(writer, obj));
            }
        }
    }

    internal interface IWriterAsync
    {
        Task WriteAsync<T>(T obj, string filePath);
    }
}
