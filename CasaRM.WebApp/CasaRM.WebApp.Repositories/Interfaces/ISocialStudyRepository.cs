using CasaRM.WebApp.Shared.Models.SocialStudy;

namespace CasaRM.WebApp.Repositories.Interfaces
{
    public interface ISocialStudyRepository
    {
        Task<SocialStudyDto> GetSocialStudyById(int id);

        Task<SocialStudyDto> CreateOrUpdateAsync(SocialStudyDto socialStudyDto);
    }
}
