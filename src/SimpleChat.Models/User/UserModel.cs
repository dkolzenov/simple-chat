namespace SimpleChat.Models.User
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string IpAddress { get; set; } = null!;
    }
}
