using CodeChallange.Models.Primitives;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeChallenge.DataReader.Services
{
    internal class ShapeConverter : JsonConverter<BasePrimitive>
    {
        public override BasePrimitive? ReadJson(JsonReader reader, Type objectType, BasePrimitive? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);

            switch (jsonObject["type"]?.ToString())
            {
                case "line":
                    return jsonObject.ToObject<Line>();
                case "circle":
                    return jsonObject.ToObject<Circle>();
                case "triangle":
                    return jsonObject.ToObject<Triangle>();
                default:
                    throw new NotSupportedException($"Unknown shape type: {jsonObject["type"]}");
            }
        }

        public override void WriteJson(JsonWriter writer, BasePrimitive? value, JsonSerializer serializer)
        {

        }
    }
}
