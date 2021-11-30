using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.Register
{
    public class RegisterController : BaseController, IInitController
    {
        public RegisterController()
        {          
        }
        public IActionResult RegisterIndex()
        {
            return View();
        }

        public bool hasItems()
        {
            return false;
        }
    }
}
