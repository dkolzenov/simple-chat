namespace SimpleChat.Data.Entities.User
{
    using System;
    using System.Collections.Generic;

    using SimpleChat.Data.Entities.Correspondence;

    public class UserEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string IpAddress { get; set; } = null!;

        public bool IsConnected { get; set; }

        public List<CorrespondenceEntity> Correspondences { get; set; } = null!;
    }
}
