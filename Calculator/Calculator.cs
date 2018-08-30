using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
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
    }
}
