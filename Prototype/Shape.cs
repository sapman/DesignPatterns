using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    public abstract class Shape : IProtoType<Shape>
    {
        public abstract Shape clone();
    }
}
