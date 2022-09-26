using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Services.Interfaces
{
    public interface ISocialStudyService
    {
        Task<CreateOrUpdateSocialStudyDto> GetFullSocialStudyAsync(int socialStudyId);

        Task<string> CreateOrUpdateSocialStudyAsync(CreateOrUpdateSocialStudyDto createOrUpdateSocialStudyDto);
    }
}
