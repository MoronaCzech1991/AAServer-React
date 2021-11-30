using AAServer.Domain.UserDo;
using AAServer.MVC.Controllers.Base;
using AAServer.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AAServer.MVC.Controllers.Sys
{
    public class SystemManagerController : BaseController
    {
        private readonly IRepUser _repUser;

        public SystemManagerController(IRepUser repUser)
            :base()
        {
            _repUser = repUser;
        }

        [Authorize(Policy = "PolicyAdmin")]
        [Authorize(Policy = "PolicyManager")]
        [Authorize(Policy = "PolicyEmploye")]
        public IActionResult SysIndex()
        {
            int? codeTenant = HttpContext.Session.GetInt32(AutenticationSessionNames.TENANT_ID);
            int? codeUser = HttpContext.Session.GetInt32(AutenticationSessionNames.USER_ID);

            if (codeTenant.HasValue && codeUser.HasValue)
            {
                string userName = _repUser.GetById((int)codeUser).NameUser;

                ViewData["USER_NAME"] = userName;
                return View();
            }
            else 
            {
                return RedirectPage();
            }
        }

        [Authorize(Policy = "PolicyAdmin")]
        [Authorize(Policy = "PolicyManager")]
        [Authorize(Policy = "PolicyEmploye")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectPage();
        }

        private IActionResult RedirectPage() 
        {
            return Redirect("/home/Index");
        }
    }
}
