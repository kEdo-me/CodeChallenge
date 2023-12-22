using CodeChallenge.Interfaces;

namespace CodeChallange.Primitives
{
    public class Line : BasePrimitive
    {
        public string? A { get; set; }
        public string? B { get; set; }

        public Line(IDrawStrategy strategy)
            :base(strategy)
        {

        }
    }
}
