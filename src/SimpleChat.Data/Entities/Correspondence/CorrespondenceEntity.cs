namespace SimpleChat.Data.Entities.Correspondence
{
    using System.Collections.Generic;

    using SimpleChat.Data.Entities.User;
    using SimpleChat.Data.Entities.Message;

    public class CorrespondenceEntity
    {
        public int Id { get; set; }

        public List<MessageEntity> Messages { get; set; } = null!;

        public List<UserEntity> Users { get; set; } = null!;
    }
}
