using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLab5
{
    class Camera:IAphine
    {
        public Point3D position;
        public double Zpl;
        public double[,] aphineMatrix { get; set; }
        public Camera(double x ,double y, double z)
        {
            Zpl = 0.0d;
            position = new Point3D(x, y, z);
            aphineMatrix = new double[4, 4];
            for (int i = 0; i < 4; aphineMatrix[i, i++] = 1.0) ;
        }

    }
    }

