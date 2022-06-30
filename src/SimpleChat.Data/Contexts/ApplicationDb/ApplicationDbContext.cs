namespace SimpleChat.Data.Contexts.ApplicationDb
{
    using Microsoft.EntityFrameworkCore;

    using SimpleChat.Data.Entities.Message;
    using SimpleChat.Data.Entities.User;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<MessageEntity> Messages { get; set; } = null!;

        public DbSet<UserEntity> Users { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
