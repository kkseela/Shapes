using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristics.SerializationDeSerialization.JSON
{
    internal class JsonFactory : IFormatFactory
    {
        public IReader CreateReader()
        {
            return new JsonReader();
        }

        public IWriter CreateWriter()
        {
            return new JsonWriter();
        }
    }
}
