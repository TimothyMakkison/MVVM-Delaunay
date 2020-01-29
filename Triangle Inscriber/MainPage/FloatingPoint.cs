using Triangle_Inscriber.Helpers.Helper_Classes;

public class FloatingPoint : ObservableObject
{
    private double x, y;

    public FloatingPoint(double x, double y)
    {
        X = x;
        Y = y;
    }

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

    public override string ToString() => $"{{{X}, {Y}}}";

    public static FloatingPoint operator -(FloatingPoint point, double value) => new FloatingPoint(point.X - value, point.Y - value);

    public static FloatingPoint operator +(FloatingPoint point, double value) => new FloatingPoint(point.X + value, point.Y + value);

    public static FloatingPoint operator +(FloatingPoint a, FloatingPoint b) => new FloatingPoint(a.X + b.X, a.Y + b.Y);

    public static FloatingPoint operator -(FloatingPoint a, FloatingPoint b) => new FloatingPoint(a.X - b.X, a.Y - b.Y);

    public static FloatingPoint operator ^(FloatingPoint a, FloatingPoint b) => new FloatingPoint(a.X - b.X, a.Y - b.Y);

    public static implicit operator FloatingPoint(System.Windows.Point point) => new FloatingPoint(point.X, point.Y);
}
