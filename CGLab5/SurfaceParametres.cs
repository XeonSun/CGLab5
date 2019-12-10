using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGLab5
{
    struct SurfaceParametres
    {
        public double R ;
        public double H ;
        public List<Point3D> points;
        public List<Point3D> genPoints;
        public List<Polygon> polygons;
        public Point3D topPoint;
        public Point3D bottomPoint;
        public double[,] aphineMatrix;
        public Point3D camera;
        public SurfaceParametres(double R, double H)
        {
            this.R = R;
            this.H = H;
            genPoints = new List<Point3D>();
            points = new List<Point3D>();
            polygons = new List<Polygon>();
            topPoint = new Point3D(0, 0, H * 1);
            bottomPoint = new Point3D(0, 0, -H * 0.5);
            camera = new Point3D(0, 0, 400);
            points.Add(topPoint);
            points.Add(bottomPoint);
            aphineMatrix = new double[4, 4];
            for (int i = 0; i < 4; aphineMatrix[i, i++] = 1.0) ;
            }


    }
}
