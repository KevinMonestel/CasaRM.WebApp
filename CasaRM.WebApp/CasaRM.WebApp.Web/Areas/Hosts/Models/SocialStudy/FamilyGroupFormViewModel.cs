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
        [StringLength(250)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Relationship { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [StringLength(100)]
        public string MaritalStatus { get; set; }

        [Required]
        [StringLength(100)]
        public string Scholarship { get; set; }

        [Required]
        [StringLength(100)]
        public string Ocupation { get; set; }

        [Required]
        public decimal MonthlyGrossIncome { get; set; }
    }
}
