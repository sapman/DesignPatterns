using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Unicycle : Vehicle
    {
        private string unicycleData;

        public Unicycle(string model, float cylinder, string color, int numberOfWheels, string unicycleData) : base(model, cylinder, color, numberOfWheels)
        {
            this.unicycleData = unicycleData;
        }

        public override string ToString()
        {
            return "Unicycle : " + base.ToString() + $"{ unicycleData }";
        }
    }
}
