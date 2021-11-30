using AAServer.Application.Sys.Modules.Register.ClientAp;
using AAServer.Application.Sys.Modules.Register.ClientAp.View;
using AAServer.Domain.Base.ValidationHttp;
using AAServer.MVC.Controllers.Base;
using AAServer.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AAServer.MVC.Controllers.Sys.Modules.Register
{
    public class ClientController : BaseController
    {
        private readonly IAplicClient _aplicClient;

        public ClientController(IAplicClient aplicClient)
        {
            _aplicClient = aplicClient;
        }

        public IActionResult ClientIndex() 
        {
            return View();
        }

        public ValidationResultHttpServer CreateNewClient(ClientView view)
        {
            // This will change
            int sessionId = (int)HttpContext.Session.GetInt32(AutenticationSessionNames.TENANT_ID);
            return _aplicClient.Save(view, sessionId);
        }

        public IEnumerable<ClientView> GetAllClients() 
        {
            int tenant = GetSessionId();
            var clients = _aplicClient.GetAll(tenant);
            return clients;
        }

        public ClientView GetClientById(int id)
        {
            int tenant = GetSessionId();
            return new ClientView();
        }
    }
}
