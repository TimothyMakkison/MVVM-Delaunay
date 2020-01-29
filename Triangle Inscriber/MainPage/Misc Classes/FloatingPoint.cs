using TriangleInscriber.Helpers.HelperClasses;

namespace TriangleInscriber.MainPage
{
    /// <summary>
    /// Two dimensional flaoting point position, has basic mathematical operators and converters.
    /// </summary>
    public class FloatingPoint : ObservableObject
    {
        #region Fields
        private double x, y;
        #endregion

        #region Constructor
        public FloatingPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Properties
        public double X
        {
            get => x;
            set
            {
                x = value;
                OnPropertyChanged();
            }
        }
        public double Y
        {
            get => y;
            set
            {
                y = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Operators
        public static FloatingPoint operator -(FloatingPoint point, double value) => new FloatingPoint(point.X - value, point.Y - value);

        public static FloatingPoint operator +(FloatingPoint point, double value) => new FloatingPoint(point.X + value, point.Y + value);

        public static FloatingPoint operator +(FloatingPoint a, FloatingPoint b) => new FloatingPoint(a.X + b.X, a.Y + b.Y);

        public static FloatingPoint operator -(FloatingPoint a, FloatingPoint b) => new FloatingPoint(a.X - b.X, a.Y - b.Y);

        public static FloatingPoint operator ^(FloatingPoint a, FloatingPoint b) => new FloatingPoint(a.X - b.X, a.Y - b.Y);

        public static implicit operator FloatingPoint(System.Windows.Point point) => new FloatingPoint(point.X, point.Y);
        #endregion

        #region Overrides
        public override string ToString() => $"{{{X}, {Y}}}";
        #endregion
    }

}
