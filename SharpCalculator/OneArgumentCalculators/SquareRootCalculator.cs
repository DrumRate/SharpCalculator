using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class SquareRootCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            if (argument < 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Pow(argument, 0.5);
        }
    }
}