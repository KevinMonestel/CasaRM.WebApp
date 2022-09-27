using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IHousingSituationRepository
    {
        Task<HousingSituationDto> GetHousingSituationByIdAsync(int id);

        Task<HousingSituationDto> CreateOrUpdateAsync(HousingSituationDto housingSituationDto);
    }
}
