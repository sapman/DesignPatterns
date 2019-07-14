using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmBroken : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Not broken broken broken!");
            return new IAmOff();
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("I am broken!");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("I am broken broken broken!");
            return this;
        }
    }
}
