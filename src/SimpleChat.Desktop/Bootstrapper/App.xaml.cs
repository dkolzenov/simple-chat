namespace SimpleChat.Desktop.Bootstrapper
{
    using System.Windows;

    using Prism.Ioc;
    using Prism.Modularity;

    using SimpleChat.Desktop.Ioc.Modules;
    using SimpleChat.Desktop.Views.UserAuthorization;

    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<UserAuthorizationView>();
        }

        protected override void ConfigureModuleCatalog(
            IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<DesktopIocModule>();
        }

        protected override void RegisterTypes(
            IContainerRegistry containerRegistry)
        {
        }
    }
}
