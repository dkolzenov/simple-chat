namespace SimpleChat.Api.Extensions
{
    using AutoMapper;

    using SimpleChat.Mappers.ApiProfile;

    public static class MapperExtension
    {
        public static void AddCustomAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ApiMappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
