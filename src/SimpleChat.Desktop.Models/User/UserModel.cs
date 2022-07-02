namespace SimpleChat.Desktop.Models.User
{
    using System;
    using System.Collections.Generic;

    using SimpleChat.Desktop.Models.Correspondence;

    public class UserModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsConnected { get; set; }

        public List<CorrespondenceModel> Correspondences { get; set; } = null!;
    }
}
