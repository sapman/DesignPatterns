using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Ten
{
    public class ShadowWindow : WindowDecorator
    {
        public ShadowWindow(Window window) : base(window)
        {
        }

        public override string ToString() => window.ToString() + " with shadows";
    }
}
