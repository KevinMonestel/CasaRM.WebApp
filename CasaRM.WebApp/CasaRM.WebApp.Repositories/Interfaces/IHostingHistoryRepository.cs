using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Shared.Models.History;
using CasaRM.WebApp.Shared.Models.Host;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IHostingHistoryRepository
    {
        Task<IEnumerable<HostingHistoryDto>> GetByHostId(string id);

        Task<HostingHistoryDto> CreateAsync(HostingHistoryDto hostingHistoryDto);

        Task<HostingHistoryDto> DeleteAsync(int id);

        Task<HostingHistoryDto> AssignHistoryTicketAsync(int id, int historyTicketDeliverId = 0, int historyTicketReceptionId = 0);

        Task<GetHistoryTicketsIdsResult> GetHistoryTicketsIdsByHistoryIdAsync(int id);

        Task<HostingHistoryDto> AssingEndDateByIdAsync(int id, DateTime endDate);

        Task<string> GetHostIdIfRoomIsNotValidByRoomNumberAsync(int roomNumber);
    }
}
