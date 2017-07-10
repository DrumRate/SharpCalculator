using System;
using System.Globalization;
using System.Windows.Forms;

namespace SharpCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void TwoArgumentOperationButtonClick(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBoxInput1.Text);
            double secondArgument = Convert.ToDouble(textBoxInput2.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument, secondArgument);
            textBoxOutput.Text = result.ToString(CultureInfo.InvariantCulture);
        }
    }
}
