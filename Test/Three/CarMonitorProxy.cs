using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Three
{
    class CarMonitorProxy : IMonitorable
    {
        public CarMonitorProxy()
        {

        }

        public void GetPosition()
        {
            Car c = new Car();
            c.GetPosition();
        }

        public void GetTankStatus()
        {
            Car c = new Car();
            c.GetTankStatus();
        }
    }
}
