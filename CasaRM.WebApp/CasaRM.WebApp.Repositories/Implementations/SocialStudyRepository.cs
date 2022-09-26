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

        public async Task<SocialStudyDto> CreateSocialStudyAsync(SocialStudyDto socialStudyDto)
        {
            try
            {
                SocialStudy dbModel = await AddAsync(new SocialStudy
                {
                    MinorPersonDataId = socialStudyDto.MinorPersonDataId,
                    CompanionDataId = socialStudyDto.CompanionDataId,
                    ParentDataId = socialStudyDto.ParentDataId
                });

                if (dbModel is null) throw new Exception();

                socialStudyDto.Id = dbModel.Id;

                return socialStudyDto;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
