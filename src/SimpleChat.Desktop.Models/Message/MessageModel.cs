namespace SimpleChat.Desktop.Models.Message
{
    using SimpleChat.Desktop.Models.Correspondence;

    public class MessageModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public CorrespondenceModel Correspondence { get; set; } = null!;
    }
}
