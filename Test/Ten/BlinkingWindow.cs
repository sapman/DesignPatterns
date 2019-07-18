using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Ten
{
    class BlinkingWindow : WindowDecorator
    {
        public BlinkingWindow(Window window) : base(window)
        {
        }

        public override string ToString() => window.ToString() + " with blinking lights";
    }
}
