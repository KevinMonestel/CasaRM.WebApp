using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.SocialStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class CompanionDataRepository : GenericRepository<CompanionData>, ICompanionDataRepository
    {
        public CompanionDataRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<CompanionDataDto> GetCompanionDataByIdAsync(int id)
        {
            try
            {
                CompanionDataDto result = new();
                CompanionData dbModel = await GetByIdAsync(id);

                result = dbModel.ToObject<CompanionDataDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CompanionDataDto> CreateOrUpdateAsync(CompanionDataDto companionDataDto)
        {
            try
            {
                CompanionDataDto result = new();
                CompanionData dbModel = companionDataDto.ToObject<CompanionData>();

                if (companionDataDto.Id > 0)
                    dbModel = await UpdateAsync(dbModel);
                else
                    dbModel = await AddAsync(dbModel);

                result = dbModel.ToObject<CompanionDataDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
