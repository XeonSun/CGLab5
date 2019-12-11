using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double[] a = { X, Y, Z, 1 };
            return a;
        }
    }
}
