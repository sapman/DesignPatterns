using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProxy
{
    public class FlightSystemFacade : IAdmin, ICompany, ICustomer
    {
        FlightDAO flightDAO;
        public FlightSystemFacade()
        {
            flightDAO = new FlightDAO();
        }

        public void CreateFlight()
        {
            flightDAO.InsertFlight();
        }

        public void BuyTicket()
        {
            flightDAO.InsertTicket();
        }

        public void CreateCustomer()
        {
            flightDAO.InsertCustomer();
        }

        public void CreateCompany()
        {
            flightDAO.InsertCompany();
        }

        public void RemoveFlight()
        {
            flightDAO.RemoveFlight();
        }

        public void ShowTickets()
        {
            flightDAO.GetTickets();
        }
    }
}
