﻿using System;
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
    }
}
