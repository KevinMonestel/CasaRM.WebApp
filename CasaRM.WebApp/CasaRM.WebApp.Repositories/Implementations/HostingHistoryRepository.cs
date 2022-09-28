using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
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
    }
}
