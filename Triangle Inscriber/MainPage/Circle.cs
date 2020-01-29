using Triangle_Inscriber.Helpers.Helper_Classes;
using System.Windows;

namespace Triangle_Inscriber.MainPage
{
    public class Circle : ObservableObject
    {
        #region Fields
        private double diameter;
        private FloatingPoint position;
        #endregion

        #region Constructor
        public Circle(FloatingPoint circlePosition, double diameter)
        {
            Position = circlePosition;
            Diameter = diameter;
        }
        public Circle(double x, double y, double diameter) : this(new FloatingPoint(x, y), diameter) { }
        #endregion

        #region Properties
        public FloatingPoint Position
        {
            get => position; 
            set
            {
                position = value;
                OnPropertyChanged();
                OnPropertyChanged("CanvasPosition");

            }
        }

        public FloatingPoint CanvasPosition => Position - Diameter / 2;

        public double Diameter
        {
            get => diameter;
            set
            {
                diameter = value;
                OnPropertyChanged();
            }
        }

        #region Override
        public override string ToString() => $"{Position}, {Diameter}";
        #endregion

        #endregion
    }
}
