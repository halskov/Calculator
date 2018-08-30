using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        // Accumulator which stores the result of the previous calculation.
        // Default value is 0.
        public double Accumulator { get; private set; } = 0;

        // Clears the accumulator to 0
        public void Clear()
        {
            Accumulator = 0;
        }

        // Addition
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtraction
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplication
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Power
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
    }
}
