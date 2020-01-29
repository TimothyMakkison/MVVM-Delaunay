using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Triangle_Inscriber.Helpers.Helper_Classes;
using System.Windows.Input;

namespace Triangle_Inscriber.MainPage
{
    public static class InteractiveCanvasModel
    {
        public static List<Circle> UpdateCanvasItems(FloatingPoint point, List<Circle> circles)
        {
            //Find closest circle.
            double closest = double.MaxValue;

            int best = 0;
            for(int i=0; i<circles.Count; i++)
            {
                var t = circles[i].CanvasPosition;
                var distance = Math.Abs(point.X - t.X) + Math.Abs(point.Y - t.Y);
                if (distance < closest)
                {
                    closest = distance;
                    best = i;
                }
            }
            circles[best].Position = point;
            return circles;
        }

        #region Vertices
        public static Circle Red { get; set; } = new Circle(100, 300, 10);
        public static Circle Green { get; set; } = new Circle(300, 100, 10);
        public static Circle Blue { get; set; } = new Circle(300, 300, 10);

        public static List<Circle> Dots { get; set; } = new List<Circle>() { Red, Green, Blue };
        #endregion

        #region CircleProperties
        public static Circle Circle { get; set; } = TriangleInscriber.Inscribe(Circle, Dots[0].Position, Dots[1].Position, Dots[2].Position);
        #endregion

        public static void OnUserClick(FloatingPoint point)
        {
            UpdateCanvasItems(point,Dots);
            TriangleInscriber.Inscribe(Circle, Dots[0].Position, Dots[1].Position, Dots[2].Position);
        }
    }
}
