namespace SimpleChat.Data.Repositories.Correspondence
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Data.Repositories.Base;
    using SimpleChat.Data.Contexts.ApplicationDb;
    using SimpleChat.Data.Entities.User;
    using SimpleChat.Data.Entities.Correspondence;

    public class CorrespondenceRepository : RepositoryBase<CorrespondenceEntity>, ICorrespondenceRepository
    {
        private readonly ApplicationDbContext _context;

        public CorrespondenceRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<CorrespondenceEntity> GetCorrespondenceByUsers(List<UserEntity> users)
        {
            try
            {
                var correspondences = await QueryAsync(x => x.Users == users);

                return correspondences.First();
            }
            catch (Exception ex)
            {
                return await Task.FromException<CorrespondenceEntity>(ex);
            }
        }
    }
}
