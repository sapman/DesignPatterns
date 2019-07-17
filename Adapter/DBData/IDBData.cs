using System;
namespace Design_Patterns_Console.Day3.Adapter.DBData
{
    public interface IDBData
    {
        void Store(ClientData clientData);
    }
}
