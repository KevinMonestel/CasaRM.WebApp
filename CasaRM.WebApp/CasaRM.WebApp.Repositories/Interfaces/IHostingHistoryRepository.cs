using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Shared.Models.Host;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IHostingHistoryRepository
    {
        Task<IEnumerable<HostingHistoryDto>> GetByHostId(string id);

        Task<HostingHistoryDto> CreateAsync(HostingHistoryDto hostingHistoryDto);

        Task<HostingHistoryDto> DeleteAsync(int id);
    }
}
