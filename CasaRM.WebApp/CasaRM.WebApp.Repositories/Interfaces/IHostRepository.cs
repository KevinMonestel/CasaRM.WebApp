using CasaRM.WebApp.Shared.Models;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IHostRepository
    {
        Task<CreateHost> CreateHost(string UserId);
    }
}
