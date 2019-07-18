using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Two
{
    public abstract class Component
    {
        public int Number { get; private set; }
        public Component(int number)
        {
            Number = number;
        }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract void Draw(string space);

        public abstract int Sum();

        public static bool IsEven(Component component)
        {
            if (component.Number % 2 != 0)
                return false;
            IList<Component> childs = component.GetChilds();
            if (childs != null)
            {
                foreach (Component c in childs)
                {
                    if (!IsEven(c))
                        return false;
                }
            }
            return true;
        }
    }
}
