using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGLab5
{


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
            if (ct < 0) ct = 0;
            return ct;
        }
        public void Draw(Graphics g, Point3D light, int x_cadr = 0, int y_cadr = 0, bool drawEdges = false)
        {
            _light = light;
            CalcNormal();
            if (_normal.Z >= 0)
            {
                PointF[] pointFs = { new PointF((float)_fitstPoint.X + x_cadr, (float)_fitstPoint.Y + y_cadr),
                                     new PointF((float)_secondPoint.X + x_cadr, (float)_secondPoint.Y + y_cadr),
                                     new PointF((float)_thirdPoint.X + x_cadr, (float)_thirdPoint.Y + y_cadr) };
                g.FillPolygon(new SolidBrush(Color.FromArgb((int)(227 * CosTetha()) + 5, (int)(227 * CosTetha()) + 5, (int)(227 * CosTetha()) + 5)), pointFs);
                if (drawEdges) g.DrawPolygon(new Pen(Brushes.Black, 1), pointFs);

            }
        }

    }
}
