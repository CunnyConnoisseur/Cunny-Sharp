using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CunnyGrouping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> namn = new List<string>();

        Int32 mengde = 1;

        private void textBoxEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mengde = Convert.ToInt32(textBoxAmount.Text);
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGenerator_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnterNames_Click(object sender, EventArgs e)
        {
            namn.Add(textBoxEnter.Text);
            textBoxEnter.Clear();
            textBoxGenerator.Text = namn;
        }
    }
}
