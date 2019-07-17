using System;
namespace Design_Patterns_Console.Day3.Adapter.DBData
{
    public class BadStore : IDBWebData
    {
        public BadStore()
        {
        }

        public void Store(WebClientData webClientData)
        {
            Console.WriteLine($"writing client data to db: \nID: {webClientData.ID}, name: {webClientData.name} \nIP: {webClientData.IP}, isUsingSSL: {webClientData.isUsingSSL}");
        }
    }
}
