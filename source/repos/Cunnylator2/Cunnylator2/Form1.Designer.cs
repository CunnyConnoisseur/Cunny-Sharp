﻿namespace Cunnylator2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Number2 = new System.Windows.Forms.TextBox();
            this.Svar = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(342, 77);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(100, 20);
            this.Number2.TabIndex = 0;
            // 
            // Svar
            // 
            this.Svar.Location = new System.Drawing.Point(201, 238);
            this.Svar.Name = "Svar";
            this.Svar.Size = new System.Drawing.Size(100, 20);
            this.Svar.TabIndex = 1;
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(201, 77);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(100, 20);
            this.Number1.TabIndex = 2;
            this.Number1.TextChanged += new System.EventHandler(this.Number1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(420, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 54);
            this.button4.TabIndex = 6;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Svar);
            this.Controls.Add(this.Number2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.TextBox Svar;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

