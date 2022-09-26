using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class ContributionRepository : GenericRepository<Contribution>, IContributionRepository
    {
        public ContributionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ContributionDto>> GetContributionBySocialStudyId(int socialStudyId)
        {
            try
            {
                IEnumerable<ContributionDto> result;
                IEnumerable<Contribution> dbModels = await FindAsync(x => x.SocialStudyId == socialStudyId);

                result = dbModels.ToObjectList<ContributionDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ContributionDto>> RefreshContributionAsync(int socialStudyId, IEnumerable<ContributionDto> contributionDtos)
        {
            try
            {
                IEnumerable<ContributionDto> result;
                IEnumerable<Contribution> dbModels = await FindAsync(x => x.SocialStudyId == socialStudyId);
                await RemoveRangeAsync(dbModels);

                foreach (ContributionDto contributionDto in contributionDtos)
                    contributionDto.SocialStudyId = socialStudyId;

                dbModels = contributionDtos.ToObjectList<Contribution>();
                dbModels = await AddRangeAsync(dbModels);

                result = dbModels.ToObjectList<ContributionDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
