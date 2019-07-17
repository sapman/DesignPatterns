using System;
namespace Design_Patterns_Console.Day3.Adapter.DBData
{
    public class ClientData
    {
        public string name { get; set; }
        public int ID { get; set; }

        public ClientData(string name, int ID)
        {
            this.name = name;
            this.ID = ID;
        }
    }
}
