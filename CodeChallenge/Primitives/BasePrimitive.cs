using CodeChallenge.Interfaces;
using System.Windows.Controls;

namespace CodeChallange.Primitives
{
    public class BasePrimitive
    {
        public string? Type { get; set; }
        public bool Filled { get; set; }
        public string? Color { get; set; }

        private IDrawStrategy drawStrategy;
        public UserControl UserControl { get; set; }

        public BasePrimitive(IDrawStrategy drawStrategy)
        {
            this.drawStrategy = drawStrategy;
            this.UserControl = new UserControl();
        }

        public void SetDrawStrategy(IDrawStrategy drawStrategy)
        {
            this.drawStrategy = drawStrategy;
        }

        public virtual void Draw(double zoomLevel)
        {
            drawStrategy.Draw(this, zoomLevel);
        }
    }
}
