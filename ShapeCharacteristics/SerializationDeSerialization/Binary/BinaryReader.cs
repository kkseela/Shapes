using ShapeCharacteristics.Shapes.interfaces;
using System.Runtime.Serialization.Formatters.Binary;

namespace ShapeCharacteristics.SerializationDeSerialization.Binary
{
    internal class BinaryReader : IReader
    {
        public T Read<T>(string filePath)
        {
            byte[] data = File.ReadAllBytes(filePath);
            BinaryFormatter formatter = new BinaryFormatter();

            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                return (T)formatter.Deserialize(memoryStream);
            }
        }
    }
}
