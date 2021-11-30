using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.EmployeSys
{
    public class EmployeController : BaseController
    {
        public EmployeController()
        {         
        }

        public IActionResult EmployeIndex()
        {
            return View();
        }
    }
}
