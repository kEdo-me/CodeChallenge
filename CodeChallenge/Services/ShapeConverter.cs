using CodeChallange.Primitives;
using CodeChallenge.Strategies;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeChallenge.DataReader.Services
{
    internal class ShapeConverter : JsonConverter<BasePrimitive>
    {
        public override BasePrimitive? ReadJson(JsonReader reader, Type objectType, BasePrimitive? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);

            string? shapeType = jsonObject["type"]?.ToString();
            if (shapeType == null)
            {
                throw new NotSupportedException($"Unknown shape type: {shapeType}");
            }

            BasePrimitive? shape = null;
            switch (shapeType)
            {
                case "line":
                    shape = jsonObject.ToObject<Line>();
                    shape?.SetDrawStrategy(new LineDrawStrategy());
                    break;
                case "circle":
                    shape = jsonObject.ToObject<Circle>();
                    shape?.SetDrawStrategy(new CircleDrawStrategy());
                    break;
                case "triangle":
                    shape = jsonObject.ToObject<Triangle>();
                    shape?.SetDrawStrategy(new TriangleDrawStrategy());
                    break;
            }
            return shape;
        }

        public override void WriteJson(JsonWriter writer, BasePrimitive? value, JsonSerializer serializer)
        {

        }
    }
}
