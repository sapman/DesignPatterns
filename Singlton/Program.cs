using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock[] clocks = new Clock[] {Clock.GetInstance(), Clock.GetInstance(), Clock.GetInstance()};

            foreach (Clock clock in clocks)
            {
                clock.PrintTime();
            }
        }
    }
}
