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
        Surface s;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            s = new Surface(100, 100);
            s.RotateX(0.1);
            //s.Move(100, 100, -100);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //s.Rotate(Double.Parse(textBoxAlpha.Text), Double.Parse(textBoxBeta.Text), Double.Parse(textBoxGamma.Text));
            //s.Move(Double.Parse(textBoxDX.Text), Double.Parse(textBoxDY.Text), Double.Parse(textBoxDZ.Text));
            //s.Scale(Double.Parse(textBoxKX.Text), Double.Parse(textBoxKY.Text), Double.Parse(textBoxKZ.Text));
            for (int i = 0; i < 100000000; i++)
            {
                s.RotateX(0.1);
                s.RotateY(0.1);
                //s.Move(0, 0, -10);
                g.DrawImage(s.Draw(),0,0);
                //pictureBox1.Image = s.Draw();
                //hread.Sleep(100);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
