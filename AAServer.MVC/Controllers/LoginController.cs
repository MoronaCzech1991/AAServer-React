using AAServer.Application.UserAp;
using AAServer.Domain.UserDo;
using AAServer.MVC.Autorizations;
using AAServer.MVC.Controllers.Base;
using AAServer.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AAServer.MVC.Controllers
{
    public class LoginController : BaseController
    {
        // Const
        private readonly int VERIFICATION_USER = 1;

        private readonly IAplicUser _aplicUser;

        public LoginController(IAplicUser aplicUser)
        {
            _aplicUser = aplicUser;
        }

        [AllowAnonymous]
        public IActionResult Index() 
        {
            return View();
        }

        [Authorize]
        public IActionResult Claims()
        {
            return Ok(User.Claims.Select(x => new { Type = x.Type, Value = x.Value }));
        }

        private async Task CreateCoockie() 
        {
            ClaimsIdentity identity = new ClaimsIdentity(AutorizationLevels.NAME_AUTH);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, "1234"));
            identity.AddClaim(new Claim(ClaimTypes.Webpage, "https://aaserver.com"));
            identity.AddClaim(new Claim(ClaimTypes.Role, AutorizationLevels.ROLE_ADMIN_LEVEL));
            identity.AddClaim(new Claim(ClaimTypes.Role, AutorizationLevels.ROLE_MANAGER_LEVEL));
            identity.AddClaim(new Claim(ClaimTypes.Role, AutorizationLevels.ROLE_EMPLOYE_LEVEL));
            ClaimsPrincipal principal = new ClaimsPrincipal(new[] { identity });

            await HttpContext.SignInAsync(principal);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Autenticate(string email, string password) 
        {
            ICollection<User> users = _aplicUser.GetUserByEmailAndPassword(email, password);
            if (users.Count() == VERIFICATION_USER)
            {
                await CreateCoockie();
                return Redirect("/SystemManager/SysIndex");
            }
            else 
            {
                return BadRequest();
            }
        }

        private void createSession(int tenantId, int userID) 
        {
            HttpContext.Session.SetInt32(AutenticationSessionNames.TENANT_ID, tenantId);
            HttpContext.Session.SetInt32(AutenticationSessionNames.USER_ID, userID);
        }

        [HttpGet("login")]
        public IActionResult Login(string returnUrl) 
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Validate(string nameUser, string password, string returnUrl) 
        {
            ViewData["ReturnUrl"] = returnUrl;
            ICollection<User> user = _aplicUser.GetUserByEmailAndPassword(nameUser, password);
            if (user.Count() == VERIFICATION_USER)
            {
                await CreateCoockie();
                createSession(user.First().CodeTenantUser, user.First().Id);
                return Redirect("/SystemManager/SysIndex");
            }
            else
            {
                TempData["Error"] = "User name or password invalid !";
                return View("login");
            }
        }

        public async Task<IActionResult> LogOut() 
        {
            await HttpContext.SignOutAsync();
            return Redirect("/home/Index");
        }
    }
}
