namespace ShapeCharacteristics.Shapes.interfaces
{
    internal interface IFormatFactory
    {
        IReader CreateReader();
        IWriter CreateWriter();
    }

    public interface IReader
    {
        T Read<T>(string filePath);
    }

    public interface IWriter
    {
        void Write<T>(T obj, string filePath);
    }
}
