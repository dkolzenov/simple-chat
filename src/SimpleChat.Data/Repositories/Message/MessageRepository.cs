namespace SimpleChat.Data.Repositories.Message
{
    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Data.Repositories.Base;
    using SimpleChat.Data.Entities.Message;
    using SimpleChat.Data.Contexts.ApplicationDb;

    public class MessageRepository : RepositoryBase<MessageEntity>, IMessageRepository
    {
        public MessageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
