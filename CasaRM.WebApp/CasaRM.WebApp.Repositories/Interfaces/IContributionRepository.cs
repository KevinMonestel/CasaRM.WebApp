using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IContributionRepository
    {
        Task<IEnumerable<ContributionDto>> GetContributionBySocialStudyId(int socialStudyId);

        Task<IEnumerable<ContributionDto>> RefreshContributionAsync(int socialStudyId, IEnumerable<ContributionDto> contributionDtos);
    }
}
