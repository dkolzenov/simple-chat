namespace SimpleChat.Desktop.Models.User
{
    using System;
    using System.Collections.Generic;

    using SimpleChat.Desktop.Models.Message;

    public class UserReceiverModel
    {
        public Guid Id { get; set; }

        public List<MessageModel> Messages { get; set; } = null!;
    }
}
