namespace SimpleChat.Desktop.ViewModels.UserAuthorization
{
    using Prism.Mvvm;
    using Prism.Commands;
    using Prism.Regions;

    public class UserAuthorizationViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = null!;

        public string Title
        {
            get => _title;

            set => SetProperty(ref _title, value);
        }

        public DelegateCommand ConnectCommand { get; set; } = null!;

        public UserAuthorizationViewModel(IRegionManager regionManager)
        {
            _title = "User Authorization";
            _regionManager = regionManager;
            InitializeCommand();
        }

        private void Connect()
        {
            _regionManager.RequestNavigate("UserAuthorization", "ChatBase");
        }

        private void InitializeCommand()
        {
            ConnectCommand = new DelegateCommand(Connect);
        }
    }
}
