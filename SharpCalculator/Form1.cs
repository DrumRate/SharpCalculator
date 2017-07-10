using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = (Convert.ToDouble(textBoxInput1.Text.ToString()) + Convert.ToDouble(textBoxInput2.Text.ToString())).ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = (Convert.ToDouble(textBoxInput1.Text.ToString()) - Convert.ToDouble(textBoxInput2.Text.ToString())).ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = (Convert.ToDouble(textBoxInput1.Text.ToString()) * Convert.ToDouble(textBoxInput2.Text.ToString())).ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = (Convert.ToDouble(textBoxInput1.Text.ToString()) / Convert.ToDouble(textBoxInput2.Text.ToString())).ToString();
        }
    }
}
