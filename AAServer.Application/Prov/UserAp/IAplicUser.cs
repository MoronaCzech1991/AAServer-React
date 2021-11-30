using AAServer.Application.Base.Interfaces;
using AAServer.Application.UserAp.View;
using AAServer.Domain.UserDo;
using System.Collections.Generic;

namespace AAServer.Application.UserAp
{
    public interface IAplicUser : IApplicationBase<UserView>
    {
        ICollection<User> GetUserByEmailAndPassword(string nameUser, string password);
    }
}
