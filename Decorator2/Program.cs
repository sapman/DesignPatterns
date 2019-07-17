using System;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormula formula = new Sub(new Add(new Mul((Number)5.0, (Number)2.0), new Div((Number)100, (Number)12)), new Add(new Mul((Number)3, (Number)4), (Number)7));
            Console.WriteLine(formula.ToString() + " = " + formula.GetResult());

            formula = new Sub(new Add(new Mul((Number)30, (Number)2.0), new Div((Number)100, (Number)12)), new Add(new Mul((Number)3, (Number)4), (Number)7));
            Console.WriteLine(formula.ToString() + " = " + formula.GetResult());
        }
    }
}
