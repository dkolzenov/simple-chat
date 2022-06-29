namespace SimpleChat.Data.Contexts
{
    using Microsoft.EntityFrameworkCore;

    using SimpleChat.Data.Entities;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Message> Messages { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
