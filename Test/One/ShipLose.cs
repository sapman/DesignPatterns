using System;
using System.Collections.Generic;
using System.Text;

namespace Test.One
{
    public class ShipLose : ShipState
    {
        public ShipLose(ShipGame shipGame) : base(shipGame)
        {
        }

        public override void Hit(int damage)
        {
            Console.WriteLine("You already lost :(");
        }
    }
}
