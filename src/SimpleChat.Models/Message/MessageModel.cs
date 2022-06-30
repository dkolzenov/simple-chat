namespace SimpleChat.Models.Message
{
    public class MessageModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Origin { get; set; } = null!;

        public string Target { get; set; } = null!;
    }
}
