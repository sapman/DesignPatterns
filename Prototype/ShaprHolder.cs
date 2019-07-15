using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    class ShaprHolder: IProtoType<ShaprHolder>
    {
        public List<Shape> lst;

        public ShaprHolder()
        {
            lst = new List<Shape>();
        }
        public Shape this[int index]
        {
            get { return lst[index]; }
            set { lst[index] = value; }
        }

        public void Add(Shape shape)
        {
            lst.Add(shape);
        }

        public ShaprHolder clone()
        {
            ShaprHolder temp = new ShaprHolder();
            foreach (Shape shape in lst)
            {
                temp.Add(shape.clone());
            }
            return temp;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var shape in lst)
            {
                str += shape.ToString() + "\n";
            }
            return str;
        }
    }
}
