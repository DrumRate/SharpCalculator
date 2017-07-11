using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "add":
                    return new AdditionCalculator();
                case "substract":
                    return new SubstractionCalculator();
                case "multiply":
                    return new MultiplyCalculator();
                case "divide":
                    return new DivisionCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
