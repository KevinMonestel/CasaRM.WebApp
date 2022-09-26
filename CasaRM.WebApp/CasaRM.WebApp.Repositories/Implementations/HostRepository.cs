using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Models.SocialStudy;

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

        public async Task<HostDto> CreateHostAsync(HostDto hostDto)
        {
            try
            {
                Host dbModel = await AddAsync(new Host
                {
                    SocialStudyId = hostDto.SocialStudyId,
                    CreatedBy = hostDto.CreatedBy,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                if (dbModel is null) throw new Exception();

                hostDto.Id = dbModel.Id.ToString();

                return hostDto;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
