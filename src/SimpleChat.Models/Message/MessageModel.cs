namespace SimpleChat.Models.Message
{
    using SimpleChat.Models.Correspondence;

    public class MessageModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public CorrespondenceModel Correspondence { get; set; } = null!;
    }
}
