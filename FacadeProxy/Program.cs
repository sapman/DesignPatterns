using System;

namespace FacadeProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory factory = new ProxyFactory();
            CustomerProxy cup = (CustomerProxy)factory.Login("Sapir", "lol");

            cup.BuyTicket();
            cup.ShowTickets();

            CompanyProxy cop = (CompanyProxy)factory.Login("Company", "lol");

            cop.CreateFlight();
            cop.RemoveFlight();

            AdminProxy ap = (AdminProxy)factory.Login("Admin", "lol");

            ap.CreateCompany();
            ap.CreateCustomer();
        }
    }
}
