using CasaRM.WebApp.Shared.Models;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IHostRepository
    {
        Task<int> GetSocialStudyIdByHostIdAsync(string hostId);

        Task<CreateHost> CreateHostAsync(string userId);
    }
}
