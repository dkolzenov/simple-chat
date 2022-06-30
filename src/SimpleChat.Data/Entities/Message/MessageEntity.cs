namespace SimpleChat.Data.Entities.Message
{
    using System.Collections.Generic;

    using SimpleChat.Data.Entities.User;

    public class MessageEntity
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public UserEntity Origin { get; set; } = null!;

        public List<UserEntity> Target { get; set; } = null!;
    }
}
