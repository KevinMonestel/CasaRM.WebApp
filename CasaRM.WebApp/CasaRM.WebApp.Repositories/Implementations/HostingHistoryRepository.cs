using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.History;
using CasaRM.WebApp.Shared.Models.Host;
using System.Collections.Generic;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class HostingHistoryRepository : GenericRepository<HostingHistory>, IHostingHistoryRepository
    {
        public HostingHistoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<HostingHistoryDto>> GetByHostId(string id)
        {
            try
            {
                IEnumerable<HostingHistoryDto> results;

                IEnumerable<HostingHistory> dbModels = await FindAsync(x => x.HostId.ToString() == id);

                results = dbModels.ToObjectList<HostingHistoryDto>();

                return results;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<HostingHistoryDto> CreateAsync(HostingHistoryDto hostingHistoryDto)
        {
            try
            {
                HostingHistoryDto result = new();
                HostingHistory dbModel = hostingHistoryDto.ToObject<HostingHistory>();

                dbModel.CreatedAt = DateTime.Now;

                dbModel = await AddAsync(dbModel);

                if (dbModel is null) throw new Exception();

                result = dbModel.ToObject<HostingHistoryDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<HostingHistoryDto> DeleteAsync(int id)
        {
            try
            {
                HostingHistoryDto result = new();
                HostingHistory dbModel = await GetByIdAsync(id);

                dbModel = await RemoveAsync(dbModel);

                if (dbModel is null) throw new Exception();

                result = dbModel.ToObject<HostingHistoryDto>();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<HostingHistoryDto> AssignHistoryTicketAsync(int id, int historyTicketDeliverId = 0, int historyTicketReceptionId = 0)
        {
            try
            {
                HostingHistoryDto result = new();
                HostingHistory dbModel = await GetByIdAsync(id);

                if (dbModel is null) throw new Exception("History not founded");

                dbModel.HistoryTicketDeliveryId = historyTicketDeliverId > 0 ? historyTicketDeliverId : dbModel.HistoryTicketDeliveryId;
                dbModel.HistoryTicketReceptionId = historyTicketReceptionId > 0 ? historyTicketReceptionId : dbModel.HistoryTicketReceptionId;

                dbModel = await UpdateAsync(dbModel);

                if (dbModel is null) throw new Exception("History cannot be updated");

                result = dbModel.ToObject<HostingHistoryDto>();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<GetHistoryTicketsIdsResult> GetHistoryTicketsIdsByHistoryIdAsync(int id)
        {
            try
            {
                GetHistoryTicketsIdsResult result = new();
                HostingHistory dbModel = await GetByIdAsync(id);

                if (dbModel is null) throw new Exception("History not founded");

                result.HistoryTicketDeliveryId = dbModel.HistoryTicketDeliveryId;
                result.HistoryTicketReceptionId = dbModel.HistoryTicketReceptionId;

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<HostingHistoryDto> AssingEndDateByIdAsync(int id, DateTime endDate)
        {
            try
            {
                HostingHistoryDto result = new();
                HostingHistory dbModel = await GetByIdAsync(id);

                if (dbModel is null) throw new Exception("History not founded");

                dbModel.EndDate = endDate;

                dbModel = await UpdateAsync(dbModel);

                if (dbModel is null) throw new Exception("History cannot be updated");

                result = dbModel.ToObject<HostingHistoryDto>();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> GetHostIdIfRoomIsNotValidByRoomNumberAsync(int roomNumber)
        {
            try
            {
                string result = string.Empty;
                HostingHistory dbModel = (await FindAsync(x => x.RoomNumber == roomNumber && x.EndDate == null)).FirstOrDefault();

                if (dbModel is not null) result = dbModel.HostId.ToString();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
