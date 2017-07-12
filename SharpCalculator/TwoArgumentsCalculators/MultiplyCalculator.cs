namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Function of multiplying the first argument by the second argument
    /// </summary>
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Method of multiplying the first argument by the second argument
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
