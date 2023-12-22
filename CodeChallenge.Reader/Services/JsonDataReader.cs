using CodeChallange.Models.Primitives;
using CodeChallenge.DataReader.Interfaces;
using Newtonsoft.Json;

namespace CodeChallenge.DataReader.Services
{
    public class JsonDataReader : IJsonDataReader
    {
        public List<BasePrimitive>? ReadData(string path)
        {
            string data = System.IO.File.ReadAllText(path);

            return JsonConvert.DeserializeObject<List<BasePrimitive>>(data, new ShapeConverter());
        }
    }
}
