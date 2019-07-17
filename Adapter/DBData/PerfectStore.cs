using System;
namespace Design_Patterns_Console.Day3.Adapter.DBData
{
    public class PerfectStore : IDBData
    {
        public PerfectStore()
        {
        }

        public void Store(ClientData clientData)
        {
            Console.WriteLine($"writing client data to db: \nID: {clientData.ID}, name: {clientData.name}");
        }
    }
}
