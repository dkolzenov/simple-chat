namespace SimpleChat.Data.Repositories.User
{
    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Data.Repositories.Base;
    using SimpleChat.Data.Entities.User;
    using SimpleChat.Data.Contexts.ApplicationDb;

    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
