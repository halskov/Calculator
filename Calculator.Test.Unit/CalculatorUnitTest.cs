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

        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(7, 5040)]
        public void Factorial_Test(double a, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Factorial(a), Is.EqualTo(result));
        }



        [Test]
        public void Divide_Divide4by2_Return2()
        {
            var uut = new Calculator();
            Assert.That(uut.Divide(4, 2), Is.EqualTo(2));
        }

        [Test]
        public void DivideByZeroException()
        {
            var uut = new Calculator();
            Assert.That(() => uut.Divide(2,0),Throws.TypeOf<DivideByZeroException>());
        }
    }
}
