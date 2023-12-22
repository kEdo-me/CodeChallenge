using CodeChallange.Primitives;
using CodeChallenge.Helpers;
using CodeChallenge.Interfaces;
using CodeChallenge.UserControles;
using System.Windows;

namespace CodeChallenge.Strategies
{
    internal class CircleDrawStrategy : IDrawStrategy
    {
        public void Draw(BasePrimitive primitive, double zoomLevel)
        {
            if (primitive is Circle circle)
            {
                var circleUserControl = new CircleUserControl();

                var color = ValueConvertionHelper.ConvertColorStringToColorStructure(circle?.Color);

                var center = ValueConvertionHelper.ConvertStringToWindowsPoint(circle?.Center);

                var scaledCenter = new Point(center.X * zoomLevel, center.Y * zoomLevel);

                circleUserControl.Draw(
                    centerX: scaledCenter.X,
                    centerY: scaledCenter.Y,
                    radius: circle.Radius * zoomLevel,
                    color: color,
                    filled: circle.Filled
                );

                circle.UserControl = circleUserControl;
            }
        }
    }
}
