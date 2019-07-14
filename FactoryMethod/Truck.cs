using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Truck : Vehicle
    {

        private string truckData;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string truckData) : base(model, cylinder, color, numberOfWheels)
        {
            this.truckData = truckData;
        }

        public override string ToString()
        {
            return "Truck : " + base.ToString() + $"{ truckData }";
        } 
    }
}
