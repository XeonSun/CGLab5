using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGLab5
{
    class Axis
    {
        public Point3D _xAx;
        public Point3D _yAx;
        public Point3D _zAx;
        public Point3D _O;
        public Axis()
        {
            _xAx = new Point3D(100, 0, 0);
            _yAx = new Point3D(0, 100, 0);
            _zAx = new Point3D(0, 0, 100);
            _O = new Point3D(0, 0, 0);

        }
        public void Draw(Graphics g, int x_cadr, int y_cadr)
        {
            g.DrawLine(Pens.Black,(float) _O.X + x_cadr, (float)_O.Y + y_cadr, (float)_xAx.X + x_cadr, (float)_xAx.Y + y_cadr);
            g.DrawLine(Pens.Black, (float)_O.X + x_cadr, (float)_O.Y + y_cadr, (float)_yAx.X + x_cadr, (float)_yAx.Y + y_cadr);
            g.DrawLine(Pens.Black, (float)_O.X + x_cadr, (float)_O.Y + y_cadr, (float)_zAx.X + x_cadr, (float)_zAx.Y + y_cadr);

        }

    }
}
