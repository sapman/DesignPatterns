using System;
namespace Design_Patterns_Console.Day3.Adapter.DBData
{
    public class BadStoreToPerfectStoreAdapter : IDBWebData
    {
        public BadStoreToPerfectStoreAdapter()
        {
        }

        public void Store(WebClientData webClientData)
        {
            ClientData clientData = new ClientData(webClientData.name, webClientData.ID);

            IDBData perfectStore = new PerfectStore();

            perfectStore.Store(clientData);
        }
    }
}
