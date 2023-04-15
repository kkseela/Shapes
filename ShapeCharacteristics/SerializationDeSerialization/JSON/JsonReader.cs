using Newtonsoft.Json;
using ShapeCharacteristics.Shapes.interfaces;

namespace ShapeCharacteristics.SerializationDeSerialization.JSON
{
    internal class JsonReader : IReader
    {
        public T Read<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            return JsonConvert.DeserializeObject<T>(jsonString, settings);
        }
    }
}
