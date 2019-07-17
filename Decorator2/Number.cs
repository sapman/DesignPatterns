using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class Number : IFormula
    {
        double num;
        public Number(double num)
        {
            this.num = num;
        }

        public double GetResult()
        {
            return num;
        }

        public override string ToString()
        {
            return num.ToString();
        }

        public static explicit operator Number(double d)
        {
            return new Number(d);
        }
    }
}
