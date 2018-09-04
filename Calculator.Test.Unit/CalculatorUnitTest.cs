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
        [TestCase(2, 4, 6)]
        [TestCase(-10, 6, -4)]
        [TestCase(-10, -12, -22)]
        public void AddNumbers(double a, double b, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [Test]
        public void Add_AddMinus2And4_Return2()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(-2, 4), Is.EqualTo(2));
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


        [TestCase(4, 2)]
        [TestCase(6, 2.4494897427831779)]
        [TestCase(2.5, 1.5811388300841898)]
        public void Sqrt_Test(double a, double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Sqrt(a), Is.EqualTo(result));
        }

        [Test]
        public void Sqrt_TestException()
        {
            var uut = new Calculator();
            Assert.That(() => uut.Sqrt(-4), Throws.TypeOf<ArithmeticException>());
        }

    }
}
