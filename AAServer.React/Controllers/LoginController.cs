using AAServer.Application.UserAp;
using AAServer.Domain.UserDo;
using AAServer.React.Autorizations;
using AAServer.React.Controllers.Base;
using AAServer.React.Controllers.HTTPResponse;
using AAServer.React.Controllers.Views;
using AAServer.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AAServer.React.Controllers
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
        public async Task<IActionResult> Autenticate([FromBody] LoginViewModel view)
        {
            ICollection<User> users = _aplicUser.GetUserByEmailAndPassword(view.email, view.passWord);
            if (users.Count() == VERIFICATION_USER)
            {
                await CreateCoockie();
                AcceptedResult result = Accepted();
                LoginResponseHTTP responseHTTP = new LoginResponseHTTP();
                responseHTTP.LoginAccepted();
                result.Value = responseHTTP;

                var user = users.First();
                createSession(user.CodeTenantUser, user.Id);
                return result;
            }
            else
            {
                LoginResponseHTTP responseHTTP = new LoginResponseHTTP();
                responseHTTP.LoginBadRequest();
                BadRequestObjectResult result = new BadRequestObjectResult(responseHTTP);
                result.Value = responseHTTP;
                return result;
            }
        }

        private void createSession(int tenantId, int userID)
        {
            HttpContext.Session.SetInt32(AutenticationSessionNames.TENANT_ID, tenantId);
            HttpContext.Session.SetInt32(AutenticationSessionNames.USER_ID, userID);
        }

        public async void LogOut()
        {
            await HttpContext.SignOutAsync();
        }
    }
}
