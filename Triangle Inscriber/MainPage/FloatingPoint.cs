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
}
