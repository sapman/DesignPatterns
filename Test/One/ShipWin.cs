using System;
using System.Collections.Generic;
using System.Text;

namespace Test.One
{
    class ShipWin : ShipState
    {
        public ShipWin(ShipGame shipGame) : base(shipGame)
        {
        }

        public override void Hit(int damage)
        {
            Console.WriteLine("You already won :)");
        }
    }
}
