using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models;

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
    }
}
