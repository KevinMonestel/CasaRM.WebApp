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

        public async Task<CreateHost> CreateHostAsync(string userId)
        {
            CreateHost result = await _hostRepository.CreateHostAsync(userId);

            return result;
        }
    }
}
