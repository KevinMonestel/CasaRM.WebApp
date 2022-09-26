using CasaRM.WebApp.Shared.Models;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IHostService
    {
        Task<int> GetSocialStudyIdByHostIdAsync(string hostId);

        Task<CreateHost> CreateHostAsync(string userId);
    }
}
