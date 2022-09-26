using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class ParentDataRepository : GenericRepository<ParentData>, IParentDataRepository
    {
        public ParentDataRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<ParentDataDto> GetParentDataByIdAsync(int id)
        {
            try
            {
                ParentDataDto result = new();
                ParentData dbModel = await GetByIdAsync(id);

                result = dbModel.ToObject<ParentDataDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ParentDataDto> CreateOrUpdateAsync(ParentDataDto parentDataDto)
        {
            try
            {
                ParentDataDto result = new();
                ParentData dbModel = parentDataDto.ToObject<ParentData>();

                if (parentDataDto.Id > 0)
                    dbModel = await UpdateAsync(dbModel);
                else
                    dbModel = await AddAsync(dbModel);

                result = dbModel.ToObject<ParentDataDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
