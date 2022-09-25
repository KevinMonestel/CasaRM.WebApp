using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class FamilyGroupFormViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int SocialStudyId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Relationship { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string MaritalStatus { get; set; }

        [Required]
        public string Scholarship { get; set; }

        [Required]
        public string Ocupation { get; set; }

        [Required]
        public decimal MonthlyGrossIncome { get; set; }
    }
}
