using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function that converts degrees to radians
    /// </summary>
    public class GradToRadConverter : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method that converts degrees to radians
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return argument * Math.PI / 180;
        }
    }
}