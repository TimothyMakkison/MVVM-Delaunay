using System;

namespace TriangleInscriber.MainPage
{
    public static class InteractiveCanvasModel
    {
        #region Properties

        #region Dots
        public static Circle Red { get; set; } = new Circle(200, 100, 10);
        public static Circle Green { get; set; } = new Circle(100, 241, 10);
        public static Circle Blue { get; set; } = new Circle(500, 240, 10);

        private static readonly Circle[] dots = new Circle[3] { Red, Green, Blue };
        #endregion

        #region Inscribing Circle
        public static Circle InscribingCircle { get; set; } = Inscriber.InscribeTriangle(new Circle(0, 0, 0), Red.Position, Green.Position, Blue.Position);
        #endregion

        #endregion

        #region Methods
        /// <summary>
        /// Sets circle position and updates inscribing circle.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="circle"></param>
        public static void MoveCanvasDot(FloatingPoint point, Circle circle)
        {
            if (circle == null)
            {
                throw new ArgumentNullException("Cannot move canvas object as circle is null");
            }
            circle.Position = point;
            Inscriber.InscribeTriangle(InscribingCircle, Red.Position, Green.Position, Blue.Position);
        }

        /// <summary>
        /// Transform canvas items by a vector.
        /// </summary>
        /// <param name="offset">Transformation vector.</param>
        public static void TransformCanvasItems(FloatingPoint offset)
        {
            for (int i = 0; i < dots.Length; i++)
            {
                dots[i].Position -= offset;
            }
            InscribingCircle.Position -= offset;
        }

        /// <summary>
        /// Moves closest dot to point.
        /// </summary>
        /// <param name="point">Position closest dot will be moved to.</param>
        /// <param name="Dots">Collection of dots.</param>
        /// <returns>Closest item.</returns>
        public static Circle FindClosestItem(FloatingPoint point)
        {
            //Find closest circle.
            double closest = double.MaxValue;
            int best = 0;

            for (int i = 0; i < dots.Length; i++)
            {
                FloatingPoint truePosition = dots[i].Position;
                double distance = Math.Abs(point.X - truePosition.X) + Math.Abs(point.Y - truePosition.Y);
                if (distance < closest)
                {
                    closest = distance;
                    best = i;
                }
            }
            return dots[best];
        }
        #endregion
    }
}
