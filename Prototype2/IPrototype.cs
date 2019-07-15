using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
