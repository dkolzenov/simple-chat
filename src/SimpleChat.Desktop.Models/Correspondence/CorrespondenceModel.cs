namespace SimpleChat.Desktop.Models.Correspondence
{
    using System.Collections.Generic;

    using SimpleChat.Desktop.Models.User;
    using SimpleChat.Desktop.Models.Message;

    public class CorrespondenceModel
    {
        public int Id { get; set; }

        public List<MessageModel> Messages { get; set; } = null!;

        public List<UserModel> Users { get; set; } = null!;
    }
}
