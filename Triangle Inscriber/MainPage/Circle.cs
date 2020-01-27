using Triangle_Inscriber.Helpers.Helper_Classes;

namespace Triangle_Inscriber.MainPage
{
    public class Circle : ObservableObject
    {
        #region Fields
        private double diameter;
        private bool viewChange = true;
        private FloatingPoint canvasPosition;
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
            get => position; set
            {
                viewChange = true;
                position = value;
            }
        }

        public FloatingPoint CanvasPosition
        {
            get
            {
                if (viewChange)
                {
                    canvasPosition = Position - Diameter / 2;
                    viewChange = false;
                    OnPropertyChanged();
                }
                return canvasPosition;
            }
        }

        public double Diameter
        {
            get => diameter;
            set
            {
                viewChange = true;
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
