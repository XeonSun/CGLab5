using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLab5
{
    interface IRenderObject
    {
        double[,] aphineMatrix { get; set; }
        List<Point3D> points { get; set; }
        List<Point3D> genPoints { get; set; }
    }
}
