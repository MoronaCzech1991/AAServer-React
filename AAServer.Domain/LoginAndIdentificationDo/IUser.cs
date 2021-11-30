using System.Collections.Generic;
using System.Security.Claims;

namespace AAServer.Domain.LoginAndIdentificationDo
{
    public interface IUser
    {
        string Name { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
    }
}
