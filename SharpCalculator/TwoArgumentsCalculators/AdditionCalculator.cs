namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    ///     Function of adding the two arguments
    /// </summary>
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        ///     Method of adding the 2 arguments
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}