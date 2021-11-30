using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.ProductSys.ProductCon
{
    public class ProductController : BaseController, IInitController
    {
        public ProductController() : base()
        {
        }

        public IActionResult ProductIndex()
        {
            return View();
        }

        public bool hasItems()
        {
            return false;
        }
    }
}
