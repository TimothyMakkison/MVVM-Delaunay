using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Inscriber.MainPage
{
    public class InteractiveCanvasModel
    {
        public InteractiveCanvasModel(MainPageViewModel viewModel) => ViewModel = viewModel;

        public MainPageViewModel ViewModel { get; set; }

        public List<Circle> UpdateCanvasItems(FloatingPoint point)
        {
            //Find closest circle.
            double closest = double.MaxValue;
            List<Circle> circles = ViewModel.Dots;

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

            circles[best].CanvasPosition = point;
            return circles;
        }

        public void OnUserClick(FloatingPoint point)
        {
            UpdateCanvasItems(point);
            List<Circle> circles = ViewModel.Dots;
            ViewModel.Circle = TriangleInscriber.Inscribe(circles[0].Position, circles[1].Position, circles[2].Position);
        }
    }
}
