using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRM.WebApp.Shared.Models.SocialStudy
{
    public class CreateOrUpdateSocialStudyDto
    {
        public string HostId { get; set; }

        public int SocialStudyId { get; set; }

        public string ExecutedBy { get; set; }

        public MinorPersonDataDto MinorPersonDataDto { get; set; }

        public ParentDataDto ParentDataDto { get; set; }

        public CompanionDataDto CompanionDataDto { get; set; }

        public IEnumerable<FamilyGroupDto> FamilyGroupDto { get; set; }

        public IEnumerable<ContributionDto> ContributionDto { get; set; }

        public IncomeCalculationDto IncomeCalculationDto { get; set; }

        public HousingSituationDto HousingSituationDto { get; set; }

        public SupportServicesDto SupportServicesDto { get; set; }

        public RecomendationDto RecomendationDto { get; set; }

        public GuestHealthQuestionnaireDto GuestHealthQuestionnaireDto { get; set; }
    }
}
