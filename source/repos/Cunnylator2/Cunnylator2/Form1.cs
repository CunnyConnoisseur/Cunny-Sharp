using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cunnylator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Ans = 0.0;


        private void button1_Click(object sender, EventArgs e)
        {
           Svar.Clear();
           Ans = (Convert.ToDouble(Number1.Text) + Convert.ToDouble(Number2.Text));
           Svar.Text = Ans.ToString();
        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Svar.Clear();
            Ans = (Convert.ToDouble(Number1.Text) - Convert.ToDouble(Number2.Text));
            Svar.Text = Ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Svar.Clear();
            Ans = (Convert.ToDouble(Number1.Text) / Convert.ToDouble(Number2.Text));
            Svar.Text = Ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Svar.Clear();
            Ans = (Convert.ToDouble(Number1.Text) * Convert.ToDouble(Number2.Text));
            Svar.Text = Ans.ToString();
        }

        private void Number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Svar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
