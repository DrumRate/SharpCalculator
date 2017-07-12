using System;
using System.Globalization;
using System.Windows.Forms;
using SharpCalculator.OneArgumentCalculators;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TwoArgumentOperationButtonClick(object sender, EventArgs e)
        {
            var firstArgument = Convert.ToDouble(firstInputField.Text);
            var secondArgument = Convert.ToDouble(secondInputField.Text);
            var calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            var result = calculator.Calculate(firstArgument, secondArgument);
            outputField.Text = result.ToString(CultureInfo.InvariantCulture);
        }

        private void OneArgumentOperationButtonClick(object sender, EventArgs e)
        {
            try
            {
                var argument = Convert.ToDouble(firstInputField.Text);
                var calculator = OneArgumentFactory.CreateCalculator(((Button) sender).Name);
                var result = calculator.Calculate(argument);
                outputField.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            catch (DivideByZeroException exception)
            {
//                MessageBox msgBox = new MessageBox("Divide by Zero");
            }
        }
    }
}
