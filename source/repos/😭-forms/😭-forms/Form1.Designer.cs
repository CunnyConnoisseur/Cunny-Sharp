namespace __forms
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
            SayUohButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // SayUohButton
            // 
            SayUohButton.Location = new Point(122, 201);
            SayUohButton.Name = "SayUohButton";
            SayUohButton.Size = new Size(75, 23);
            SayUohButton.TabIndex = 0;
            SayUohButton.Text = "Say😭";
            SayUohButton.UseVisualStyleBackColor = true;
            SayUohButton.Click += SayUohButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(122, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 50);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(SayUohButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SayUohButton;
        private TextBox textBox1;
    }
}