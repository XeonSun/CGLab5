using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGLab5
{
    class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        private double old_x;
        private double old_y;
        private double old_z;

        
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            old_x = x;
            old_y = y;
            old_z = z;
        }
        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
            old_x = 0;
            old_y = 0;
            old_z = 0;
        }

        public void Reset()
        {
            X = old_x;
            Y = old_y;
            Z = old_z;
        }
        public double[] AsMatrix()
        {
            double[] a = { X, Y, Z, 1  };
            return a;
        }
    }

    class Polygon
    {
        private Point3D _fitstPoint;
        private Point3D _secondPoint;
        private Point3D _thirdPoint;
        private Point3D _normal;
        private Point3D _light;
        public Polygon(Point3D fitstPoint, Point3D secondPoint, Point3D thirdPoint)
        {
            _fitstPoint = fitstPoint;
            _secondPoint = secondPoint;
            _thirdPoint = thirdPoint;
            _normal = new Point3D();
            _light = new Point3D(0, 10000000, 0);
        }
        private void CalcNormal()
        {
            _normal.X = (_secondPoint.Y - _fitstPoint.Y) * (_thirdPoint.Z - _fitstPoint.Z) - (_secondPoint.Z - _fitstPoint.Z) * (_thirdPoint.Y - _fitstPoint.Y);
            _normal.Y = (_secondPoint.Z - _fitstPoint.Z) * (_thirdPoint.X - _fitstPoint.X) - (_secondPoint.X - _fitstPoint.X) * (_thirdPoint.Z - _fitstPoint.Z);
            _normal.Z = (_secondPoint.X - _fitstPoint.X) * (_thirdPoint.Y - _fitstPoint.Y) - (_secondPoint.Y - _fitstPoint.Y) * (_thirdPoint.X - _fitstPoint.X);
            _light.X = _light.X - _fitstPoint.X;
            _light.Y = _light.Y - _fitstPoint.Y;
            _light.Z = _light.Z - _fitstPoint.Z;
        }
        private double CosTetha()
        {
            double ct = (_normal.X * _light.X + _normal.Y * _light.Y + _normal.Z * _light.Z) / (Math.Sqrt((_normal.X * _normal.X + _normal.Y * _normal.Y + _normal.Z * _normal.Z) * (_light.X * _light.X + _light.Y * _light.Y + _light.Z * _light.Z)));

            return ct;
        }
        public void Draw(Graphics g)
        {
            CalcNormal();
            if (_normal.Z >= 0)
            {
                PointF[] pointFs = { new PointF((float)_fitstPoint.X+250, (float)_fitstPoint.Y+250),
                                     new PointF((float)_secondPoint.X+250, (float)_secondPoint.Y+250),
                                     new PointF((float)_thirdPoint.X+250, (float)_thirdPoint.Y+250) };
                g.FillPolygon(new SolidBrush(Color.FromArgb((int)(127 * CosTetha()) + 127, (int)(127 * CosTetha()) + 127, (int)(127 * CosTetha()) + 127)), pointFs);
                //g.FillPolygon(new SolidBrush(Color.FromArgb(255, 0, 0)), pointFs);
                //g.DrawPolygon(new Pen(Brushes.Black, 1), pointFs);

            }
        }

    }

    class Surface
    {
        private SurfaceParametres SurfaceParametres;
        public Bitmap bmp;
        Graphics g;
        public Surface(double r, double h)
        {

            SurfaceParametres = new SurfaceParametres(r, h);
            bmp = new Bitmap(800, 500);
            g = Graphics.FromImage(bmp);
            SurfaceGenerator();
        }

        private void SurfaceGenerator()
        {
            for (int alpha = 0; alpha <= 19; alpha++)
            {
                Point3D a = PointGen(alpha, -5);
                Point3D b = PointGen(alpha + 1, -5);
                SurfaceParametres.polygons.Add(new Polygon(SurfaceParametres.bottomPoint, a, b));
            }
            for (int r = -5; r <= 4; r++)
                for (int alpha = 1; alpha <= 20; alpha++)
                {
                    Point3D a = PointGen(alpha, r);
                    Point3D b = PointGen(alpha - 1, r);
                    Point3D c = PointGen(alpha - 1, r + 1);
                    Point3D d = PointGen(alpha, r + 1);
                    SurfaceParametres.polygons.Add(new Polygon(a, b, c));
                    SurfaceParametres.polygons.Add(new Polygon(a, c, d));
                }

            for (int alpha = 1; alpha <= 20; alpha++)
            {
                Point3D a = PointGen(alpha, 5);
                Point3D b = PointGen(alpha - 1, 5);
                SurfaceParametres.polygons.Add(new Polygon(SurfaceParametres.topPoint, a, b));
            }
        }
        private Point3D PointGen(int alpha, int r)
        {
            Point3D point = new Point3D(SurfaceParametres.R * Math.Sin(Math.PI * alpha / 10), SurfaceParametres.R * Math.Cos(Math.PI * alpha / 10), SurfaceParametres.H/10 * r);
            SurfaceParametres.points.Add(point);
            return point;
        }

        public void RotateX(double alpha)
        {
            double[,] m = { { 1, 0, 0, 0},
                            { 0, Math.Cos(alpha), -Math.Sin(alpha), 0},
                            { 0, Math.Sin(alpha), Math.Cos(alpha), 0},
                            { 0, 0, 0, 1 } };
            SurfaceParametres.aphineMatrix = multMatrix(m, SurfaceParametres.aphineMatrix);
        }

        public void RotateY(double beta)
        {
            double[,] m = { { Math.Cos(beta), 0, Math.Sin(beta), 0},
                            { 0, 1, 0, 0},
                            { -Math.Sin(beta), 0, Math.Cos(beta), 0},
                            { 0, 0, 0, 1 } };
            SurfaceParametres.aphineMatrix = multMatrix(m, SurfaceParametres.aphineMatrix);
        }

        public void RotateZ(double gamma)
        {
            double[,] m = { { Math.Cos(gamma), -Math.Sin(gamma),0, 0},
                            { Math.Sin(gamma),  Math.Cos(gamma), 0, 0},
                            { 0, 0, 1, 0},
                            { 0, 0, 0, 1 } };
            SurfaceParametres.aphineMatrix = multMatrix(m, SurfaceParametres.aphineMatrix);
        }
        public void Scale(double kx, double ky, double kz)
        {
            double[,] m = { { kx, 0, 0, 0},
                            { 0, ky, 0, 0},
                            { 0, 0, kz, 0},
                            { 0, 0, 0, 1 } };
            SurfaceParametres.aphineMatrix = multMatrix(m, SurfaceParametres.aphineMatrix);
        }
        public void Move(double dx, double dy, double dz)
        {
            double[,] m = { { 1, 0, 0, dx},
                            { 0, 1, 0, dy},
                            { 0, 0, 1, dz},
                            { 0, 0, 0, 1 } };
            SurfaceParametres.aphineMatrix = multMatrix(m, SurfaceParametres.aphineMatrix);
        }

        private double[,] multMatrix(double[,] a, double[,] b)
        {
            double[,] mOut = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    mOut[i, j] = 0.0;
                    for (int g = 0; g < 4; g++)
                        mOut[i, j] += a[i, g] * b[g, j];
                }
            return mOut;
        }
        private double[] multMatrix(double[,] a, double[] b)
        {
            double[] mOut = new double[4];
            for (int i = 0; i < 4; i++)
                {
                    mOut[i] = 0.0;
                    for (int g = 0; g < 4; g++)
                        mOut[i] += a[i, g] * b[g];
                }
            return mOut;
        }

        private void Aphine(Point3D p)
        {
            double[] a = multMatrix(SurfaceParametres.aphineMatrix, p.AsMatrix());
            p.X = a[0];
            p.Y = a[1];
            p.Z = a[2];
        }

        public Bitmap Draw()
        {
            g.Clear(Color.White);
            foreach (Point3D p in SurfaceParametres.points)
            {
                p.Reset();
                
                Aphine(p);

                p.X = p.X * SurfaceParametres.camera.Z / (SurfaceParametres.camera.Z-p.Z);
                p.Y = p.Y * SurfaceParametres.camera.Z / (SurfaceParametres.camera.Z-p.Z);

            }
            foreach(Polygon p in SurfaceParametres.polygons)
            {
                p.Draw(g);
            }
            g.Save();
            return bmp;
            
        }
    }
}
