using DelaunatorSharp;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using TriangleInscriber.MainPage;

public static class DelauneyHandler
{
    public static IEnumerable<Poly> GetTriangles(this IEnumerable<IPoint> points)
    {
        var delauney = new Delaunator(points.ToArray());

        var triangles = delauney.GetTriangles();
        return triangles.Select(tri => new Poly()
        {
            Points = tri.Points.ToPointCollection(),
            Index = tri.Index
        });
    }

    public static IEnumerable<Poly> GetVoroni(this IEnumerable<IPoint> points)
    {
        var delauney = new Delaunator(points.ToArray());

        var voroni = delauney.GetVoronoiCells();
        return voroni.Select(vor => new Poly()
        {
            Points = vor.Points.ToPointCollection(),
            Index = vor.Index
        });
    }

    private static PointCollection ToPointCollection(this IEnumerable<IPoint> points)
    {
        return new PointCollection(points.Select(p => new System.Windows.Point(p.X, p.Y)));
    }
}