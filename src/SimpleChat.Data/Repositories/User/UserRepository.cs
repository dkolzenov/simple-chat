namespace SimpleChat.Data.Repositories.User
{
    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Data.Repositories.Base;
    using SimpleChat.Data.Contexts;
    using SimpleChat.Data.Entities;

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
