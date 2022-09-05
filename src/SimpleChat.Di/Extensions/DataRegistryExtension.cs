namespace SimpleChat.Di.Extensions
{
    using System.Reflection;

    using Autofac;

    public static class DataRegistryExtension
    {
        private const string DataName = "SimpleChat.Data";

        private const string Separator = ",";

        public static void RegisterRepositories(
            this ContainerBuilder builder,
            Assembly[] assemblies)
        {
            var dataAssembly = assemblies.FirstOrDefault(
                t => t.FullName!
                    .ToLower()
                    .Contains(DataName.ToLower() + Separator));

            builder.RegisterAssemblyTypes(dataAssembly!)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();
        }
    }
}
