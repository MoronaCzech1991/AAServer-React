using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.StockSys
{
    public class StockController : BaseController
    {
        public StockController()
        {
        }

        public IActionResult StockIndex() 
        {
            return View();
        }
    }
}
