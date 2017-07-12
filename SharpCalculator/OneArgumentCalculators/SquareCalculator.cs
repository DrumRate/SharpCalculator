namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function of squaring
    /// </summary>
    public class SquareCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method of squaring
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}