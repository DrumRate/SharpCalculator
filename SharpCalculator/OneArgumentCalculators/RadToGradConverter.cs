using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function that converts radians to degrees
    /// </summary>
    public class RadToGradConverter : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method that converts radians to degrees
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
           return argument * 180 / Math.PI;
        }
    }
}