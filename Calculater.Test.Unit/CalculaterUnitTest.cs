using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculater.Test.Unit
{
    [TestFixture]
    public class CalculaterUnitTest
    {
        private Calculater uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculater();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        public void Add_Add2and4return6(int a, int b, int result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_Substract6and4_return2(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        public void Multiply_4and3_return12(int a, int b, int result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(10, 5, 2)]
        [TestCase(15, 5, 3)]
        [TestCase(8, 2, 4)]
        public void Divide_10and5_return2(int a, int b, int result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(4, 2, 16)]
        public void Power_3and3_return27(int a, int b, int result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        [TestCase(10, 5, 15)]
        [TestCase(15, 5, 20)]
        [TestCase(8, 2, 10)]
        public void Accumulator_3addto3_Acc6(int a, int b, double result)
        {
            uut.Clear();
            uut.Add(a, b);
            bool sumResult = uut.Accumulator == result;
            Assert.IsTrue(sumResult);
        }

        [TestCase(10, 5, 0)]
        [TestCase(15, 5, 0)]
        [TestCase(8, 2, 0)]
        public void Accumulator_clear(int a, int b, double result)
        {
            uut.Clear();
            uut.Add(a, b);
            uut.Clear();
            bool sumResult = uut.Accumulator == result;
            Assert.IsTrue(sumResult);
        }

    }

}
 