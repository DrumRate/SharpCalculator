namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    /// 
    /// </summary>
    public class ArithmeticCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument) / 2;
        }
    }
}