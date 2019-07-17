using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProxy
{
    public class AdminProxy : ClientProxy, IAdmin
    {
        public void CreateCompany()
        {
            FlightSystemFacade facade = new FlightSystemFacade();
            facade.CreateCompany();
        }

        public void CreateCustomer()
        {
            FlightSystemFacade facade = new FlightSystemFacade();
            facade.CreateCustomer();
        }
    }
}
