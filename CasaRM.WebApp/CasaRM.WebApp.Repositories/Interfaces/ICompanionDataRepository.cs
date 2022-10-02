using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface ICompanionDataRepository
    {
        Task<IEnumerable<CompanionDataDto>> GetFamilyGroupBySocialStudyId(int socialStudyId);

        Task<IEnumerable<CompanionDataDto>> RefreshFamilyGroupAsync(int socialStudyId, IEnumerable<CompanionDataDto> familyGroupDtos);
    }
}
