namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function calculates the reciprocal of the number
    /// </summary>
    public class InvertCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method calculates the reciprocal of the number
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return -argument;
        }
    }
}