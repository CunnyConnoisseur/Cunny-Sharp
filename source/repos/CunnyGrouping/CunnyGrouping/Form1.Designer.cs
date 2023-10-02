namespace CunnyGrouping
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.textBoxGenerator = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnterNames = new System.Windows.Forms.Button();
            this.buttonEnterGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(528, 92);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(186, 65);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(69, 115);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(275, 20);
            this.textBoxEnter.TabIndex = 2;
            this.textBoxEnter.TextChanged += new System.EventHandler(this.textBoxEnter_TextChanged);
            // 
            // textBoxGenerator
            // 
            this.textBoxGenerator.Location = new System.Drawing.Point(439, 163);
            this.textBoxGenerator.Name = "textBoxGenerator";
            this.textBoxGenerator.ReadOnly = true;
            this.textBoxGenerator.Size = new System.Drawing.Size(275, 20);
            this.textBoxGenerator.TabIndex = 3;
            this.textBoxGenerator.TextChanged += new System.EventHandler(this.textBoxGenerator_TextChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(69, 280);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(275, 20);
            this.textBoxAmount.TabIndex = 4;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter names";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter group amount";
            // 
            // buttonEnterNames
            // 
            this.buttonEnterNames.Location = new System.Drawing.Point(69, 147);
            this.buttonEnterNames.Name = "buttonEnterNames";
            this.buttonEnterNames.Size = new System.Drawing.Size(69, 36);
            this.buttonEnterNames.TabIndex = 7;
            this.buttonEnterNames.Text = "Enter";
            this.buttonEnterNames.UseVisualStyleBackColor = true;
            // 
            // buttonEnterGroup
            // 
            this.buttonEnterGroup.Location = new System.Drawing.Point(69, 325);
            this.buttonEnterGroup.Name = "buttonEnterGroup";
            this.buttonEnterGroup.Size = new System.Drawing.Size(69, 36);
            this.buttonEnterGroup.TabIndex = 8;
            this.buttonEnterGroup.Text = "Enter";
            this.buttonEnterGroup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEnterGroup);
            this.Controls.Add(this.buttonEnterNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxGenerator);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "GroupGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.TextBox textBoxGenerator;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnterNames;
        private System.Windows.Forms.Button buttonEnterGroup;
    }
}

