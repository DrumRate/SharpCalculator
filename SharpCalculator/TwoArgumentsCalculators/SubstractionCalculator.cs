namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Function of subtracting the first argument from the second argument
    /// </summary>
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Method of subtracting the first argument from the second argument
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
