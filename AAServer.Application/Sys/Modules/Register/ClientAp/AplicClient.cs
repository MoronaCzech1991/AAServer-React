using AAServer.Application.Sys.Modules.Register.ClientAp.View;
using AAServer.Domain.Base.ValidationHttp;
using AAServer.Domain.Sys.Modules.Register.ClientDo;
using System.Collections.Generic;
using System.Linq;

namespace AAServer.Application.Sys.Modules.Register.ClientAp
{
    public class AplicClient : IAplicClient
    {
        private readonly IRepClient _repClient;
        public AplicClient(IRepClient repClient)
        {
            _repClient = repClient;
        }

        public IEnumerable<ClientView> GetAll(int codeTenat)
        {
            List<ClientView> clientViews = new List<ClientView>();
            var clients = _repClient.GetALL().Where(x => x.CodeTenantClient == codeTenat).ToList();

            foreach (Client client in clients)
            {
                ClientView clientView = new ClientView().ClientConverter(client);
                clientViews.Add(clientView);
            }

            return clientViews;
        }

        public ClientView GetById(int id, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClientView> GetByIds(IEnumerable<int> ids, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public ValidationResultHttpServer Save(ClientView view, int codeTenat)
        {
            Client client = view.Viwer(view);
            client.CodeTenantClient = codeTenat;
            _repClient.Add(client);
            return new ValidationResultHttpServer();
        }
    }
}
