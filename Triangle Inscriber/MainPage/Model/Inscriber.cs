using System;

namespace TriangleInscriber.MainPage
{
    public static class Inscriber
    {
        /// <summary>
        /// Calculates bounding circle that enscribes 3 points. 
        /// </summary>
        /// <param name="a">First point.</param>
        /// <param name="b">Second point.</param>
        /// <param name="c">Third point.</param>
        /// <returns>Position and diameter of circle.</returns>
        public static Circle InscribeTriangle(this Circle circle, FloatingPoint a, FloatingPoint b, FloatingPoint c)
        {
            //Calculate deltas
            double dx1 = a.X - b.X;
            double dy1 = a.Y - b.Y;
            double dx2 = b.X - c.X;
            double dy2 = b.Y - c.Y;

            // Find median points
            double mx1 = b.X + dx1 / 2;
            double my1 = b.Y + dy1 / 2;
            double mx2 = c.X + dx2 / 2;
            double my2 = c.Y + dy2 / 2;

            // Delta median points
            double dmx1 = mx1 - mx2;
            double dmy1 = my1 - my2;

            //Find the normal gradient at the median
            double g1 = -dx1 / dy1;
            double g2 = -dx2 / dy2;

            double determinant = -g1 + g2;
            double n = (-g2 * dmx1 + dmy1) / determinant;

            //Circle center
            double cx;
            double cy;

            if (double.IsNaN(n))
            {
                cx = mx2;
                cy = my1;
            }
            else if (n == 0)
            {
                cx = mx1;
                cy = my2;
            }
            else
            {
                //Caclulate center position
                cx = mx1 + n;
                cy = my1 + n * g1;
            }

            double rx = a.X - cx;
            double ry = a.Y - cy;
            double radius = Math.Sqrt(rx * rx + ry * ry);

            FloatingPoint cPoint = new FloatingPoint(cx, cy);
            circle.Position = cPoint;
            circle.Diameter = 2 * radius;

            return new Circle(cPoint, 2 * radius);
        }
    }
}
