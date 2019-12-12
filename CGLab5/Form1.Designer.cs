namespace CGLab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cadrY = new System.Windows.Forms.TextBox();
            this.textBox_cadrX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Cam = new System.Windows.Forms.RadioButton();
            this.radioButton_Obj = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Z = new System.Windows.Forms.RadioButton();
            this.radioButton_Y = new System.Windows.Forms.RadioButton();
            this.radioButton_X = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_Rotate = new System.Windows.Forms.RadioButton();
            this.radioButton_Scale = new System.Windows.Forms.RadioButton();
            this.radioButton_Move = new System.Windows.Forms.RadioButton();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Demo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox_cadrY);
            this.panel3.Controls.Add(this.textBox_cadrX);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(669, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 90);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "По оси Y = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кадрирование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "По оси X = ";
            // 
            // textBox_cadrY
            // 
            this.textBox_cadrY.Location = new System.Drawing.Point(81, 52);
            this.textBox_cadrY.Name = "textBox_cadrY";
            this.textBox_cadrY.Size = new System.Drawing.Size(66, 20);
            this.textBox_cadrY.TabIndex = 2;
            this.textBox_cadrY.Text = "250";
            // 
            // textBox_cadrX
            // 
            this.textBox_cadrX.Location = new System.Drawing.Point(81, 26);
            this.textBox_cadrX.Name = "textBox_cadrX";
            this.textBox_cadrX.Size = new System.Drawing.Size(66, 20);
            this.textBox_cadrX.TabIndex = 1;
            this.textBox_cadrX.Text = "250";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Cam);
            this.groupBox1.Controls.Add(this.radioButton_Obj);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(677, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Преобразование над";
            // 
            // radioButton_Cam
            // 
            this.radioButton_Cam.AutoSize = true;
            this.radioButton_Cam.Location = new System.Drawing.Point(7, 52);
            this.radioButton_Cam.Name = "radioButton_Cam";
            this.radioButton_Cam.Size = new System.Drawing.Size(64, 17);
            this.radioButton_Cam.TabIndex = 1;
            this.radioButton_Cam.TabStop = true;
            this.radioButton_Cam.Text = "Камера";
            this.radioButton_Cam.UseVisualStyleBackColor = true;
            // 
            // radioButton_Obj
            // 
            this.radioButton_Obj.AutoSize = true;
            this.radioButton_Obj.Location = new System.Drawing.Point(7, 29);
            this.radioButton_Obj.Name = "radioButton_Obj";
            this.radioButton_Obj.Size = new System.Drawing.Size(63, 17);
            this.radioButton_Obj.TabIndex = 0;
            this.radioButton_Obj.TabStop = true;
            this.radioButton_Obj.Text = "Объект";
            this.radioButton_Obj.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Z);
            this.groupBox2.Controls.Add(this.radioButton_Y);
            this.groupBox2.Controls.Add(this.radioButton_X);
            this.groupBox2.Location = new System.Drawing.Point(677, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ось";
            // 
            // radioButton_Z
            // 
            this.radioButton_Z.AutoSize = true;
            this.radioButton_Z.Location = new System.Drawing.Point(6, 66);
            this.radioButton_Z.Name = "radioButton_Z";
            this.radioButton_Z.Size = new System.Drawing.Size(32, 17);
            this.radioButton_Z.TabIndex = 2;
            this.radioButton_Z.TabStop = true;
            this.radioButton_Z.Text = "Z";
            this.radioButton_Z.UseVisualStyleBackColor = true;
            // 
            // radioButton_Y
            // 
            this.radioButton_Y.AutoSize = true;
            this.radioButton_Y.Location = new System.Drawing.Point(6, 43);
            this.radioButton_Y.Name = "radioButton_Y";
            this.radioButton_Y.Size = new System.Drawing.Size(32, 17);
            this.radioButton_Y.TabIndex = 1;
            this.radioButton_Y.TabStop = true;
            this.radioButton_Y.Text = "Y";
            this.radioButton_Y.UseVisualStyleBackColor = true;
            // 
            // radioButton_X
            // 
            this.radioButton_X.AutoSize = true;
            this.radioButton_X.Location = new System.Drawing.Point(7, 20);
            this.radioButton_X.Name = "radioButton_X";
            this.radioButton_X.Size = new System.Drawing.Size(32, 17);
            this.radioButton_X.TabIndex = 0;
            this.radioButton_X.TabStop = true;
            this.radioButton_X.Text = "X";
            this.radioButton_X.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_Rotate);
            this.groupBox3.Controls.Add(this.radioButton_Scale);
            this.groupBox3.Controls.Add(this.radioButton_Move);
            this.groupBox3.Location = new System.Drawing.Point(677, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вид";
            // 
            // radioButton_Rotate
            // 
            this.radioButton_Rotate.AutoSize = true;
            this.radioButton_Rotate.Location = new System.Drawing.Point(6, 66);
            this.radioButton_Rotate.Name = "radioButton_Rotate";
            this.radioButton_Rotate.Size = new System.Drawing.Size(126, 17);
            this.radioButton_Rotate.TabIndex = 2;
            this.radioButton_Rotate.TabStop = true;
            this.radioButton_Rotate.Text = "Поворот вокруг оси";
            this.radioButton_Rotate.UseVisualStyleBackColor = true;
            // 
            // radioButton_Scale
            // 
            this.radioButton_Scale.AutoSize = true;
            this.radioButton_Scale.Location = new System.Drawing.Point(6, 43);
            this.radioButton_Scale.Name = "radioButton_Scale";
            this.radioButton_Scale.Size = new System.Drawing.Size(119, 17);
            this.radioButton_Scale.TabIndex = 1;
            this.radioButton_Scale.TabStop = true;
            this.radioButton_Scale.Text = "Масштабирование";
            this.radioButton_Scale.UseVisualStyleBackColor = true;
            // 
            // radioButton_Move
            // 
            this.radioButton_Move.AutoSize = true;
            this.radioButton_Move.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Move.Name = "radioButton_Move";
            this.radioButton_Move.Size = new System.Drawing.Size(101, 17);
            this.radioButton_Move.TabIndex = 0;
            this.radioButton_Move.TabStop = true;
            this.radioButton_Move.Text = "Передвижение";
            this.radioButton_Move.UseVisualStyleBackColor = true;
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(677, 338);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(100, 20);
            this.textBox_value.TabIndex = 8;
            this.textBox_value.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Значение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Угол умножать на 100";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cadrY;
        private System.Windows.Forms.TextBox textBox_cadrX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Cam;
        private System.Windows.Forms.RadioButton radioButton_Obj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Z;
        private System.Windows.Forms.RadioButton radioButton_Y;
        private System.Windows.Forms.RadioButton radioButton_X;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_Rotate;
        private System.Windows.Forms.RadioButton radioButton_Scale;
        private System.Windows.Forms.RadioButton radioButton_Move;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

