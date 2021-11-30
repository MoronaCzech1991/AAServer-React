using AAServer.Application.AccountAp.View;
using AAServer.Application.Base.Interfaces;
using AAServer.Application.Translation;
using AAServer.Domain.AccountDo;
using AAServer.Domain.Base.ValidationHttp;
using AAServer.Domain.MessagesWarnings;
using AAServer.Domain.MessagesWarnings.EnumMessage;
using AAServer.Domain.MessagesWarnings.PT;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AAServer.Application.AccountAp
{
    public class AplicAccount : IAplicAccount
    {
        private readonly IRepAccount _repAccount;
        private readonly IAplicTranslation _aplicTranslation;
        private readonly IPortugueseMessages _portugueseMessages;
        public AplicAccount(IRepAccount repAccount,
                            IAplicTranslation aplicTranslation,
                            IPortugueseMessages portugueseMessages)
        {
            _repAccount = repAccount;
            _aplicTranslation = aplicTranslation;
            _portugueseMessages = portugueseMessages;
        }
        public Account GetAccountByName(string name)
        {
            return _repAccount.GetALL().Where(x => x.Name == name).FirstOrDefault();
        }
        public ValidationResultHttpServer VerifyAccountExistByName(string name)
        {
            ValidationResultHttpServer validation = new ValidationResultHttpServer();

            int account = _repAccount.GetALL().Where(x => x.Name == name).ToList().Count;

            if (account > 0)
            {
                validation.Status = EnumStatusValidation.Falied;
                validation.ErrorMessage = _portugueseMessages.GenerateErrorMessage(EnumMessagesError.ExistAccountName);
            }
            else 
            {
                validation.Status = EnumStatusValidation.Success;
            }

            return validation;
        }

        public ValidationResultHttpServer Save(AccountView  view, int codeTenat) 
        {
            ValidationResultHttpServer validationResult = this.VerifyAccountExistByName(view.Name);

            if (validationResult.Status == EnumStatusValidation.Success) 
            {
                Account account = view.Viwer(view);
                account.AccountDate = DateTime.Now;
                _repAccount.Add(account);
            }

            return validationResult;
        }

        public IEnumerable<AccountView> GetAll(int codeTenat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountView> GetByIds(IEnumerable<int> ids, int codeTenat)
        {
            throw new NotImplementedException();
        }

        public AccountView GetById(int id, int codeTenat)
        {
            throw new NotImplementedException();
        }
    }
}
