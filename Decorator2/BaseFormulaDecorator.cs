using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public abstract class BaseFormulaDecorator : IFormula
    {
        protected IFormula num1, num2;

        protected BaseFormulaDecorator(IFormula num1, IFormula num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public abstract double GetResult();
    }
}
