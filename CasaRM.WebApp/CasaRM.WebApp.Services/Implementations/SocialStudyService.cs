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
        private readonly IFamilyGroupRepository _familyGroupRepository;
        private readonly IContributionRepository _contributionRepository;

        public SocialStudyService(
            IMinorPersonDataRepository minorPersonDataRepository,
            IHostRepository hostRepository,
            ISocialStudyRepository socialStudyRepository,
            IParentDataRepository parentDataRepository,
            ICompanionDataRepository companionDataRepository,
            IFamilyGroupRepository familyGroupRepository,
            IContributionRepository contributionRepository)
        {
            _minorPersonDataRepository = minorPersonDataRepository;
            _hostRepository = hostRepository;
            _socialStudyRepository = socialStudyRepository;
            _parentDataRepository = parentDataRepository;
            _companionDataRepository = companionDataRepository;
            _familyGroupRepository = familyGroupRepository;
            _contributionRepository = contributionRepository;
        }

        public async Task<CreateOrUpdateSocialStudyDto> GetFullSocialStudyAsync(int socialStudyId)
        {
            CreateOrUpdateSocialStudyDto result = new();
            SocialStudyDto socialStudyDto = await _socialStudyRepository.GetSocialStudyById(socialStudyId);

            result.MinorPersonDataDto = await _minorPersonDataRepository.GetMinorPersonDataByIdAsync(socialStudyDto.MinorPersonDataId);
            result.ParentDataDto = await _parentDataRepository.GetParentDataByIdAsync(socialStudyDto.ParentDataId);
            result.CompanionDataDto = await _companionDataRepository.GetCompanionDataByIdAsync(socialStudyDto.CompanionDataId);
            result.FamilyGroupDto = await _familyGroupRepository.GetFamilyGroupBySocialStudyId(socialStudyId);
            result.ContributionDto = await _contributionRepository.GetContributionBySocialStudyId(socialStudyId);
            result.IncomeCalculationDto = new() { TotalRevenue = socialStudyDto.TotalRevenue, PerCapitaIncome = socialStudyDto.PerCapitaIncome, PovertyCategory = socialStudyDto.PovertyCategory };

            return result;
        }

        public async Task<string> CreateOrUpdateSocialStudyAsync(CreateOrUpdateSocialStudyDto createOrUpdateSocialStudyDto)
        {
            string result = string.Empty;

            createOrUpdateSocialStudyDto.MinorPersonDataDto = await _minorPersonDataRepository.CreateOrUpdateAsync(createOrUpdateSocialStudyDto.MinorPersonDataDto);
            createOrUpdateSocialStudyDto.ParentDataDto = await _parentDataRepository.CreateOrUpdateAsync(createOrUpdateSocialStudyDto.ParentDataDto);
            createOrUpdateSocialStudyDto.CompanionDataDto = await _companionDataRepository.CreateOrUpdateAsync(createOrUpdateSocialStudyDto.CompanionDataDto);

            SocialStudyDto socialStudioModel = await _socialStudyRepository.CreateOrUpdateAsync(new SocialStudyDto
            {
                Id = createOrUpdateSocialStudyDto.SocialStudyId,
                MinorPersonDataId = createOrUpdateSocialStudyDto.MinorPersonDataDto.Id,
                CompanionDataId = createOrUpdateSocialStudyDto.CompanionDataDto.Id,
                ParentDataId = createOrUpdateSocialStudyDto.ParentDataDto.Id,
                TotalRevenue = createOrUpdateSocialStudyDto.IncomeCalculationDto.TotalRevenue,
                PerCapitaIncome = createOrUpdateSocialStudyDto.IncomeCalculationDto.PerCapitaIncome,
                PovertyCategory = createOrUpdateSocialStudyDto.IncomeCalculationDto.PovertyCategory
            });

            if (string.IsNullOrEmpty(createOrUpdateSocialStudyDto.HostId) && createOrUpdateSocialStudyDto.SocialStudyId.Equals(0))
            {
                if (socialStudioModel is null) throw new Exception();

                createOrUpdateSocialStudyDto.SocialStudyId = socialStudioModel.Id;

                HostDto hostModel = await _hostRepository.CreateHostAsync(new HostDto
                {
                    SocialStudyId = createOrUpdateSocialStudyDto.SocialStudyId,
                    CreatedBy = createOrUpdateSocialStudyDto.ExecutedBy,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                if(hostModel is null) throw new Exception();

                createOrUpdateSocialStudyDto.HostId = hostModel.Id;
            }

            createOrUpdateSocialStudyDto.FamilyGroupDto = await _familyGroupRepository.RefreshFamilyGroupAsync(createOrUpdateSocialStudyDto.SocialStudyId, createOrUpdateSocialStudyDto.FamilyGroupDto);
            createOrUpdateSocialStudyDto.ContributionDto = await _contributionRepository.RefreshContributionAsync(createOrUpdateSocialStudyDto.SocialStudyId, createOrUpdateSocialStudyDto.ContributionDto);

            result = createOrUpdateSocialStudyDto.HostId;

            return result;
        }
    }
}
