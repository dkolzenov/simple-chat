namespace SimpleChat.Services.Message
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using SimpleChat.Services.Interfaces;
    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Models.Message;

    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        private readonly IMapper _mapper;

        public MessageService(
            IMessageRepository messageRepository,
            IMapper mapper)
        {
            _messageRepository = messageRepository;
            _mapper = mapper;
        }

        public async Task<List<MessageModel>> GetAllMessages()
        {
            var messages = _mapper.Map<List<MessageModel>>(
                await _messageRepository.GetAllAsync());

            return messages;
        }

        public void SendMessage(MessageModel messageModel)
        {
            throw new NotImplementedException();
        }
    }
}
