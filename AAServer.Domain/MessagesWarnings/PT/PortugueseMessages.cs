using AAServer.Domain.MessagesWarnings.EnumMessage;

namespace AAServer.Domain.MessagesWarnings.PT
{
    public class PortugueseMessages : IPortugueseMessages
    {
        public string GenerateErrorMessage(EnumMessagesError typeError) 
        {
            switch (typeError)
            {
                case EnumMessagesError.ExistAccountName:
                    return " Já existe uma conta com esse nome, use outro nome ! ";
                    break;
                case EnumMessagesError.ExistEmail:
                    return " Esse email já está cadastrado, use outro email ! ";
                    break;
                case EnumMessagesError.ExistUser:
                    return " Usuario existente use outro ! ";
                    break;
                case EnumMessagesError.InvalidName:
                    return " Já existe esse nome cadsatrado, use outro ! ";
                    break;
                default:
                    return " Messagem padrao de erro ! ";
                    break;
            }
        }
        public string GenerateSuccessMessage(EnumMessageSuccess typeSucces)
        {
            switch (typeSucces)
            {
                case EnumMessageSuccess.CreatedAccount:
                    return " Sua conta foi criada com sucesso ";
                    break;
                default:
                    return " Messagem padrao ! ";
                    break;
            }
        }
    }
}
