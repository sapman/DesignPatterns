using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Two
{
    public class Leaf : Component
    {
        public Leaf(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf elemnt cannot add child!");
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.Number);
        }

        public override int Sum()
        {
            return Number;
        }
    }
}
