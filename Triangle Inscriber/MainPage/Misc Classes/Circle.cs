using TriangleInscriber.Helpers.HelperClasses;

namespace TriangleInscriber.MainPage
{
    /// <summary>
    /// Contains position data, canvas position data and diameter of circle.
    /// </summary>
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
        /// <summary>
        /// Position used to place on canvas, offset based off radius so the center appears where its position is.
        /// </summary>
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

        /// <summary>
        /// Diameter of circle.
        /// </summary>
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
            OnPropertyChanged(nameof(CanvasPosition));
        }

        #region Override
        public override string ToString()
        {
            return $"Position: {Position}, Diameter: {Diameter}";
        }
        #endregion

        #endregion
    }
}
