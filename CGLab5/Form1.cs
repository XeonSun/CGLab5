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
        Render render;
        SurfaceCyl cyl;
        Camera cam;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            cyl = new SurfaceCyl(100, 100);
            cam = new Camera(0, 0, -300);
            render = new Render();
            render.cam = cam;
            render.Cylindr = cyl;
            g.DrawImage(render.Draw(int.Parse(textBox_cadrX.Text), int.Parse(textBox_cadrY.Text)), 0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                //AphineWork.Move(s.cam, 0, 0, -1);
                AphineWork.RotateY(render.cam, -0.01);

                AphineWork.RotateX(render.Cylindr, -0.1);

                g.DrawImage(render.Draw(250, 250), 0, 0);
                //pictureBox1.Image = s.Draw();
                Thread.Sleep(10);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Кнопка применить
        private void button2_Click(object sender, EventArgs e)
        {
            double v = 0;
            IAphine selected = cyl;
            if (Double.TryParse(textBox_value.Text, out v))
            {
                if (radioButton_Obj.Checked) selected = cyl;
                if (radioButton_Cam.Checked) selected = cam;
                
                if (radioButton_Move.Checked && radioButton_X.Checked) AphineWork.Move(selected, v, 0, 0);
                if (radioButton_Move.Checked && radioButton_Y.Checked) AphineWork.Move(selected, 0, v, 0);
                if (radioButton_Move.Checked && radioButton_Z.Checked) AphineWork.Move(selected, 0, 0, v);

                if (radioButton_Scale.Checked && radioButton_X.Checked) AphineWork.Scale(selected, v, 1, 1);
                if (radioButton_Scale.Checked && radioButton_Y.Checked) AphineWork.Scale(selected, 1, v, 1);
                if (radioButton_Scale.Checked && radioButton_Z.Checked) AphineWork.Scale(selected, 1, 1, v);

                if (radioButton_Rotate.Checked && radioButton_X.Checked) AphineWork.RotateX(selected, v/100);
                if (radioButton_Rotate.Checked && radioButton_Y.Checked) AphineWork.RotateY(selected, v/100);
                if (radioButton_Rotate.Checked && radioButton_Z.Checked) AphineWork.RotateZ(selected, v/100);
                //g.DrawImage(render.Draw(int.Parse(textBox_cadrX.Text), int.Parse(textBox_cadrY.Text)), 0, 0);
            }
            g.DrawImage(render.Draw(int.Parse(textBox_cadrX.Text), int.Parse(textBox_cadrY.Text)), 0, 0);

        }
    }
}
