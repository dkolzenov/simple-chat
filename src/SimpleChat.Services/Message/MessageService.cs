namespace SimpleChat.Services.Message
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using SimpleChat.Services.Interfaces;
    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Data.Entities.Message;
    using SimpleChat.Models.Message;

    public class MessageService : IMessageService
    {
        private readonly IMapper _mapper;

        private readonly IMessageRepository _messageRepository;

        public MessageService(
            IMapper mapper,
            IMessageRepository messageRepository)
        {
            _mapper = mapper;
            _messageRepository = messageRepository;
        }

        public async Task<List<MessageModel>> GetAllMessagesAsync()
        {
            try
            {
                var messages = _mapper.Map<List<MessageModel>>(
                    await _messageRepository.GetAllAsync());

                return messages;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<MessageModel>>(ex);
            }
        }

        public async Task<bool> SendMessageAsync(MessageModel messageModel)
        {
            try
            {
                var result = await _messageRepository.AddAsync(
                    _mapper.Map<MessageEntity>(messageModel));

                return result;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex);
            }
        }
    }
}
