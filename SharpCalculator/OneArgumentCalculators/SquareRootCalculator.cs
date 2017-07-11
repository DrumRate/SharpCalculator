namespace SharpCalculator.OneArgumentCalculators
{
    public class SquareRootCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}