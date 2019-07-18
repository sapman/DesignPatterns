using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Ten
{
    public abstract class WindowDecorator : Window
    {
        protected Window window;

        public WindowDecorator(Window window)
        {
            this.window = window ?? throw new ArgumentNullException(nameof(window));
        }
    }
}
