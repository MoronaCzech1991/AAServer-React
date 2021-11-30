using AAServer.MVC.Controllers.Base;

namespace AAServer.MVC.Controllers.Sys.Modules.Register
{
    public class EmployeController : BaseController, IInitController
    {
        public EmployeController()
        {
        }

        public bool hasItems()
        {
            return false;
        }
    }
}
