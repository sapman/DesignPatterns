using System;

namespace Test.One
{
    internal class ShipBad : ShipState
    {
        public ShipBad(ShipGame shipGame) : base(shipGame)
        {
        }

        public override void Hit(int damage)
        {
            shipGame.HP -= damage;
            if (shipGame.HP <= 0)
            {
                this.shipGame.ShipState = new ShipLose(this.shipGame);
                Console.WriteLine("You lose");
            }
            else if (this.shipGame.Stage == 3)
            {
                this.shipGame.ShipState = new ShipWin(this.shipGame);
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine($"{shipGame.HP} HP left");
            }
        }
    }
}