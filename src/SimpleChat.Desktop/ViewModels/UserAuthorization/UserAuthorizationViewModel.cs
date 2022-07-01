namespace SimpleChat.Desktop.ViewModels.UserAuthorization
{
    using Prism.Mvvm;
    using Prism.Commands;

    public class UserAuthorizationViewModel : BindableBase
    {
        public DelegateCommand ConnectCommand { get; set; } = null!;

        public UserAuthorizationViewModel()
        {
            InitializeCommand();
        }

        private void Connect()
        {

        }

        private void InitializeCommand()
        {
            ConnectCommand = new DelegateCommand();
        }
    }
}
