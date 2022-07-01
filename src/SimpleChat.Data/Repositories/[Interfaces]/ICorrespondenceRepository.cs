namespace SimpleChat.Data.Repositories.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SimpleChat.Data.Entities.User;
    using SimpleChat.Data.Entities.Correspondence;

    public interface ICorrespondenceRepository
        : IRepositoryBase<CorrespondenceEntity>
    {
        Task<CorrespondenceEntity> GetCorrespondenceByUsers(
            List<UserEntity> users);
    }
}
