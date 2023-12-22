using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CodeChallenge.UserControles
{
    public partial class LineUserControl : UserControl
    {
        public LineUserControl()
        {
            InitializeComponent();
        }
        public void Draw(Point startPoint, Point endPoint, Color color)
        {
            line.X1 = startPoint.X;
            line.Y1 = startPoint.Y;
            line.X2 = endPoint.X;
            line.Y2 = endPoint.Y;
            line.Stroke = new SolidColorBrush(color);
        }
    }
}
