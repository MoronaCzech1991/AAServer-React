using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.SellPointSys
{
    public class SellPointController : BaseController
    {
        public SellPointController()
        {
        }

        public IActionResult SellPointIndex() 
        {
            return View();
        }
    }
}
