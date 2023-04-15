using ShapeCharacteristics.Shapes.interfaces;
using Newtonsoft.Json;

namespace ShapeCharacteristics.SerializationDeSerialization.JSON
{
    internal class JsonWriter : FileChecker, IWriter
    {
        public void Write<T>(T obj, string filePath)
        {
            CreateDirectoryIfNotExist(filePath);
            CreateFileIfNotExist(filePath);
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }
    }
}
