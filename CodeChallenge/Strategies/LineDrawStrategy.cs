using CodeChallange.Primitives;
using CodeChallenge.Helpers;
using CodeChallenge.Interfaces;
using CodeChallenge.UserControles;
using System.Windows;

namespace CodeChallenge.Strategies
{
    internal class LineDrawStrategy : IDrawStrategy
    {
        public void Draw(BasePrimitive primitive, double zoomLevel)
        {
            if (primitive is Line line)
            {
                var lineUserControl = new LineUserControl();

                var color = ValueConvertionHelper.ConvertColorStringToColorStructure(line?.Color);

                var pointA = ValueConvertionHelper.ConvertStringToWindowsPoint(line?.A);
                var pointB = ValueConvertionHelper.ConvertStringToWindowsPoint(line?.B);

                var scaledA = new Point(pointA.X * zoomLevel, pointA.Y * zoomLevel);
                var scaledB = new Point(pointB.X * zoomLevel, pointB.Y * zoomLevel);

                lineUserControl.Draw(
                    startPoint: scaledA,
                    endPoint: scaledB,
                    color: color
                );

                line.UserControl = lineUserControl;
            }
        }
    }
}
