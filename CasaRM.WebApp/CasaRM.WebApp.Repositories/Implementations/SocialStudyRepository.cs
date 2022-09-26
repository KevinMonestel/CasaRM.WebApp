using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class SocialStudyRepository : GenericRepository<SocialStudy>, ISocialStudyRepository
    {
        public SocialStudyRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<int> CreateSocialStudyAsync()
        {
            try
            {
                int result = 0;

                SocialStudy socialStudy = await AddAsync(new SocialStudy
                {
                    MinorPersonDataId = null,
                    CompanionDataId = null,
                    ParentDataId = null
                });

                result = socialStudy is not null ? socialStudy.Id : result;

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
