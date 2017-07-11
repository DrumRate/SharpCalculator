using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class GradToRadConverter : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return argument * Math.PI / 180;
        }
    }
}