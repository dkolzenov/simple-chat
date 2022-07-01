namespace SimpleChat.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SimpleChat.Models.Correspondence;

    public interface ICorrespondenceService
    {
        Task<List<CorrespondenceModel>> GetAllCorrespondencesAsync();
    }
}
