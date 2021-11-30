using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.AutomationSys
{
    public class AutomationController : BaseController
    {
        public AutomationController()
        {
        }

        public IActionResult AutomationIndex() 
        {
            return View();
        }
    }
}
