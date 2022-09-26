using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IParentDataRepository
    {
        Task<ParentDataDto> GetParentDataByIdAsync(int id);

        Task<ParentDataDto> CreateOrUpdateAsync(ParentDataDto parentDataDto);
    }
}
