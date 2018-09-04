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
            return Accumulator = a + b;
        }

        public double Add(double addend)
        {
            return Add(addend, Accumulator);
        }

        // Subtraction
        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Subtract(double subtractor)
        {
            return Subtract(Accumulator, subtractor);
        }

        // Multiplication
        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Multiply(double multiplier)
        {
            return Multiply(multiplier, Accumulator);
        }

        // Power
        public double Power(double x, double exp)
        {
            if (x < 0 && exp != Math.Floor(exp))
            {
                ArithmeticException ex = new ArithmeticException("Cannot raise a negative number to a fractional exponent.");
                throw ex;
            }
            else
            {
                return Accumulator = Math.Pow(x, exp);
            }
        }

        public double Power(double exponent)
        {
            return Power(Accumulator, exponent);
        }

        // Factorial
        public double Factorial(double number)
        {
            // Check if integer
            if ((number % 1) == 0)
            {
                double result = 1;
                while ((int)number != 1)
                {
                    result *= number;
                    number--;
                }

                Accumulator = result;
                return result;
            }
            else
            {
                ArithmeticException ex = new ArithmeticException("Cannot do factorial of non-integer number");
                throw ex;
            }
        }

        public double Factorial()
        {
            return Factorial(Accumulator);
        }

        //Division
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                DivideByZeroException ex = new DivideByZeroException();
                throw ex;
            }
            return Accumulator = a / b;
        }

        public double Divide(double divisor)
        {
            return Divide(Accumulator, divisor);
        }

        // Sqarte Root
        public double Sqrt(double a)
        {
            if (a < 0)
            {
                ArithmeticException ex = new ArithmeticException("Cannot take sqaure root of negative number.");
                throw ex;
            }
            else
            {
                return Accumulator = Math.Sqrt(a);
            }
        }

        public double Sqrt()
        {
            return Sqrt(Accumulator);
        }
 
    }

}
