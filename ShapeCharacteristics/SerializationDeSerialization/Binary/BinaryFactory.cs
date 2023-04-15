using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristics.SerializationDeSerialization.Binary
{
    internal class BinaryFactory : IFormatFactory
    {
        public IReader CreateReader()
        {
            return new BinaryReader();
        }

        public IWriter CreateWriter()
        {
            return new BinaryWriter();
        }
    }
}
