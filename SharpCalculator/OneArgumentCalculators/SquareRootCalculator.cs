﻿using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class SquareRootCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Pow(argument, 0.5);
        }
    }
}