using ShapeCharacteristics.Shapes.interfaces;
using System.Xml;

namespace ShapeCharacteristics.SerializationDeSerialization.XML
{
    internal class XmlFactory : IFormatFactory, IFormatFactoryAsync
    {
        public IReader CreateReader()
        {
            return new XmlReader();
        }

        public IWriter CreateWriter()
        {
            return new XmlWriter();
        }

        public Task<IReader> CreateReaderAsync()
        {
            return Task.FromResult<IReader>(new XmlReader());
        }

        public Task<IWriter> CreateWriterAsync()
        {
            return Task.FromResult<IWriter>(new XmlWriter());
        }
    }

    internal interface IFormatFactoryAsync
    {
        Task<IReader> CreateReaderAsync();
        Task<IWriter> CreateWriterAsync();
    }
}
