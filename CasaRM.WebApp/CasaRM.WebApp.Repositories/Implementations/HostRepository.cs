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

        public async Task<CreateHost> CreateHost(string UserId)
        {
            try
            {
                CreateHost result = new();

                int socialStudyIdCreated = await _socialStudyRepository.CreateSocialStudy();

                if (socialStudyIdCreated.Equals(0)) throw new Exception();

                Host newHostRecord = await AddAsync(new Host
                {
                    SocialStudyId = socialStudyIdCreated,
                    CreatedBy = UserId,
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
