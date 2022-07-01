namespace SimpleChat.Desktop.Ioc.Modules
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Prism.Ioc;
    using Prism.Modularity;

    using SimpleChat.Desktop.Views.Interfaces;

    public class DesktopIocModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterViews();
        }
    }

    static class ContainerRegistryExtensions
    {
        public static void RegisterViews(this IContainerRegistry containerRegistry)
        {
            var views = GetClasses<IRegisterableView>();

            foreach (var view in views)
            {
                containerRegistry.RegisterForNavigation(view, view.Name);
            }
        }

        private static IEnumerable<Type> GetClasses<T>()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(v => v.IsClass && typeof(T).IsAssignableFrom(v));
        }
    }
}
