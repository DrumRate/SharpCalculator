using System;
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

        private void buttonClick(object sender, EventArgs e) {
            double firstArgument = Convert.ToDouble(textBoxInput1.Text.ToString());
            double secondArgument = Convert.ToDouble(textBoxInput2.Text.ToString());
            double result;
            switch (((Button)sender).Name) {
                case "buttonPlus":
                    result = firstArgument + secondArgument;
                    break;
                case "buttonMinus":
                    result = firstArgument - secondArgument;
                    break;
                case "buttonMultiply":
                    result = firstArgument * secondArgument;
                    break;
                case "buttonDivide":
                    result = firstArgument / secondArgument;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

            textBoxOutput.Text = result.ToString();
        }
    }
}
