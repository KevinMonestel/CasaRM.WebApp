using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IMinorPersonDataRepository
    {
        Task<MinorPersonDataDto> GetMinorPersonDataByIdAsync(int id);

        Task<MinorPersonDataDto> CreateOrUpdateAsync(MinorPersonDataDto minorPersonDataDto);
    }
}
