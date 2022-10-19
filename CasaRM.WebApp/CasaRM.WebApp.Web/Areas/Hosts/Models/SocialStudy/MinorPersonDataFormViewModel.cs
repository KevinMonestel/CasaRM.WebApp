using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class MinorPersonDataFormViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }

        [Required]
        [StringLength(250)]
        public string FileNumber { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [StringLength(100)]
        public string Gender { get; set; }

        [Required]
        [StringLength(100)]
        public string Scholarship { get; set; }

        [Required]
        [StringLength(100)]
        public string Nacionality { get; set; }

        [Required]
        [StringLength(250)]
        public string Diagnosis { get; set; }

        [Required]
        [StringLength(250)]
        public string AttentionService { get; set; }

        [Required]
        [StringLength(250)]
        public string Treatment { get; set; }

        [Required]
        [StringLength(250)]
        public string TreatingPhysician { get; set; }

        [Required]
        [StringLength(100)]
        public string Province { get; set; }

        [Required]
        [StringLength(100)]
        public string Canton { get; set; }

        [Required]
        [StringLength(100)]
        public string District { get; set; }

        [Required]
        [StringLength(250)]
        public string ExactDirection { get; set; }

        [Required]
        [StringLength(100)]
        public string SocialSecurityType { get; set; }

        [Required]
        [StringLength(500)]
        public string Observations { get; set; }
    }
}
