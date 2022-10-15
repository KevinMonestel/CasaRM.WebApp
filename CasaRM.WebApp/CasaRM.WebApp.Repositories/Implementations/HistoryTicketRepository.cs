using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.History;
using CasaRM.WebApp.Shared.Models.Host;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class HistoryTicketRepository : GenericRepository<HistoryTicket>, IHistoryTicketRepository
    {
        public HistoryTicketRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<HistoryTicketDto> GetHistoryTicketByIdAsync(int id)
        {
            try
            {
                HistoryTicketDto result = new();
                HistoryTicket dbModel = await GetByIdAsync(id);

                if (dbModel is null) throw new Exception("HistoryTicket not founded");

                result = dbModel.ToObject<HistoryTicketDto>();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<HistoryTicketDto> CreateOrUpdateAsync(HistoryTicketDto historyTicketDto)
        {
            try
            {
                HistoryTicketDto result = new();
                HistoryTicket dbModel = historyTicketDto.ToObject<HistoryTicket>();
                dbModel.CreatedAt = DateTime.Now.ToCentralTime();

                if (dbModel.Id.Equals(0))
                    dbModel = await AddAsync(dbModel);

                else
                    dbModel = await UpdateAsync(dbModel);

                result = dbModel.ToObject<HistoryTicketDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<HistoryTicketDto> DeleteAsync(int id)
        {
            try
            {
                HistoryTicketDto result = new();
                HistoryTicket dbModel = await GetByIdAsync(id);

                dbModel = await RemoveAsync(dbModel);

                if (dbModel is null) throw new Exception();

                result = dbModel.ToObject<HistoryTicketDto>();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
