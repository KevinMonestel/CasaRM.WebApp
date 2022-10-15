using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models.History;
using CasaRM.WebApp.Shared.Models.Host;
using System.Collections.Generic;

namespace CasaRM.WebApp.Services.Implementations
{
    public class HostingHistoryService : IHostingHistoryService
    {
        private readonly IHostingHistoryRepository _hostingHistoryRepository;
        private readonly IHistoryTicketRepository _historyTicketRepository;

        public HostingHistoryService(IHostingHistoryRepository hostingHistoryRepository,
            IHistoryTicketRepository historyTicketRepository)
        {
            _hostingHistoryRepository = hostingHistoryRepository;
            _historyTicketRepository = historyTicketRepository;
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

            if(result.HistoryTicketDeliveryId.HasValue)
                await _historyTicketRepository.DeleteAsync(result.HistoryTicketDeliveryId.GetValueOrDefault());

            if (result.HistoryTicketReceptionId.HasValue)
                await _historyTicketRepository.DeleteAsync(result.HistoryTicketReceptionId.GetValueOrDefault());

            return result;
        }

        public async Task<HistoryTicketDto> CreateOrUpdateHistoryTicket(HistoryTicketDto historyTicketDto, int HostingHistoryId, string actionType)
        {
            HistoryTicketDto historyTicketCreated = await _historyTicketRepository.CreateOrUpdateAsync(historyTicketDto);
            HostingHistoryDto hostingHistoryUpdated = new();

            if (historyTicketCreated is null) throw new Exception("HistoryTicket cannot be created");

            if (actionType.Equals("Delivery"))
                hostingHistoryUpdated = await _hostingHistoryRepository.AssignHistoryTicketAsync(HostingHistoryId, historyTicketCreated.Id, 0);
            if (actionType.Equals("Reception"))
            {
                hostingHistoryUpdated = await _hostingHistoryRepository.AssignHistoryTicketAsync(HostingHistoryId, 0, historyTicketCreated.Id);
                hostingHistoryUpdated = await _hostingHistoryRepository.AssingEndDateByIdAsync(HostingHistoryId, historyTicketCreated.CreatedAt);
            }

            return historyTicketCreated;
        }

        public async Task<GetHistoryTicketsIdsResult> GetHistoryTicketsIdsByHistoryIdAsync(int id)
        {
            return await _hostingHistoryRepository.GetHistoryTicketsIdsByHistoryIdAsync(id);
        }

        public async Task<HistoryTicketDto> GetHistoryTicketByIdAsync(int id)
        {
            return await _historyTicketRepository.GetHistoryTicketByIdAsync(id);
        }

        public async Task<string> GetHostIdIfRoomIsNotValidByRoomNumberAsync(int roomNumber)
        {
            return await _hostingHistoryRepository.GetHostIdIfRoomIsNotValidByRoomNumberAsync(roomNumber);
        }
    }
}
