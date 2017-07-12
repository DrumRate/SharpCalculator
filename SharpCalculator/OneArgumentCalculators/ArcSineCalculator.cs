using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ArcSineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            if ((argument < -1) || (argument > 1))
                throw new Exception("Недопустимые входные данные");
            return Math.Asin(argument);
        }
    }
}