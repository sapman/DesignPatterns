using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Three
{
    public class Car : ICar, IMonitorable
    {
        public void GetPosition()
        {
            Console.WriteLine("Im here");
        }

        public void GetTankStatus()
        {
            Console.WriteLine("Full Trunk :)");
        }

        public void Left()
        {
            Console.WriteLine("Bad");
        }

        public void Right()
        {
            Console.WriteLine("Good");
        }

        public void SpeedDown()
        {
            Console.WriteLine("Too Slow!");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Too Fast!");
        }

        public void Start()
        {
            Console.WriteLine("Voooooom Voooooom");
        }

        public void Stop()
        {
            Console.WriteLine("Cya");
        }
    }
}
