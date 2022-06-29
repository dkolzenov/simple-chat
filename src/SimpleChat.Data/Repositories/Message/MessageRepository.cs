namespace SimpleChat.Data.Repositories.Message
{
    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Data.Repositories.Base;
    using SimpleChat.Data.Contexts;
    using SimpleChat.Data.Entities;

    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        public MessageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
