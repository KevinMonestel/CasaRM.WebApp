using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Implementations
{
    public class GuestHealthQuestionnaireRepository : GenericRepository<GuestHealthQuestionnaire>, IGuestHealthQuestionnaireRepository
    {
        public GuestHealthQuestionnaireRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<GuestHealthQuestionnaireDto> GetGuestHealthQuestionnaireByIdAsync(int id)
        {
            try
            {
                GuestHealthQuestionnaireDto result = new();

                GuestHealthQuestionnaire dbModel = await GetByIdAsync(id);

                result = dbModel.ToObject<GuestHealthQuestionnaireDto>();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<GuestHealthQuestionnaireDto> CreateOrUpdateAsync(GuestHealthQuestionnaireDto guestHealthQuestionnaireDto)
        {
            try
            {
                GuestHealthQuestionnaireDto result = new();

                GuestHealthQuestionnaire dbModel = guestHealthQuestionnaireDto.ToObject<GuestHealthQuestionnaire>();

                if (dbModel.Id > 0)
                    dbModel = await UpdateAsync(dbModel);
                else
                    dbModel = await AddAsync(dbModel);

                if (dbModel is null) throw new Exception();

                result = dbModel.ToObject<GuestHealthQuestionnaireDto>();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
