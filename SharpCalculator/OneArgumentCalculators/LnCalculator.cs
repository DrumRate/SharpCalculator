using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class LnCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            if (argument <= 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Log(argument, Math.E);
        }
    }
}
