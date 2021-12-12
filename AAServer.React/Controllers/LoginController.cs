using AAServer.Application.UserAp;
using AAServer.Domain.UserDo;
using AAServer.React.Controllers.Base;
using AAServer.React.Controllers.Views;
using AAServer.Service;
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

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Autenticate([FromBody] LoginViewModel view)
        {
            ICollection<User> users = _aplicUser.GetUserByEmailAndPassword(view.email, view.passWord);
            if (users.Count() == VERIFICATION_USER)
            {
                return Accepted();
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

        public IActionResult Claims()
        {
            return Ok(User.Claims.Select(x => new { Type = x.Type, Value = x.Value }));
        }
    }
}
