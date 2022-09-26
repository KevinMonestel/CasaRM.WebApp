using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class ParentDataFormViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Relationship { get; set; }

        [Required]
        public string Identification { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string MaritalStatus { get; set; }

        [Required]
        public string Nacionality { get; set; }

        [Required]
        public string Scholarship { get; set; }

        [Required]
        public string PhonesNumbers { get; set; }

        [Required]
        public string Ocupation { get; set; }

        [Required]
        public string WorkAddress { get; set; }

        [Required]
        public string Illness { get; set; }

        [Required]
        public string Treatment { get; set; }

        [Required]
        public string Observations { get; set; }
    }
}
