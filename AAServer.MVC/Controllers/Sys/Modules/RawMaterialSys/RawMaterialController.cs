using AAServer.Application.Sys.Modules.RawMaterialSys.RawMaterialAp;
using AAServer.MVC.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.MVC.Controllers.Sys.Modules.RawMaterialSys
{
    public class RawMaterialController : BaseController, IInitController
    {
        private readonly IAplicRawMaterial _aplicRawMaterial;

        public RawMaterialController(IAplicRawMaterial aplicRawMaterial)
        {
            _aplicRawMaterial = aplicRawMaterial;
        }

        public IActionResult RawMaterialIndex() 
        {
            return View();
        }

        public bool hasItems()
        {
            throw new System.NotImplementedException();
        }
    }
}
