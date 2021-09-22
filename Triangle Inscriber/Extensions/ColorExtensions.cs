using ColorMine.ColorSpaces;
using System.Windows.Media;

namespace Triangle_Inscriber.Extensions
{
    public static class ColorExtensions
    {
        public static Color ToColor(this IColorSpace colorSpace)
        {
            var rgb = colorSpace.ToRgb();
            return Color.FromArgb(255, (byte)rgb.R, (byte)rgb.G, (byte)rgb.B);
        }

        public static SolidColorBrush ToBrush(this Color color)
        {
            return new SolidColorBrush(color);
        }
    }
}