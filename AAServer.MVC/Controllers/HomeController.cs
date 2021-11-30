using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AAServer.MVC.Models;
using Microsoft.Extensions.DependencyInjection;
using AAServer.Application.Provision;
using AAServer.MVC.Controllers.Base;
using AAServer.Application.Prov.View;
using Microsoft.AspNetCore.Http;
using AAServer.Domain.FrontEnd;

namespace AAServer.MVC.Controllers
{
    public class HomeController : BaseController
    {
        // Provision
        private readonly IAplicProvision _provision;

        [ActivatorUtilitiesConstructor]
        public HomeController(IAplicProvision provision)
        {
            _provision = provision;
        }

        [HttpPost("createAccount")]
        public HttpFrontEndResponse CreateAccount(string nameUser, string emailUser, string passwordUser) 
        {
            ProvisitionView view = new ProvisitionView(nameUser, emailUser, passwordUser);
            _provision.Provision(view);

            return new HttpFrontEndResponse();
        }

        public IActionResult Privacy() 
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("denied")]
        public IActionResult Denied() 
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
