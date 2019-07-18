using System;
using System.Collections.Generic;
using System.Text;

namespace Test.One
{
    public abstract class ShipState : IShipState
    {
        protected ShipGame shipGame;

        public ShipState(ShipGame shipGame)
        {
            this.shipGame = shipGame;
        }

        public abstract void Hit(int damage);
    }
}
