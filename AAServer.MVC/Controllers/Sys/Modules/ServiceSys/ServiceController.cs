using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.ServiceSys
{
    public class ServiceController : BaseController
    {
        public ServiceController()
        {

        }

        public IActionResult ServiceIndex()
        {
            return View();
        }
    }
}
