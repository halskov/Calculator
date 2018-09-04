using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        /*
         * Addition
         */
        [TestCase(2, 4, 6)]
        [TestCase(-10, 6, -4)]
        [TestCase(-10, -12, -22)]
        public void Add_Test(double a, double b, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        /*
         * Addition Overload
         */
        [TestCase(2, 4, 2, 8)]
        [TestCase(-10, 4, 2, -4)]
        [TestCase(-10, 2, -4, -12)]
        public void Add_Overload_Test(double a, double b, double c, double result)
        {
            var uut = new Calculator();
            uut.Clear();
            uut.Add(a, b);
            Assert.That(uut.Add(c), Is.EqualTo(result));
        }

        /*
         * Subtraction
         */
        [TestCase(2, 4, -2)]
        [TestCase(10, 1, 9)]
        [TestCase(-10, -12, 2)]
        public void Subtract_Test(double a, double b, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        /*
         * Multiplication
         */
        [TestCase(2, 4, 8.0)]
        [TestCase(0.5, 150, 75.0)]
        [TestCase(-10, 5, -50.0)]
        public void Multiply_Test(double a, double b, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        /*
         * Division
         */
        [TestCase(2, 4, 0.5)]
        [TestCase(0.5, -0.5, -1.0)]
        [TestCase(-200, -10, 20.0)]
        public void Divide_Test(double a, double b, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 0)]
        [TestCase(-100, 0)]
        [TestCase(0, 0)]
        public void Divide_Test_DivideByZeroException(double a, double b)
        {
            var uut = new Calculator();
            Assert.That(() => uut.Divide(a, b), Throws.TypeOf<DivideByZeroException>());
        }

        /*
         * Power
         */
        [TestCase(2, 4, 16.0)]
        [TestCase(-2, 3, -8)]
        [TestCase(2, -2, 0.25)]
        public void Power_Test(double a, double b, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        [TestCase(-2, 0.25)]
        public void Power_Test_Exception(double a, double b)
        {
            var uut = new Calculator();
            Assert.That(() => uut.Power(a,b), Throws.TypeOf<ArithmeticException>());
        }

        /*
         * Factorial
         */
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(7, 5040)]
        public void Factorial_Test(double a, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Factorial(a), Is.EqualTo(result));
        }

        [TestCase(10.17)]
        [TestCase(-14)]
        public void Factorial_Test_Exception(double a)
        {
            var uut = new Calculator();
            Assert.That(() => uut.Factorial(a), Throws.TypeOf<ArithmeticException>());
        }


        /*
         * Square Root
         */
        [TestCase(4, 2)]
        [TestCase(6, 2.4494897427831779)]
        [TestCase(2.5, 1.5811388300841898)]
        public void Sqrt_Test(double a, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Sqrt(a), Is.EqualTo(result));
        }

        [TestCase(-4)]
        [TestCase(-10.17)]
        public void Sqrt_Test_Exception(double a)
        {
            var uut = new Calculator();
            Assert.That(() => uut.Sqrt(a), Throws.TypeOf<ArithmeticException>());
        }

    }
}
