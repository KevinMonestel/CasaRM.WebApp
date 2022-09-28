using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface IGuestHealthQuestionnaireRepository
    {
        Task<GuestHealthQuestionnaireDto> GetGuestHealthQuestionnaireByIdAsync(int id);

        Task<GuestHealthQuestionnaireDto> CreateOrUpdateAsync(GuestHealthQuestionnaireDto guestHealthQuestionnaireDto);
    }
}
