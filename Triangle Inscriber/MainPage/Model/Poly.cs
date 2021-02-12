using System.Windows.Media;

namespace TriangleInscriber.MainPage
{
    public struct Poly
    {
        public PointCollection Points { get; set; }
        public SolidColorBrush Brush { get; set; }
        public int Index { get; set; }
    }
}
