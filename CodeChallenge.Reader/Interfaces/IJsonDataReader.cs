using CodeChallange.Models.Primitives;

namespace CodeChallenge.DataReader.Interfaces
{
    public interface IJsonDataReader
    {
        public List<BasePrimitive>? ReadData(string json);
    }
}
