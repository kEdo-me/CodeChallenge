using System.Windows.Controls;
using System.Windows.Media;

namespace CodeChallenge.UserControles
{
    public partial class CircleUserControl : UserControl
    {
        public CircleUserControl()
        {
            InitializeComponent();
        }

        public void Draw(double centerX, double centerY, double radius, bool filled, Color color)
        {
            circleEllipse.Width = 2 * radius;
            circleEllipse.Height = 2 * radius;
            circleEllipse.Fill = new SolidColorBrush(color);
            circleEllipse.Stroke = new SolidColorBrush(color);
            circleEllipse.StrokeThickness = 1;

            if (filled)
                circleEllipse.Fill = new SolidColorBrush(color);
            else
                circleEllipse.Fill = Brushes.Transparent;

            Canvas.SetLeft(this, centerX - radius);
            Canvas.SetTop(this, centerY - radius);
        }

    }
}
