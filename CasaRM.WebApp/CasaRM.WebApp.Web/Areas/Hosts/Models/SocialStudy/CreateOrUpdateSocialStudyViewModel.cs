namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class CreateOrUpdateSocialStudyViewModel
    {
        public CreateOrUpdateSocialStudyViewModel()
        {
            MinorPersonDataFormViewModel = new();
            ParentDataFormViewModel = new();
            CompanionDataFormViewModel = new();
            FamilyGroupFormViewModel = new();
            FamilyGroupListViewModel = new();
            ContributionFormViewModel = new();
            ContributionListViewModel = new();

            MinorPersonDataFormViewModel.DateOfBirth = DateTime.Now.Date;
            ParentDataFormViewModel.DateOfBirth = DateTime.Now.Date;
            CompanionDataFormViewModel.DateOfBirth = DateTime.Now.Date;
        }

        public string HostId { get; set; }

        public int SocialStudyId { get; set; }

        public MinorPersonDataFormViewModel MinorPersonDataFormViewModel { get; set; }

        public ParentDataFormViewModel ParentDataFormViewModel { get; set; }

        public CompanionDataFormViewModel CompanionDataFormViewModel { get; set; }

        public FamilyGroupFormViewModel FamilyGroupFormViewModel { get; set; }

        public List<FamilyGroupListViewModel> FamilyGroupListViewModel { get; set; }

        public ContributionFormViewModel ContributionFormViewModel { get; set; }

        public List<ContributionListViewModel> ContributionListViewModel { get; set; }

        public IncomeCalculationFormViewModel IncomeCalculationFormViewModel { get; set; }

        public HousingSituationFormViewModel HousingSituationFormViewModel { get; set; }
    }
}
