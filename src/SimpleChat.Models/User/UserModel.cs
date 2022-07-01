namespace SimpleChat.Models.User
{
    using SimpleChat.Models.Correspondence;

    public class UserModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string IpAddress { get; set; } = null!;

        public bool IsConnected { get; set; }

        public List<CorrespondenceModel> Correspondences { get; set; } = null!;
    }
}
