using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class RadToGradConverter : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
           return argument * 180 / Math.PI;
        }
    }
}