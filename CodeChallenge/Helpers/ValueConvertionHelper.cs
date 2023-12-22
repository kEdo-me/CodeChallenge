using System.Drawing;
using System.Globalization;
using Color = System.Windows.Media.Color;

namespace CodeChallenge.Helpers
{
    public static class ValueConvertionHelper
    {
        public static Point ConvertCircleCenterStringToPoint(string center)
        {
            var values = center.Split(';');

            if (values.Length != 2 || !int.TryParse(values[0], out int x) || !int.TryParse(values[1], out int y))
            {
                throw new ArgumentException("Invalid circle center string format.");
            }

            return new Point() { X = x, Y = y };
        }

        public static Color ConvertColorStringToColorStructure(string? colorString)
        {
            var values = colorString?.Split(';');

            if (values == null ||
                values.Length != 4 ||
                !byte.TryParse(values[0], out byte a) ||
                !byte.TryParse(values[1], out byte r) ||
                !byte.TryParse(values[2], out byte g) ||
                !byte.TryParse(values[3], out byte b))
            {
                throw new ArgumentException("Invalid color string format.");
            }

            return Color.FromArgb(a, r, g, b);
        }

        public static System.Windows.Point ConvertStringToWindowsPoint(string point)
        {
            var values = point.Split(';');
            if (values.Length == 2 && double.TryParse(values[0].Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double x) &&
                double.TryParse(values[1].Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double y))
            {
                return new System.Windows.Point(x, y);
            }

            throw new ArgumentException("Invalid point string format.");
        }
    }
}
