using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class CompanionDataFormViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }

        [Required]
        [StringLength(250)]
        public string Relationship { get; set; }

        [Required]
        [StringLength(250)]
        public string Identification { get; set; }

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
        public string MaritalStatus { get; set; }

        [Required]
        [StringLength(100)]
        public string Nacionality { get; set; }

        [Required]
        [StringLength(100)]
        public string Scholarship { get; set; }

        [Required]
        [StringLength(100)]
        public string PhonesNumbers { get; set; }

        [Required]
        public string Ocupation { get; set; }

        [Required]
        [StringLength(100)]
        public string WorkAddress { get; set; }

        [Required]
        [StringLength(250)]
        public string Illness { get; set; }

        [Required]
        [StringLength(250)]
        public string Treatment { get; set; }

        [Required]
        [StringLength(500)]
        public string Observations { get; set; }

        [Required]
        public bool IsAPersonInCharge { get; set; }
    }
}
