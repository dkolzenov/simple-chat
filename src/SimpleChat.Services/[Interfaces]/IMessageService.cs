namespace SimpleChat.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SimpleChat.Models.Message;

    public interface IMessageService
    {
        Task<List<MessageModel>> GetAllMessagesAsync();

        Task<MessageModel> AddMessageAsync(MessageModel messageModel);
    }
}
