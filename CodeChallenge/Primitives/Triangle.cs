using CodeChallenge.Interfaces;

namespace CodeChallange.Primitives
{
    public class Triangle : BasePrimitive
    {
        public string? A { get; set; }
        public string? B { get; set; }
        public string? C { get; set; }

        public Triangle(IDrawStrategy drawStrategy)
            : base(drawStrategy)
        {
        }
    }
}
