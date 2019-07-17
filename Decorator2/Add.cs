using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class Add : BaseFormulaDecorator
    {
        public Add(IFormula num1, IFormula num2) : base(num1, num2)
        {
        }

        public override double GetResult()
        {
            return num1.GetResult() + num2.GetResult();
        }

        public override string ToString()
        {
            return $"{num1.ToString()} + {num2.ToString()}"; 
        }
    }
}
