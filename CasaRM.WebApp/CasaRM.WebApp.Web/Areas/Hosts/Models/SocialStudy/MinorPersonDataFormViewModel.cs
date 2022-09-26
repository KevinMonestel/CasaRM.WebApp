using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class MinorPersonDataFormViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string FileNumber { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Scholarship { get; set; }

        [Required]
        public string Nacionality { get; set; }

        [Required]
        public string Diagnosis { get; set; }

        [Required]
        public string AttentionService { get; set; }

        [Required]
        public string Treatment { get; set; }

        [Required]
        public string TreatingPhysician { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Canton { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public string ExactDirection { get; set; }

        [Required]
        public string SocialSecurityType { get; set; }

        [Required]
        public string Observations { get; set; }
    }
}
