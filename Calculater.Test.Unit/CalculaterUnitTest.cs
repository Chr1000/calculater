﻿using System;
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
        [Test]
        public void Add_Add2and4return6()
        {
            var uut = new Calculater();
            Assert.That(uut.Add(2, 4), Is.EqualTo(6));
        }

        [Test]
        public void Subtract_Substract6and4_return2()
        {
            var uut = new Calculater();
            Assert.That(uut.Subtract(6, 4), Is.EqualTo(2));
        }

        [Test]
        public void Multiply_4and3_return12()
        {
            var uut = new Calculater();
            Assert.That(uut.Multiply(3, 4), Is.EqualTo(12));
        }

        [Test]
        public void Divide_10and5_return2()
        {
            var uut = new Calculater();
            Assert.That(uut.Divide(10, 5), Is.EqualTo(2));
        }

        [Test]
        public void Power_3and3_return27()
        {
            var uut = new Calculater();
            Assert.That(uut.Power(3, 3), Is.EqualTo(27));
        }

        [Test]
        public void Accumulator_3addto3_Acc6()
        {
            var uut = new Calculater();
            Assert.That(uut.Add(3, 3), uut.Accumulator.EqualTo(6));
        }

        [Test]
        public void Accumulator_clear()
        {
            var uut = new Calculater();
            Assert.That(uut.Add(3, 3), uut.Accumulator.EqualTo(6));
            Assert.That(uut.Clear, uut.Accumulator.EqualTo(0));
        }

    }

}
 