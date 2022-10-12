using CasaRM.WebApp.Shared.Models.History;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IHistoryTicketRepository
    {
        Task<HistoryTicketDto> CreateOrUpdateAsync(HistoryTicketDto historyTicketDto);

        Task<HistoryTicketDto> GetHistoryTicketByIdAsync(int id);

        Task<HistoryTicketDto> DeleteAsync(int id);
    }
}
