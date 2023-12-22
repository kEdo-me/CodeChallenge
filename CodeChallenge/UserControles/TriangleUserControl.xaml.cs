using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CodeChallenge.UserControles
{
    public partial class TriangleUserControl : UserControl
    {
        public TriangleUserControl()
        {
            InitializeComponent();
        }

        public void Draw(Point a, Point b, Point c, Color color, bool filled)
        {
            if (filled)
            {
                triangle.Fill = new SolidColorBrush(color);
            }
            else
            {
                triangle.Stroke = new SolidColorBrush(color);
            }

            triangle.Points = new PointCollection { a, b, c, a };
        }
    }
}
