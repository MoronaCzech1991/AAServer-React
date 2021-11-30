using AAServer.MVC.Controllers.Base;

namespace AAServer.MVC.Controllers.Sys.Modules.Register
{
    public class ShippingCompanyController : BaseController, IInitController
    {
        public ShippingCompanyController()
        {
        }

        public bool hasItems()
        {
            return false;
        }
    }
}
