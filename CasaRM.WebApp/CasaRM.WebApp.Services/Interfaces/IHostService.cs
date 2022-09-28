using CasaRM.WebApp.Shared.Models.Host;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IHostService
    {
        Task<int> GetSocialStudyIdByHostIdAsync(string hostId);

        Task<IEnumerable<SearchHostResultsDto>> SearchHostsAsync(SearchHostDto searchHostDto);
    }
}
