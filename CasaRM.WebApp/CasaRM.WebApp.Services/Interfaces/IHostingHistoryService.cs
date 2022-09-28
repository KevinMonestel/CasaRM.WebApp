using CasaRM.WebApp.Shared.Models.Host;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IHostingHistoryService
    {
        Task<IEnumerable<HostingHistoryDto>> GetByHostId(string id);

        Task<HostingHistoryDto> CreateAsync(HostingHistoryDto hostingHistoryDto);

        Task<HostingHistoryDto> DeleteAsync(int id);
    }
}
