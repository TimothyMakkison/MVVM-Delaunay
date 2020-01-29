using Triangle_Inscriber.Helpers.Helper_Classes;
using System.Windows;

namespace Triangle_Inscriber.MainPage
{
    public class Circle : ObservableObject
    {
        #region Fields
        private double diameter;
        private FloatingPoint position;
        private FloatingPoint canvasPosition;
        private double radius;
        private bool change = true;
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
                UpdateCanvas();
            }
        }

        public FloatingPoint CanvasPosition
        {
            get
            {
                if (change)
                {
                    canvasPosition = Position - radius;
                    change = false;
                }
                return canvasPosition;
            }
            private set
            {
                canvasPosition = value;
                OnPropertyChanged();
            }
        }

        public double Diameter
        {
            get => diameter;
            set
            {
                diameter = value;
                radius = diameter / 2;
                OnPropertyChanged();
                UpdateCanvas();
            }
        }
        /// <summary>
        /// Updates CanvasPosition and indicates that it needs to be recalculated.
        /// </summary>
        private void UpdateCanvas()
        {
            change = true;
            OnPropertyChanged("CanvasPosition");
        }
        #region Override
        public override string ToString() => $"Position: {Position}, Diameter: {Diameter}";
        #endregion

        #endregion
    }
}
