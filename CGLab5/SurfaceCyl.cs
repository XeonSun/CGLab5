using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGLab5
{
    class SurfaceCyl:IAphine
    {
        public double R;
        public double H;
        public List<Point3D> points;
        public List<Polygon> polygons;
        public Point3D topPoint;
        public Point3D bottomPoint;
        public double[,] aphineMatrix { get; set; }
        public Point3D camera;
        public SurfaceCyl(double R, double H)
        {
            this.R = R;
            this.H = H;
            points = new List<Point3D>();
            polygons = new List<Polygon>();
            topPoint = new Point3D(0, 0, H * 1);
            bottomPoint = new Point3D(0, 0, -H * 0.6);
            camera = new Point3D(0, 0, 400);
            points.Add(topPoint);
            points.Add(bottomPoint);
            aphineMatrix = new double[4, 4];
            for (int i = 0; i < 4; aphineMatrix[i, i++] = 1.0) ;

            SurfaceGenerator();
        }

        private void SurfaceGenerator()
        {
            for (double alpha = 0; alpha <= 20; alpha+=0.1)
            {
                Point3D a = PointGen(alpha, -5);
                Point3D b = PointGen(alpha + 1, -5);
                polygons.Add(new Polygon(bottomPoint, a, b));
            }
            for (int r = -5; r <= 4; r++)
                for (double alpha = 0; alpha <= 20; alpha += 0.1)
                {
                    Point3D a = PointGen(alpha, r);
                    Point3D b = PointGen(alpha - 1, r);
                    Point3D c = PointGen(alpha - 1, r + 1);
                    Point3D d = PointGen(alpha, r + 1);
                    polygons.Add(new Polygon(a, b, c));
                    polygons.Add(new Polygon(a, c, d));
                }

            for (double alpha = 0; alpha <= 20; alpha += 0.1)
            {
                Point3D a = PointGen(alpha, 5);
                Point3D b = PointGen(alpha - 1, 5);
                polygons.Add(new Polygon(topPoint, a, b));
            }
        }
        private Point3D PointGen(double alpha, double r)
        {
            Point3D point = new Point3D(R * Math.Sin(Math.PI * alpha / 10), R * Math.Cos(Math.PI * alpha / 10), H / 10 * r);
            points.Add(point);
            return point;
        }


    }
}
