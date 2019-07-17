using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProxy
{
    public class CustomerProxy : ClientProxy, ICustomer
    {
        public void BuyTicket()
        {
            FlightSystemFacade facade =  new FlightSystemFacade();
            facade.BuyTicket();
        }

        public void ShowTickets()
        {
            FlightSystemFacade facade = new FlightSystemFacade();
            facade.ShowTickets();
        }
    }
}
