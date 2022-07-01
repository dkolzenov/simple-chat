namespace SimpleChat.Data.Entities.Message
{
    using SimpleChat.Data.Entities.Correspondence;

    public class MessageEntity
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public CorrespondenceEntity Correspondence { get; set; } = null!;
    }
}
