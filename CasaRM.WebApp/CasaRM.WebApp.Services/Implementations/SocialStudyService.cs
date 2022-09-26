using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models.SocialStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRM.WebApp.Services.Implementations
{
    public class SocialStudyService : ISocialStudyService
    {
        private readonly IHostRepository _hostRepository;
        private readonly ISocialStudyRepository _socialStudyRepository;
        private readonly IMinorPersonDataRepository _minorPersonDataRepository;
        private readonly IParentDataRepository _parentDataRepository;
        private readonly ICompanionDataRepository _companionDataRepository;

        public SocialStudyService(
            IMinorPersonDataRepository minorPersonDataRepository,
            IHostRepository hostRepository,
            ISocialStudyRepository socialStudyRepository,
            IParentDataRepository parentDataRepository,
            ICompanionDataRepository companionDataRepository
            )
        {
            _minorPersonDataRepository = minorPersonDataRepository;
            _hostRepository = hostRepository;
            _socialStudyRepository = socialStudyRepository;
            _parentDataRepository = parentDataRepository;
            _companionDataRepository = companionDataRepository;
        }

        public async Task<string> CreateOrUpdateSocialStudyAsync(CreateOrUpdateSocialStudyDto createOrUpdateSocialStudyDto)
        {
            string result = string.Empty;

            createOrUpdateSocialStudyDto.MinorPersonDataDto = await _minorPersonDataRepository.CreateOrUpdateAsync(createOrUpdateSocialStudyDto.MinorPersonDataDto);
            createOrUpdateSocialStudyDto.ParentDataDto = await _parentDataRepository.CreateOrUpdateAsync(createOrUpdateSocialStudyDto.ParentDataDto);
            createOrUpdateSocialStudyDto.CompanionDataDto = await _companionDataRepository.CreateOrUpdateAsync(createOrUpdateSocialStudyDto.CompanionDataDto);

            if (string.IsNullOrEmpty(createOrUpdateSocialStudyDto.HostId) && createOrUpdateSocialStudyDto.SocialStudyId.Equals(0))
            {
                SocialStudyDto socialStudioModel = await _socialStudyRepository.CreateSocialStudyAsync(new SocialStudyDto
                {
                    MinorPersonDataId = createOrUpdateSocialStudyDto.MinorPersonDataDto.Id,
                    CompanionDataId = createOrUpdateSocialStudyDto.CompanionDataDto.Id,
                    ParentDataId = createOrUpdateSocialStudyDto.ParentDataDto.Id
                });

                if (socialStudioModel is null) throw new Exception();

                HostDto hostModel = await _hostRepository.CreateHostAsync(new HostDto
                {
                    SocialStudyId = socialStudioModel.Id,
                    CreatedBy = createOrUpdateSocialStudyDto.ExecutedBy,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                if(hostModel is null) throw new Exception();

                result = hostModel.Id;
            }

            return result;
        }
    }
}
