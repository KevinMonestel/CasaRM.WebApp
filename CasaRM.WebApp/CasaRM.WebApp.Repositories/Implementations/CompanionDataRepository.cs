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
    public class CompanionDataRepository : GenericRepository<CompanionData>, ICompanionDataRepository
    {
        public CompanionDataRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CompanionDataDto>> GetFamilyGroupBySocialStudyId(int socialStudyId)
        {
            try
            {
                IEnumerable<CompanionDataDto> result;
                IEnumerable<CompanionData> dbModels = await FindAsync(x => x.SocialStudyId == socialStudyId);

                result = dbModels.ToObjectList<CompanionDataDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<CompanionDataDto>> RefreshFamilyGroupAsync(int socialStudyId, IEnumerable<CompanionDataDto> companionDataDtos)
        {
            try
            {
                IEnumerable<CompanionDataDto> result;
                IEnumerable<CompanionData> dbModels = await FindAsync(x => x.SocialStudyId == socialStudyId);
                await RemoveRangeAsync(dbModels);

                foreach (CompanionDataDto companionDataDto in companionDataDtos)
                    companionDataDto.SocialStudyId = socialStudyId;

                dbModels = companionDataDtos.ToObjectList<CompanionData>();
                dbModels = await AddRangeAsync(dbModels);

                result = dbModels.ToObjectList<CompanionDataDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
