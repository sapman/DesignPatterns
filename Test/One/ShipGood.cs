using System;
using System.Collections.Generic;
using System.Text;

namespace Test.One
{
    public class ShipGood : ShipState
    {
        public ShipGood(ShipGame shipGame) : base(shipGame)
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
            else if (shipGame.HP <= 10 && this.shipGame.Stage < 3)
            {
                this.shipGame.ShipState = new ShipBad(this.shipGame);
                Console.WriteLine("Danger");
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
