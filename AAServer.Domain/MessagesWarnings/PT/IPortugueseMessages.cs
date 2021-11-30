using AAServer.Domain.MessagesWarnings.EnumMessage;

namespace AAServer.Domain.MessagesWarnings.PT
{
    public interface IPortugueseMessages
    {
        string GenerateErrorMessage(EnumMessagesError typeError);

        string GenerateSuccessMessage(EnumMessageSuccess typeSucces);
    }
}
