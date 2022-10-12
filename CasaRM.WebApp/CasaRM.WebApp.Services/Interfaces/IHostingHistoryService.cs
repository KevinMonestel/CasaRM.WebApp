using CasaRM.WebApp.Shared.Models.History;
using CasaRM.WebApp.Shared.Models.Host;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface IHostingHistoryService
    {
        Task<IEnumerable<HostingHistoryDto>> GetByHostId(string id);

        Task<HostingHistoryDto> CreateAsync(HostingHistoryDto hostingHistoryDto);

        Task<HostingHistoryDto> DeleteAsync(int id);

        Task<HistoryTicketDto> CreateOrUpdateHistoryTicket(HistoryTicketDto historyTicketDto, int HostingHistoryId, string actionType);

        Task<GetHistoryTicketsIdsResult> GetHistoryTicketsIdsByHistoryIdAsync(int id);

        Task<HistoryTicketDto> GetHistoryTicketByIdAsync(int id);

        Task<bool> RoomIsValidByRoomNumberAsync(int roomNumber);
    }
}
