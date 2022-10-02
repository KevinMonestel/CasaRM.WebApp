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
        private readonly ICompanionDataRepository _companionDataRepository;
        private readonly IFamilyGroupRepository _familyGroupRepository;
        private readonly IContributionRepository _contributionRepository;
        private readonly IHousingSituationRepository _housingSituationRepository;

        public SocialStudyService(
            IMinorPersonDataRepository minorPersonDataRepository,
            IHostRepository hostRepository,
            ISocialStudyRepository socialStudyRepository,
            ICompanionDataRepository companionDataRepository,
            IFamilyGroupRepository familyGroupRepository,
            IContributionRepository contributionRepository,
            IHousingSituationRepository housingSituationRepository)
        {
            _minorPersonDataRepository = minorPersonDataRepository;
            _hostRepository = hostRepository;
            _socialStudyRepository = socialStudyRepository;
            _companionDataRepository = companionDataRepository;
            _familyGroupRepository = familyGroupRepository;
            _contributionRepository = contributionRepository;
            _housingSituationRepository = housingSituationRepository;
        }

        public async Task<CreateOrUpdateSocialStudyDto> GetFullSocialStudyAsync(int socialStudyId)
        {
            CreateOrUpdateSocialStudyDto result = new();
            SocialStudyDto socialStudyDto = await _socialStudyRepository.GetSocialStudyById(socialStudyId);

            result.MinorPersonDataDto = await _minorPersonDataRepository.GetMinorPersonDataByIdAsync(socialStudyDto.MinorPersonDataId);
            result.CompanionDataDto = await _companionDataRepository.GetFamilyGroupBySocialStudyId(socialStudyId);
            result.FamilyGroupDto = await _familyGroupRepository.GetFamilyGroupBySocialStudyId(socialStudyId);
            result.ContributionDto = await _contributionRepository.GetContributionBySocialStudyId(socialStudyId);
            result.IncomeCalculationDto = new() { TotalRevenue = socialStudyDto.TotalRevenue, PerCapitaIncome = socialStudyDto.PerCapitaIncome, PovertyCategory = socialStudyDto.PovertyCategory };
            result.HousingSituationDto = await _housingSituationRepository.GetHousingSituationByIdAsync(socialStudyDto.HousingSituationId);
            result.RecomendationDto = new() { Recomendation = socialStudyDto.Recomendation };
            result.SupportServicesDto = new() { SupportServices = socialStudyDto.SupportServices };

            return result;
        }

        public async Task<string> CreateOrUpdateSocialStudyAsync(CreateOrUpdateSocialStudyDto createOrUpdateSocialStudyDto)
        {
            string result = string.Empty;

            createOrUpdateSocialStudyDto.MinorPersonDataDto = await _minorPersonDataRepository.CreateOrUpdateAsync(createOrUpdateSocialStudyDto.MinorPersonDataDto);
            createOrUpdateSocialStudyDto.HousingSituationDto = await _housingSituationRepository.CreateOrUpdateAsync(createOrUpdateSocialStudyDto.HousingSituationDto);

            SocialStudyDto socialStudioModel = await _socialStudyRepository.CreateOrUpdateAsync(new SocialStudyDto
            {
                Id = createOrUpdateSocialStudyDto.SocialStudyId,
                MinorPersonDataId = createOrUpdateSocialStudyDto.MinorPersonDataDto.Id,
                TotalRevenue = createOrUpdateSocialStudyDto.IncomeCalculationDto.TotalRevenue,
                PerCapitaIncome = createOrUpdateSocialStudyDto.IncomeCalculationDto.PerCapitaIncome,
                PovertyCategory = createOrUpdateSocialStudyDto.IncomeCalculationDto.PovertyCategory,
                SupportServices = createOrUpdateSocialStudyDto.SupportServicesDto.SupportServices,
                Recomendation = createOrUpdateSocialStudyDto.RecomendationDto.Recomendation,
                HousingSituationId = createOrUpdateSocialStudyDto.HousingSituationDto.Id
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

            createOrUpdateSocialStudyDto.CompanionDataDto = await _companionDataRepository.RefreshFamilyGroupAsync(createOrUpdateSocialStudyDto.SocialStudyId, createOrUpdateSocialStudyDto.CompanionDataDto);
            createOrUpdateSocialStudyDto.FamilyGroupDto = await _familyGroupRepository.RefreshFamilyGroupAsync(createOrUpdateSocialStudyDto.SocialStudyId, createOrUpdateSocialStudyDto.FamilyGroupDto);
            createOrUpdateSocialStudyDto.ContributionDto = await _contributionRepository.RefreshContributionAsync(createOrUpdateSocialStudyDto.SocialStudyId, createOrUpdateSocialStudyDto.ContributionDto);

            result = createOrUpdateSocialStudyDto.HostId;

            return result;
        }
    }
}
