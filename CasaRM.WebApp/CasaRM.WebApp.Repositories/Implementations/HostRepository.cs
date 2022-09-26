using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Models;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class HostRepository : GenericRepository<Host>, IHostRepository
    {
        private readonly ISocialStudyRepository _socialStudyRepository;

        public HostRepository(ApplicationDbContext context, ISocialStudyRepository socialStudyRepository) : base(context)
        {
            _socialStudyRepository = socialStudyRepository;
        }

        public async Task<int> GetSocialStudyIdByHostIdAsync(string hostId)
        {
            try
            {
                int result = 0;

                Host hostFinded = (await FindAsync(x => x.Id.ToString() == hostId)).FirstOrDefault();

                result = hostFinded is not null ? hostFinded.SocialStudyId : result;

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CreateHost> CreateHostAsync(string userId)
        {
            try
            {
                CreateHost result = new();

                int socialStudyIdCreated = await _socialStudyRepository.CreateSocialStudyAsync();

                if (socialStudyIdCreated.Equals(0)) throw new Exception();

                Host newHostRecord = await AddAsync(new Host
                {
                    SocialStudyId = socialStudyIdCreated,
                    CreatedBy = userId,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                if (newHostRecord is null) throw new Exception();

                result.HostId = newHostRecord.Id.ToString();
                result.SocialStudyId = socialStudyIdCreated;

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
