using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models.Host;
using System.Collections.Generic;

namespace CasaRM.WebApp.Services.Implementations
{
    public class HostingHistoryService : IHostingHistoryService
    {
        private readonly IHostingHistoryRepository _hostingHistoryRepository;

        public HostingHistoryService(IHostingHistoryRepository hostingHistoryRepository)
        {
            _hostingHistoryRepository = hostingHistoryRepository;
        }

        public async Task<IEnumerable<HostingHistoryDto>> GetByHostId(string id)
        {
            IEnumerable<HostingHistoryDto> results = await _hostingHistoryRepository.GetByHostId(id);

            return results;
        }

        public async Task<HostingHistoryDto> CreateAsync(HostingHistoryDto hostingHistoryDto)
        {
            HostingHistoryDto result = await _hostingHistoryRepository.CreateAsync(hostingHistoryDto);

            return result;
        }

        public async Task<HostingHistoryDto> DeleteAsync(int id)
        {
            HostingHistoryDto result = await _hostingHistoryRepository.DeleteAsync(id);

            return result;
        }
    }
}
