using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class SocialStudyRepository : GenericRepository<SocialStudy>, ISocialStudyRepository
    {
        public SocialStudyRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<SocialStudyDto> GetSocialStudyById(int id)
        {
            try
            {
                SocialStudyDto result = new();
                SocialStudy dbModel = await GetByIdAsync(id);

                result = dbModel.ToObject<SocialStudyDto>();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<SocialStudyDto> CreateOrUpdateAsync(SocialStudyDto socialStudyDto)
        {
            try
            {
                SocialStudyDto result = new();
                SocialStudy dbModel = socialStudyDto.ToObject<SocialStudy>();

                if (dbModel.Id > 0)
                    dbModel = await UpdateAsync(dbModel);
                else
                    dbModel = await AddAsync(dbModel);

                if (dbModel is null) throw new Exception();

                result = dbModel.ToObject<SocialStudyDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
