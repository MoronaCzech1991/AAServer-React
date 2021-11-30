using AAServer.Application.AccountAp;
using AAServer.Application.AccountAp.View;
using AAServer.Application.Prov.View;
using AAServer.Application.UserAp;
using AAServer.Application.UserAp.View;
using AAServer.Domain.AccountDo;
using AAServer.Domain.Base.ValidationHttp;
using AAServer.Domain.MessagesWarnings.EnumMessage;
using AAServer.Domain.MessagesWarnings.PT;

namespace AAServer.Application.Provision
{
    public class AplicProvision : IAplicProvision
    {
        private readonly IAplicAccount _aplicAccount;
        private readonly IAplicUser _aplicUser;
        private readonly IPortugueseMessages _portugueseMessages;

        public AplicProvision(IAplicUser aplicUser,
            IAplicAccount aplicAccount,
            IPortugueseMessages portugueseMessages)
        {
            _aplicAccount = aplicAccount;
            _aplicUser = aplicUser;
            _portugueseMessages = portugueseMessages;
        }

        public ValidationResultHttpServer Provision(ProvisitionView view)
        {
            ValidationResultHttpServer validation = new ValidationResultHttpServer();

            AccountView accountView = this.SolverAccountView(view);
            validation = _aplicAccount.Save(accountView, 0);

            if (validation.Status == EnumStatusValidation.Success)
            {
                Account account = _aplicAccount.GetAccountByName(view.Name);
                view.CodeTenant = account.Tenant;
             }
            else 
            {
                return validation;
            }

            view.UserView = SolverUserView(view);
            validation = _aplicUser.Save(view.UserView, 0);
            if (validation.Status != EnumStatusValidation.Success)
            {
                return validation;
            }

            validation.Status = EnumStatusValidation.Success;
            validation.SuccessMessage = _portugueseMessages.GenerateSuccessMessage(EnumMessageSuccess.CreatedAccount);

            return validation;
        }

        private AccountView SolverAccountView(ProvisitionView view) 
        {
            AccountView viewAccount = new AccountView();
            viewAccount.Name = view.Name;

            return viewAccount;
        }

        private UserView SolverUserView(ProvisitionView view) 
        {
            UserView viewUser = view.UserView;
            viewUser.NameUser = view.Name;
            viewUser.Email = view.Email;
            viewUser.CodeTenant = view.CodeTenant;
            viewUser.Password = view.Password;

            return viewUser;
        }
    }
}
