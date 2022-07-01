namespace SimpleChat.Desktop.Models.User
{
    using System;

    public class UserAuthorizationModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string IpAddress { get; set; } = null!;

        public string Port { get; set; } = null!;
    }
}
