namespace SimpleChat.Di.Modules
{
    using System;
    using System.Reflection;

    using Autofac;

    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Data.Repositories.Base;

    using Module = Autofac.Module;

    public class ApiDiModule : Module
    {
        private const string ServiceProjectName = "SimpleChat.Services";

        private const string DataProjectName = "SimpleChat.Data";

        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = AppDomain.CurrentDomain
                .GetAssemblies()
                .OrderByDescending(a => a.FullName)
                .ToArray();

            ServicesRegister(ref builder, assemblies);
            RepositoriesRegister(ref builder, assemblies);
        }

        private static void ServicesRegister(
            ref ContainerBuilder builder,
            Assembly[] assemblies)
        {
            var servicesAssembly = assemblies.FirstOrDefault(
                t => t.FullName!.ToLower().Contains(
                    ServiceProjectName.ToLower()));

            builder.RegisterAssemblyTypes(servicesAssembly!)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();
        }

        private static void RepositoriesRegister(
            ref ContainerBuilder builder,
            Assembly[] assemblies)
        {
            builder.RegisterGeneric(typeof(RepositoryBase<>))
                .As(typeof(IRepositoryBase<>));

            var dataAssembly = assemblies.FirstOrDefault(
                t => t.FullName!.ToLower().Contains(
                    DataProjectName.ToLower()));

            builder.RegisterAssemblyTypes(dataAssembly!)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();
        }
    }
}
