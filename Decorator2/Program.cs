using System;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormula f1 = new Mul((Number)5, (Number)2);
            IFormula f2 = new Div((Number)100, (Number)12);
            IFormula f3 = new Mul((Number)3, (Number)4);
            IFormula f4 = new Number(7);
            IFormula formula = new Add(new Sub(new Add(f1, f2),f3),f4);
            Console.WriteLine(formula.ToString() + " = " + formula.GetResult());
            f1 = new Mul((Number)30, (Number)2);
            formula = new Add(new Sub(new Add(f1, f2), f4), f4);
            Console.WriteLine(formula.ToString() + " = " + formula.GetResult());
        }
    }
}
