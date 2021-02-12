using DelaunatorSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Shapes;
using TriangleInscriber.Helpers.HelperClasses;
using ColorMine.ColorSpaces;
using TriangleInscriber.MainPage;
using System.Windows.Media;
using Triangle_Inscriber.Extensions;

namespace TriangleInscriber.MainPage
{
    public class MainPageViewModel : ObservableObject, IPageViewModel
    {
        private IEnumerable<Poly> polygons;
        public string Name => "Main Page";

        public IEnumerable<Poly> Polygons
        {
            get => polygons;
            set
            {
                polygons = value;
                OnPropertyChanged();
            }
        }

        public List<IPoint> Points { get; set; }
        private Func<Poly,SolidColorBrush> ColorFunction { get; set; }

        public MainPageViewModel()
        {
            Random r = new Random();

            double width = 1500;
            double height = 800;

            IPoint randPoint()
            {
                return new DelaunatorSharp.Point(r.NextDouble() * width, r.NextDouble() * height);
            }

            Points = Enumerable.Range(0, 100).Select(x => randPoint()).ToList();

            ColorFunction = p =>
            {
                var x = p.Points.Min(po=> po.X);
                var y = p.Points.Min(po => po.Y);

                var i = p.Index;

                var hsl = new Hsl() { H = 360 * x / width, S = 80, L = 60 };
                return hsl.ToColor().ToBrush();
            };

            UpdatePolygons();
        }
        public void UpdatePolygons()
        {
            var polies = DelauneyHandler.GetVoroni(Points);
            Polygons = polies.Select(p => new Poly
            {
                Points = p.Points,
                Index = p.Index,
                Brush = ColorFunction(p) 
            });
        }
    }
}
