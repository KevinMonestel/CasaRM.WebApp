using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IFamilyGroupRepository
    {
        Task<IEnumerable<FamilyGroupDto>> GetFamilyGroupBySocialStudyId(int socialStudyId);

        Task<IEnumerable<FamilyGroupDto>> RefreshFamilyGroupAsync(int socialStudyId, IEnumerable<FamilyGroupDto> familyGroupDtos);
    }
}
