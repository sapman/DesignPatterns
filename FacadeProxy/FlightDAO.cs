using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProxy
{
    public class FlightDAO
    {
        public void InsertTicket()
        {
            Console.WriteLine("Ticket inserted :)");
        }

        public void GetTickets()
        {
            Console.WriteLine("Here are the Tickets...");
        }

        public void InsertFlight()
        {
            Console.WriteLine("Flight inserted :)");
        }

        public void RemoveFlight()
        {
            Console.WriteLine("Removing the flight :(");
        }

        public void InsertCustomer()
        {
            Console.WriteLine("Customer inserted :)");
        }

        public void InsertCompany()
        {
            Console.WriteLine("Company inserted :)");
        }
    }
}
