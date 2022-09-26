using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IMinorPersonDataRepository
    {
        Task<MinorPersonDataDto> CreateOrUpdateAsync(MinorPersonDataDto minorPersonDataDto);
    }
}
