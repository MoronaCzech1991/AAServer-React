using AAServer.Application.UserAp.View;
using AAServer.Domain.Base.ValidationHttp;
using AAServer.Domain.MessagesWarnings.EnumMessage;
using AAServer.Domain.MessagesWarnings.PT;
using AAServer.Domain.UserDo;
using System.Collections.Generic;
using System.Linq;

namespace AAServer.Application.UserAp
{
    public class AplicUser : IAplicUser
    {
        private readonly IRepUser _repUser;
        private readonly IPortugueseMessages _portugueseMessages;
        public AplicUser(IRepUser repUser,
                         IPortugueseMessages portugueseMessages)
        {
            _repUser = repUser;
            _portugueseMessages = portugueseMessages;
        }

        public IEnumerable<UserView> GetAll(int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public UserView GetById(int id, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserView> GetByIds(IEnumerable<int> ids, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<User> GetUserByEmailAndPassword(string email, string password)
        {
            return _repUser.GetALL().Where(x => x.Email == email && x.Password == password).ToList();
        }

        public ValidationResultHttpServer Save(UserView view, int codeTenat)
        {
            ValidationResultHttpServer validationResult = this.ValidateEmail(view.Email);

            if (validationResult.Status == EnumStatusValidation.Success) 
            {
                var user = view.Viwer(view);
                _repUser.Add(user);
            }

            return validationResult;
        }

        private ValidationResultHttpServer ValidateEmail(string email)
        {
            ValidationResultHttpServer result = new ValidationResultHttpServer();

            int numberEmails = _repUser.GetALL().Where(x => x.Email == email).ToList().Count;

            if (numberEmails > 1)
            {
                result.Status = EnumStatusValidation.Falied;
                _portugueseMessages.GenerateErrorMessage(EnumMessagesError.ExistEmail);
            }
            else 
            {
                result.Status = EnumStatusValidation.Success;
            }

            return result;
        }
    }
}
