using AAServer.Application.BaseViewAp;
using AAServer.Domain.AccountDo;

namespace AAServer.Application.AccountAp.View
{
    public class AccountView 
    {     
        public string Name { get; set; }

        public Account Viwer(AccountView view)
        {
            return ViewBaseApp<Account>.NewSelect(view);
        }
    }
}
