using CodeChallange.Primitives;

namespace CodeChallenge.Interfaces
{
    public interface IJsonDataReader
    {
        public List<BasePrimitive>? ReadData(string json);
    }
}
