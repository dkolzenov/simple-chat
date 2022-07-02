namespace SimpleChat.Desktop.Views.ChatBase
{
    using System.Windows;

    using SimpleChat.Desktop.Views.Interfaces;

    public partial class ChatBaseView : Window, IRegisterableView
    {
        public ChatBaseView()
        {
            InitializeComponent();
        }
    }
}
