using System;
namespace Design_Patterns_Console.Day3.Adapter.DBData
{
    public class WebClientData
    {
        public string name { get; set; }
        public int ID { get; set; }
        public string IP { get; set; }
        public Boolean isUsingSSL { get; set; }

        public WebClientData(string name, int ID,string IP,Boolean isUsingSSL)
        {
            this.name = name;
            this.ID = ID;
            this.IP = IP;
            this.isUsingSSL = isUsingSSL;
        }
    }
}
