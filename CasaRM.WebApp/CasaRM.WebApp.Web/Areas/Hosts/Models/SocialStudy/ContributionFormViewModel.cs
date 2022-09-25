using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class ContributionFormViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int SocialStudyId { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }

        [Required]
        [StringLength(250)]
        public string Relationship { get; set; }

        [Required]
        [StringLength(100)]
        public string Ocupation { get; set; }

        [Required]
        public decimal MonthlyContribution { get; set; }
    }
}
