namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class ContributionListViewModel
    {
        public int Id { get; set; }

        public int SocialStudyId { get; set; }

        public string FullName { get; set; }

        public string Relationship { get; set; }

        public string Ocupation { get; set; }

        public decimal MonthlyContribution { get; set; }
    }
}
