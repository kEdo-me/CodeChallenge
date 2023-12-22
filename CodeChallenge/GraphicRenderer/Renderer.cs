using CodeChallange.Primitives;
using System.Windows.Controls;

namespace CodeChallenge.GraphicRenderer
{
    public class Renderer
    {
        private double zoomLevel = 1.0;

        public double ZoomLevel
        {
            get { return zoomLevel; }
            set
            {
                if (value > 0.0)
                {
                    zoomLevel = value;
                }
            }
        }
        public void ZoomIn()
        {
            ZoomLevel *= 1.2;
        }

        public void ZoomOut()
        {
            ZoomLevel /= 1.2; 
        }
        public void Render(List<BasePrimitive> primitives, Panel container)
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw(zoomLevel);

                container.Children.Add(primitive.UserControl);
            }
        }
    }
}
