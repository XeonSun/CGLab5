using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CGLab5
{
    

    class Render
    {
        public SurfaceCyl Cylindr;
        public Camera cam;
        public Bitmap buffer;
        public Point3D light;
        Graphics g;
        public Render(double r, double h)
        {
            cam = new Camera(0, 0, 250);
            light = new Point3D(1000, 10000, 1000);
            Cylindr = new SurfaceCyl(r, h);
            buffer = new Bitmap(800, 500);
            g = Graphics.FromImage(buffer);
        }

       

        private void AphineLocal(Point3D p)
        {
            double[] a = AphineWork.multMatrix(Cylindr.aphineMatrix, p.AsMatrix());
            p.X = a[0];
            p.Y = a[1];
            p.Z = a[2];
        }

        private void AphineGlobal(Point3D p)
        {
            double[] a = AphineWork.multMatrix(cam.aphineMatrix, p.AsMatrix());
            p.X = a[0];
            p.Y = a[1];
            p.Z = a[2];
        }
        public Bitmap Draw(bool centralProection = true)
        {
            g.Clear(Color.White);
            AphineGlobal(light);
            foreach (Point3D p in Cylindr.points)
            {
                p.Reset();
                
                AphineLocal(p);
                AphineGlobal(p);
                if (centralProection)
                {
                    p.X = p.X * (Cylindr.camera.Z) / (Cylindr.camera.Z - p.Z);
                    p.Y = p.Y * (Cylindr.camera.Z) / (Cylindr.camera.Z - p.Z);
                }

            }
            foreach(Polygon p in Cylindr.polygons)
            {
                p.Draw(g,light);
            }
            g.Save();
            return buffer;
            
        }
    }
}
