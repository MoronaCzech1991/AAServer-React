using AAServer.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AAServer.React.Controllers.Base
{
    public class BaseController : Controller
    {
        public BaseController() : base()
        {
        }

        public bool VerifySession()
        {
            return HttpContext.Session.GetInt32(AutenticationSessionNames.TENANT_ID).HasValue;
        }

        public int GetSessionId()
        {
            return (int)HttpContext.Session.GetInt32(AutenticationSessionNames.TENANT_ID);
        }
    }
}
