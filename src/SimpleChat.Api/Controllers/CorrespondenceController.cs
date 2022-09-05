namespace SimpleChat.Api.Controllers
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;

    using SimpleChat.Services.Interfaces;
    using SimpleChat.Models.Correspondence;

    [ApiController]
    [Route("api/correspondence")]
    public class CorrespondenceController : ControllerBase
    {
        private readonly ICorrespondenceService _correspondenceService;

        public CorrespondenceController(
            ICorrespondenceService correspondenceService)
        {
            _correspondenceService = correspondenceService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CorrespondenceModel>>> GetAllCorrespondences()
        {
            var correspondences = await _correspondenceService
                .GetAllCorrespondencesAsync();

            return correspondences;
        }
    }
}
