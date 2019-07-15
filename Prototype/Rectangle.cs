using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    public class Rectangle : Shape
    { 
        private Point topLeft, bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public override string ToString()
        {
            return $"Rectangle: {topLeft}, {bottomRight}";
        }

        public override Shape clone()
        {
            return new Rectangle(topLeft.clone(), bottomRight.clone());
        }
    }
}
