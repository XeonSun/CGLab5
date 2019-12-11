using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLab5
{
    static class AphineWork
    {
        public static void RotateX(IAphine cyl,double alpha)
        {
            double[,] m = { { 1, 0, 0, 0},
                            { 0, Math.Cos(alpha), -Math.Sin(alpha), 0},
                            { 0, Math.Sin(alpha), Math.Cos(alpha), 0},
                            { 0, 0, 0, 1 } };
            cyl.aphineMatrix = multMatrix(m, cyl.aphineMatrix);
        }

        public static void RotateY(IAphine cyl,double beta)
        {
            double[,] m = { { Math.Cos(beta), 0, Math.Sin(beta), 0},
                            { 0, 1, 0, 0},
                            { -Math.Sin(beta), 0, Math.Cos(beta), 0},
                            { 0, 0, 0, 1 } };
            cyl.aphineMatrix = multMatrix(m, cyl.aphineMatrix);
        }

        public static void RotateZ(IAphine cyl, double gamma)
        {
            double[,] m = { { Math.Cos(gamma), -Math.Sin(gamma),0, 0},
                            { Math.Sin(gamma),  Math.Cos(gamma), 0, 0},
                            { 0, 0, 1, 0},
                            { 0, 0, 0, 1 } };
            cyl.aphineMatrix = multMatrix(m, cyl.aphineMatrix);
        }
        public static void Scale(IAphine cyl, double kx, double ky, double kz)
        {
            double[,] m = { { kx, 0, 0, 0},
                            { 0, ky, 0, 0},
                            { 0, 0, kz, 0},
                            { 0, 0, 0, 1 } };
            cyl.aphineMatrix = multMatrix(m, cyl.aphineMatrix);
        }
        public static void Move(IAphine cyl,double dx, double dy, double dz)
        {
            double[,] m = { { 1, 0, 0, dx},
                            { 0, 1, 0, dy},
                            { 0, 0, 1, dz},
                            { 0, 0, 0, 1 } };
            cyl.aphineMatrix = multMatrix(m, cyl.aphineMatrix);
        }

        public static double[,] multMatrix(double[,] a, double[,] b)
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
        public static double[] multMatrix(double[,] a, double[] b)
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
    }
}
