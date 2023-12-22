using CodeChallenge.Interfaces;

namespace CodeChallange.Primitives
{
    public class Circle : BasePrimitive
    {
        public string? Center { get; set; }
        public double Radius { get; set; }
        public Circle(IDrawStrategy drawStrategy)
            : base(drawStrategy)
        {
        }
    }
}
