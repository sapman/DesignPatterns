using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Ten
{
    public class ColorfulOutline : WindowDecorator
    {
        public ColorfulOutline(Window window) : base(window)
        {
        }

        public override string ToString() => window.ToString() + " with colorful outline";
    }
}
