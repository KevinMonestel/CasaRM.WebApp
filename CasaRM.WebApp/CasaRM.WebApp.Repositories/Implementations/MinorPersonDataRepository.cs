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
    public class MinorPersonDataRepository : GenericRepository<MinorPersonData>, IMinorPersonDataRepository
    {
        public MinorPersonDataRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<MinorPersonDataDto> GetMinorPersonDataByIdAsync(int id)
        {
            try
            {
                MinorPersonDataDto result = new();
                MinorPersonData dbModel = await GetByIdAsync(id);

                result = dbModel.ToObject<MinorPersonDataDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<MinorPersonDataDto> CreateOrUpdateAsync(MinorPersonDataDto minorPersonDataDto)
        {
            try
            {
                MinorPersonDataDto result = new();
                MinorPersonData dbModel = minorPersonDataDto.ToObject<MinorPersonData>();

                if (minorPersonDataDto.Id > 0)
                    dbModel = await UpdateAsync(dbModel);
                else
                    dbModel = await AddAsync(dbModel);

                result = dbModel.ToObject<MinorPersonDataDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
