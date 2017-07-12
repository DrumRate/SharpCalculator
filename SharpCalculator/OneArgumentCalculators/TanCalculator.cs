using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class TanCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            if ((argument.Equals(Math.PI / 2)) || (argument.Equals(3 * Math.PI / 2)))
                throw new Exception("Недопустимое значение");
            return Math.Tan(argument);
        }
    }
}