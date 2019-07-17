using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProxy
{
    class CompanyProxy : ClientProxy, ICompany
    {
        public void CreateFlight()
        {
            FlightSystemFacade facade = new FlightSystemFacade();
            facade.CreateFlight();
        }

        public void RemoveFlight()
        {
            FlightSystemFacade facade = new FlightSystemFacade();
            facade.RemoveFlight();
        }
    }
}
