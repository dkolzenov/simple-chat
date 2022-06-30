namespace SimpleChat.Data.Entities.User
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string IpAddress { get; set; } = null!;

        public bool IsConnected { get; set; }
    }
}
