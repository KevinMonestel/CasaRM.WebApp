using CasaRM.WebApp.Shared.Models;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IHostService
    {
        Task<CreateHost> CreateHost(string UserId);
    }
}
