using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ArcCosineGradCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            if ((argument < -1) || (argument > 1))
                throw new Exception("Недопустимые входные данные");
            var converter = new RadToGradConverter();
            var calculator = new ArcCosineCalculator();
            return converter.Calculate(calculator.Calculate(argument));
        }
    }
}