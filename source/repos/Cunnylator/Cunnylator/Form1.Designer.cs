namespace Cunnylator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonminus = new Button();
            buttonplus = new Button();
            buttonequal = new Button();
            buttonmultiplication = new Button();
            buttondivide = new Button();
            textBox1 = new TextBox();
            button0 = new Button();
            buttonClear = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(44, 75);
            button1.Name = "button1";
            button1.Size = new Size(98, 82);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 75);
            button2.Name = "button2";
            button2.Size = new Size(98, 82);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(252, 75);
            button3.Name = "button3";
            button3.Size = new Size(98, 82);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(44, 163);
            button4.Name = "button4";
            button4.Size = new Size(98, 82);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(148, 163);
            button5.Name = "button5";
            button5.Size = new Size(98, 82);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(252, 163);
            button6.Name = "button6";
            button6.Size = new Size(98, 82);
            button6.TabIndex = 3;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(44, 251);
            button7.Name = "button7";
            button7.Size = new Size(98, 82);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(148, 251);
            button8.Name = "button8";
            button8.Size = new Size(98, 82);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(252, 251);
            button9.Name = "button9";
            button9.Size = new Size(98, 82);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonminus
            // 
            buttonminus.Location = new Point(459, 163);
            buttonminus.Name = "buttonminus";
            buttonminus.Size = new Size(98, 82);
            buttonminus.TabIndex = 9;
            buttonminus.Text = "-";
            buttonminus.UseVisualStyleBackColor = true;
            buttonminus.Click += buttonMinus_Click;
            // 
            // buttonplus
            // 
            buttonplus.Location = new Point(459, 251);
            buttonplus.Name = "buttonplus";
            buttonplus.Size = new Size(98, 82);
            buttonplus.TabIndex = 10;
            buttonplus.Text = "+";
            buttonplus.UseVisualStyleBackColor = true;
            buttonplus.Click += buttonPlus_Click;
            // 
            // buttonequal
            // 
            buttonequal.Location = new Point(459, 339);
            buttonequal.Name = "buttonequal";
            buttonequal.Size = new Size(202, 82);
            buttonequal.TabIndex = 11;
            buttonequal.Text = "=";
            buttonequal.UseVisualStyleBackColor = true;
            buttonequal.Click += buttonEqual_Click;
            // 
            // buttonmultiplication
            // 
            buttonmultiplication.Location = new Point(563, 251);
            buttonmultiplication.Name = "buttonmultiplication";
            buttonmultiplication.Size = new Size(98, 82);
            buttonmultiplication.TabIndex = 13;
            buttonmultiplication.Text = "*";
            buttonmultiplication.UseVisualStyleBackColor = true;
            buttonmultiplication.Click += buttonMultiplication_Click;
            // 
            // buttondivide
            // 
            buttondivide.Location = new Point(563, 163);
            buttondivide.Name = "buttondivide";
            buttondivide.Size = new Size(98, 82);
            buttondivide.TabIndex = 12;
            buttondivide.Text = "/";
            buttondivide.UseVisualStyleBackColor = true;
            buttondivide.Click += buttonDivide_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(618, 23);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button0
            // 
            button0.Location = new Point(148, 339);
            button0.Name = "button0";
            button0.Size = new Size(98, 82);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(459, 75);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(202, 82);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += button1C_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(801, 449);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(button0);
            Controls.Add(textBox1);
            Controls.Add(buttonmultiplication);
            Controls.Add(buttondivide);
            Controls.Add(buttonequal);
            Controls.Add(buttonplus);
            Controls.Add(buttonminus);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Cunnylator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonminus;
        private Button buttonplus;
        private Button buttonequal;
        private Button buttonmultiplication;
        private Button buttondivide;
        private TextBox textBox1;
        private Button button0;
        private Button buttonClear;
        private PictureBox pictureBox2;
    }
}