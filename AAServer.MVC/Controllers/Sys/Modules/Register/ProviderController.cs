using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.Register
{
    public class ProviderController : BaseController, IInitController
    {
        public ProviderController()
        {
        }

        public IActionResult ProviderIndex()
        {
            return View();
        }

        public bool hasItems()
        {
            return false;
        }
    }
}
