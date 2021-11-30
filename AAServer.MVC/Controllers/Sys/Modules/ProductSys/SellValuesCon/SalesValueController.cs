using AAServer.MVC.Controllers.Base;

namespace AAServer.MVC.Controllers.Sys.Modules.ProductSys.SellValuesCon
{
    public class SalesValueController : BaseController, IInitController
    {
        public SalesValueController() : base()
        {
        }

        public bool hasItems()
        {
            return false;
        }
    }
}
