using CodeChallange.Primitives;

namespace CodeChallenge.Interfaces
{
    public interface IDrawStrategy
    {
        void Draw(BasePrimitive primitive, double zoomLevel);
    }
}
