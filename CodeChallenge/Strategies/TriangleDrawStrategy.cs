using CodeChallange.Primitives;
using CodeChallenge.Helpers;
using CodeChallenge.Interfaces;
using CodeChallenge.UserControles;
using System.Windows;

namespace CodeChallenge.Strategies
{
    internal class TriangleDrawStrategy : IDrawStrategy
    {
        public void Draw(BasePrimitive primitive, double zoomLevel)
        {
            if (primitive is Triangle triangle)
            {
                var triangleUserControl = new TriangleUserControl();

                var color = ValueConvertionHelper.ConvertColorStringToColorStructure(triangle?.Color);

                var pointA = ValueConvertionHelper.ConvertStringToWindowsPoint(triangle?.A);
                var pointB = ValueConvertionHelper.ConvertStringToWindowsPoint(triangle?.B);
                var pointC = ValueConvertionHelper.ConvertStringToWindowsPoint(triangle?.C);

                var scaledA = new Point(pointA.X * zoomLevel, pointA.Y * zoomLevel);
                var scaledB = new Point(pointB.X * zoomLevel, pointB.Y * zoomLevel);
                var scaledC = new Point(pointC.X * zoomLevel, pointC.Y * zoomLevel);

                triangleUserControl.Draw(
                    a: scaledA,
                    b: scaledB,
                    c: scaledC,
                    color: color,
                    filled: triangle.Filled
                );

                triangle.UserControl = triangleUserControl;
            }
        }
    }
}
