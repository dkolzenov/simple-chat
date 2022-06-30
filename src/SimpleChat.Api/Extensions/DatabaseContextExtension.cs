namespace SimpleChat.Api.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using SimpleChat.Data.Contexts.ApplicationDb;

    public static class DatabaseContextExtension
    {
        private const string ConnectionStringName = "DefaultConnection";

        public static void AddCustomSqliteContext(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration
                .GetConnectionString(ConnectionStringName);

            services.AddDbContext<ApplicationDbContext>(
                o => o.UseSqlite(connectionString));

            services.BuildServiceProvider()
                .GetService<ApplicationDbContext>()
                .Database
                .Migrate(); // DB automigration on start enable
        }
    }
}
