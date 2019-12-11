using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CGLab5
{
    public partial class Form1 : Form
    {
        Graphics g;
        Render s;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            s = new Render(100, 100);
            //s.RotateX(0.1);
            //s.Move(100, 100, -100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AphineWork.Move(s.Cylindr, 0, 300, 0);
            AphineWork.Move(s.cam, 0, 0, -300);
            AphineWork.RotateX(s.cam, -0.1);

            for (int i = 0; i < 100000000; i++)
            {
              //AphineWork.Move(s.cam, 0, 0, -1);
                AphineWork.RotateY(s.cam, -0.001);

                AphineWork.RotateX(s.Cylindr, -0.1);

                g.DrawImage(s.Draw(250,250),0,0);
                //pictureBox1.Image = s.Draw();
                Thread.Sleep(10);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
