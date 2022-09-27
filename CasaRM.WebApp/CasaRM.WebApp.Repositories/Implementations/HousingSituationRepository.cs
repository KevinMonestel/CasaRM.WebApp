using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.SocialStudy;
using System.Linq;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class HousingSituationRepository : GenericRepository<HousingSituation>, IHousingSituationRepository
    {
        public HousingSituationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<HousingSituationDto> GetHousingSituationByIdAsync(int id)
        {
            try
            {
                HousingSituationDto result = new();

                HousingSituation dbModel = await GetByIdAsync(id);

                result = dbModel.ToObject<HousingSituationDto>();

                result.BasicServices = dbModel?.BasicServices.Split('|');

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<HousingSituationDto> CreateOrUpdateAsync(HousingSituationDto housingSituationDto)
        {
            try
            {
                HousingSituationDto result = new();

                HousingSituation dbModel = housingSituationDto.ToObject<HousingSituation>();

                dbModel.BasicServices = string.Join("|", housingSituationDto.BasicServices);

                if (dbModel.Id > 0)
                    dbModel = await UpdateAsync(dbModel);
                else
                    dbModel = await AddAsync(dbModel);

                if (dbModel is null) throw new Exception();

                result = dbModel.ToObject<HousingSituationDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
