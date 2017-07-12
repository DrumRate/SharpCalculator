using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ArcCosineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            if ((argument < -1) || (argument > 1))
                throw new Exception("Недопустимые входные данные");
            return Math.Acos(argument);
        }
    }
}