using CasaRM.WebApp.Repositories.Implementations;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models;
using CasaRM.WebApp.Shared.Models.Host;

namespace CasaRM.WebApp.Services.Implementations
{
    public class HostService : IHostService
    {
        private readonly IHostRepository _hostRepository;

        public HostService(IHostRepository hostRepository)
        {
            _hostRepository = hostRepository;
        }

        public async Task<int> GetSocialStudyIdByHostIdAsync(string hostId)
        {
            return await _hostRepository.GetSocialStudyIdByHostIdAsync(hostId);
        }

        public async Task<IEnumerable<SearchHostResultsDto>> SearchHostsAsync(SearchHostDto searchHostDto)
        {
            IEnumerable<SearchHostResultsDto> result = Enumerable.Empty<SearchHostResultsDto>();

            result = await _hostRepository.SearchHostByHostSearchingAsync(searchHostDto);

            return result;
        }
    }
}
