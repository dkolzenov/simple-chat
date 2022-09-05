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
                List<MessageEntity> result = await _messageRepository
                    .GetAllAsync();

                var messages = _mapper.Map<List<MessageModel>>(result);

                return messages;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<MessageModel>>(ex);
            }
        }

        public async Task<MessageModel> AddMessageAsync(MessageModel messageModel)
        {
            try
            {
                var messageEntity = _mapper.Map<MessageEntity>(messageModel);

                MessageEntity result = await _messageRepository
                    .AddAsync(messageEntity);

                var addedMessage = _mapper.Map<MessageModel>(result);

                return addedMessage;
            }
            catch (Exception ex)
            {
                return await Task.FromException<MessageModel>(ex);
            }
        }
    }
}
