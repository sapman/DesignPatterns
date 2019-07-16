using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ShopRent : IVisitable
    {
        public double Price { get; protected set; }
        public ShopRent(double price)
        {
            Price = price;
        }
        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
