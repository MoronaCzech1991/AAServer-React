using AAServer.Application.AccountAp.View;
using AAServer.Application.Base.Interfaces;
using AAServer.Domain.AccountDo;

namespace AAServer.Application.AccountAp
{
    public interface IAplicAccount : IApplicationBase<AccountView> 
    {
        Account GetAccountByName(string name);
    }
}
