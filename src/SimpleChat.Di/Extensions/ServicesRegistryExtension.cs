namespace SimpleChat.Di.Extensions
{
    using System.Reflection;

    using Autofac;

    public static class ServicesRegistryExtension
    {
        private const string ServiceName = "SimpleChat.Services";

        private const string Separator = ",";

        public static void RegisterServices(
            this ContainerBuilder builder,
            Assembly[] assemblies)
        {
            var servicesAssembly = assemblies.FirstOrDefault(
                t => t.FullName!
                    .ToLower()
                    .Contains(ServiceName.ToLower() + Separator));

            builder.RegisterAssemblyTypes(servicesAssembly!)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();
        }
    }
}
