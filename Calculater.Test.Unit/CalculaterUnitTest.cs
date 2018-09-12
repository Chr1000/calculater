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

        [Test]
        public void Add_Add2and4return6()
        {
            Assert.That(uut.Add(2, 4), Is.EqualTo(6));
        }

        [Test]
        public void Subtract_Substract6and4_return2()
        {
            Assert.That(uut.Subtract(6, 4), Is.EqualTo(2));
        }

        [Test]
        public void Multiply_4and3_return12()
        {
            Assert.That(uut.Multiply(3, 4), Is.EqualTo(12));
        }

        [Test]
        public void Divide_10and5_return2()
        {
            Assert.That(uut.Divide(10, 5), Is.EqualTo(2));
        }

        [Test]
        public void Power_3and3_return27()
        {
            Assert.That(uut.Power(3, 3), Is.EqualTo(27));
        }

        [Test]
        public void Accumulator_3addto3_Acc6()
        {
            uut.Clear();
            uut.Add(3, 3);
            bool result = uut.Accumulator == 3 + 3;
            Assert.IsTrue(result);
        }

        [Test]
        public void Accumulator_clear()
        {
            uut.Clear();
            uut.Add(5, 5);
            uut.Clear();
            bool result = uut.Accumulator == 0;
            Assert.IsTrue(result);
        }

    }

}
 