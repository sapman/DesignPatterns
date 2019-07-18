using System;
using System.Collections.Generic;
using System.Text;

namespace Test.One
{
    public class ShipGame
    {
        public IShipState ShipState { get; set; }
        public int HP { get; set; }
        public int Stage { get; set; }
        public ShipGame()
        {
            Stage = 0;
            HP = 50;
            ShipState = new ShipGood(this);
        }
        
        public void TakeDamage(int damage)
        {
            ShipState.Hit(damage);
        }

        public void NextStage(int damage=0)
        {
            Stage++;
            Console.WriteLine($"{Stage} stage");
            ShipState.Hit(damage);
        }
    }
}
