namespace SimpleChat.Api.Extensions
{
    public static class CorsPolicyExtension
    {
        private const string SimpleChatCorsPolicy = "SimpleChatCorsPolicy";

        private const string SectionName = "AllowedOrigins";

        public static void AddCustomCorsPolicy(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddCors(o => o.AddPolicy(SimpleChatCorsPolicy, policy =>
            {
                string[] origins = configuration
                    .GetSection(SectionName)
                    .Get<List<string>>()
                    .ToArray();

                policy.WithOrigins(origins);
                policy.AllowAnyHeader().AllowAnyMethod();
            }));
        }

        public static void UseCustomCorsPolicy(this IApplicationBuilder app)
        {
            app.UseCors(SimpleChatCorsPolicy);
        }
    }
}
