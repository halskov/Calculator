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

        //Division
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                DivideByZeroException ex = new DivideByZeroException();
                throw ex;
            }
            return a / b;
        }

        public double Add(double addend)
        {
            return addend + Accumulator;
        }

        public double Subtract(double subtractor)
        {
            return  Accumulator - subtractor;
        }

        public double Multiply(double multiplier)
        {
            return multiplier * Accumulator;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                DivideByZeroException ex = new DivideByZeroException();
                throw ex;
            }
            return  Accumulator / divisor;
        }

        public double Power(double exponent)
        {
            return Math.Pow(Accumulator, exponent);
        }
    }

}
