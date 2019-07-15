using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    class ShapeContainer: IProtoType<ShapeContainer>
    {
        public List<Shape> lst;

        public ShapeContainer()
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

        public ShapeContainer clone()
        {
            ShapeContainer temp = new ShapeContainer();
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
