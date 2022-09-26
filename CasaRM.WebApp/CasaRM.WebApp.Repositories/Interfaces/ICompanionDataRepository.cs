using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface ICompanionDataRepository
    {
        Task<CompanionDataDto> GetCompanionDataByIdAsync(int id);

        Task<CompanionDataDto> CreateOrUpdateAsync(CompanionDataDto companionDataDto);
    }
}
