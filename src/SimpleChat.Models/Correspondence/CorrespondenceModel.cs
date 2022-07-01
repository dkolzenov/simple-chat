namespace SimpleChat.Models.Correspondence
{
    using SimpleChat.Models.User;
    using SimpleChat.Models.Message;

    public class CorrespondenceModel
    {
        public int Id { get; set; }

        public List<MessageModel> Messages { get; set; } = null!;

        public List<UserModel> Users { get; set; } = null!;
    }
}
