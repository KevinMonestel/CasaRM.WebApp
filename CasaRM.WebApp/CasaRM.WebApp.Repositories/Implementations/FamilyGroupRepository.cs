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
    public class FamilyGroupRepository : GenericRepository<FamilyGroup>, IFamilyGroupRepository
    {
        public FamilyGroupRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<FamilyGroupDto>> GetFamilyGroupBySocialStudyId(int socialStudyId)
        {
            try
            {
                IEnumerable<FamilyGroupDto> result;
                IEnumerable<FamilyGroup> dbModels = await FindAsync(x => x.SocialStudyId == socialStudyId);

                result = dbModels.ToObjectList<FamilyGroupDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<FamilyGroupDto>> RefreshFamilyGroupAsync(int socialStudyId, IEnumerable<FamilyGroupDto> familyGroupDtos)
        {
            try
            {
                IEnumerable<FamilyGroupDto> result;
                IEnumerable<FamilyGroup> dbModels = await FindAsync(x => x.SocialStudyId == socialStudyId);
                await RemoveRangeAsync(dbModels);

                foreach(FamilyGroupDto familyGroupDto in familyGroupDtos)
                    familyGroupDto.SocialStudyId = socialStudyId;

                dbModels = familyGroupDtos.ToObjectList<FamilyGroup>();
                dbModels = await AddRangeAsync(dbModels);

                result = dbModels.ToObjectList<FamilyGroupDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
