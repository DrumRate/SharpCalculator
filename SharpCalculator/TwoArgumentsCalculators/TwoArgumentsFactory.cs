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
                case "exp_xy":
                    return new DoubleExponentalCalculator();
                case "exp_xy_rev":
                    return new DoubleExponentalReversiveCalculator();
                case "logxy":
                    return new LogBasementCalculator();
                case "radius":
                    return new RadialSystemRadiusCalculator();
                case "angle":
                    return new RadialSystemAngleCalculator();
                case "minimum":
                    return new MinCalculator();
                case "maximum":
                    return new MaxCalculator();
                case "remain":
                    return new RemainderCalculator();
                case "integer":
                    return new IntegerCalculator();
                case "arith":
                    return new ArithmeticCalculator();
                case "geom":
                    return new GeometricCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
