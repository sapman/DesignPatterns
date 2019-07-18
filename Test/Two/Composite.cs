using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Two
{
    public class Composite : Component
    {

        IList<Component> childs = new List<Component>();

        public Composite(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.Number);
            foreach (Component c in childs)
            {
                c.Draw(space + "    ");
            }
        }

        public override int Sum()
        {
            int s = this.Number;
            foreach (Component c in childs)
            {
                s += c.Sum();
            }
            return s;
        }
    }
}