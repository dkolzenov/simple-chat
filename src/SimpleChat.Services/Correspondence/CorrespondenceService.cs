﻿namespace SimpleChat.Services.Correspondence
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using SimpleChat.Services.Interfaces;
    using SimpleChat.Data.Repositories.Interfaces;
    using SimpleChat.Models.Correspondence;

    public class CorrespondenceService : ICorrespondenceService
    {
        private readonly IMapper _mapper;

        private readonly ICorrespondenceRepository _correspondenceRepository;

        public CorrespondenceService(
            IMapper mapper,
            ICorrespondenceRepository correspondenceRepository)
        {
            _mapper = mapper;
            _correspondenceRepository = correspondenceRepository;
        }

        public async Task<List<CorrespondenceModel>> GetAllCorrespondencesAsync()
        {
            try
            {
                var correspondences = _mapper.Map<List<CorrespondenceModel>>(
                    await _correspondenceRepository.GetAllAsync());

                return correspondences;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<CorrespondenceModel>>(ex);
            }
        }
    }
}
