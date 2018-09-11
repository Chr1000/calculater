using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{

    public class Calculater
    {
        public double Accumulator {get; private set; }

        public double Add(double a, double b)
        {
            Accumulator.set = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Accumulator.set = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Accumulator.set = a * b;
            return a * b;
        }

        public double Divide(double a, double b)
        {
            Accumulator.set = a / b;
            return a / b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
