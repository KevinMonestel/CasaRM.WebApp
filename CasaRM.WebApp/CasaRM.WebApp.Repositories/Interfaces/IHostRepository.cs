using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IHostRepository
    {
        Task<int> GetSocialStudyIdByHostIdAsync(string hostId);

        Task<HostDto> CreateHostAsync(HostDto hostDto);
    }
}
