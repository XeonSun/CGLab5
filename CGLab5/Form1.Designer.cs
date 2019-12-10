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
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxKY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxKX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(934, 44);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(35, 20);
            this.textBoxAlpha.TabIndex = 2;
            this.textBoxAlpha.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(973, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "beta";
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(973, 44);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(35, 20);
            this.textBoxBeta.TabIndex = 4;
            this.textBoxBeta.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1012, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "gamma";
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(1012, 44);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(35, 20);
            this.textBoxGamma.TabIndex = 6;
            this.textBoxGamma.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1012, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "dz";
            // 
            // textBoxDZ
            // 
            this.textBoxDZ.Location = new System.Drawing.Point(1012, 96);
            this.textBoxDZ.Name = "textBoxDZ";
            this.textBoxDZ.Size = new System.Drawing.Size(35, 20);
            this.textBoxDZ.TabIndex = 13;
            this.textBoxDZ.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(973, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "dy";
            // 
            // textBoxDY
            // 
            this.textBoxDY.Location = new System.Drawing.Point(973, 96);
            this.textBoxDY.Name = "textBoxDY";
            this.textBoxDY.Size = new System.Drawing.Size(35, 20);
            this.textBoxDY.TabIndex = 11;
            this.textBoxDY.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(934, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "dx";
            // 
            // textBoxDX
            // 
            this.textBoxDX.Location = new System.Drawing.Point(934, 96);
            this.textBoxDX.Name = "textBoxDX";
            this.textBoxDX.Size = new System.Drawing.Size(35, 20);
            this.textBoxDX.TabIndex = 9;
            this.textBoxDX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1012, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "kz";
            // 
            // textBoxKZ
            // 
            this.textBoxKZ.Location = new System.Drawing.Point(1012, 142);
            this.textBoxKZ.Name = "textBoxKZ";
            this.textBoxKZ.Size = new System.Drawing.Size(35, 20);
            this.textBoxKZ.TabIndex = 20;
            this.textBoxKZ.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(973, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ky";
            // 
            // textBoxKY
            // 
            this.textBoxKY.Location = new System.Drawing.Point(973, 142);
            this.textBoxKY.Name = "textBoxKY";
            this.textBoxKY.Size = new System.Drawing.Size(35, 20);
            this.textBoxKY.TabIndex = 18;
            this.textBoxKY.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(934, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "kx";
            // 
            // textBoxKX
            // 
            this.textBoxKX.Location = new System.Drawing.Point(934, 142);
            this.textBoxKX.Name = "textBoxKX";
            this.textBoxKX.Size = new System.Drawing.Size(35, 20);
            this.textBoxKX.TabIndex = 16;
            this.textBoxKX.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 552);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKZ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxKX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxKY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxKX;
    }
}

