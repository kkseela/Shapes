using ShapeCharacteristics.Shapes.interfaces;
using System.Runtime.Serialization.Formatters.Binary;

namespace ShapeCharacteristics.SerializationDeSerialization.Binary
{
    internal class BinaryWriter : FileChecker, IWriter
    {
        public void Write<T>(T obj, string filePath)
        {
            CreateDirectoryIfNotExist(filePath);
            CreateFileIfNotExist(filePath);
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, obj);
            }
        }
    }
}
