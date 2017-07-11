using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class CosineGradCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            var converter = new GradToRadConverter();
            var calculator = new CosineCalculator();
            return calculator.Calculate(converter.Calculate(argument));
        }
    }
}