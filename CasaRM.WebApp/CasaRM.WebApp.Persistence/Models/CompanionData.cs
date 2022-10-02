using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("DatosAcompannantes")]
    public class CompanionData
    {
        [Key]
        public int Id { get; set; }

        [Column("EstudioSocialId")]
        [ForeignKey("SocialStudy")]
        public int SocialStudyId { get; set; }

        [Column("NombreCompleto")]
        [StringLength(250)]
        public string FullName { get; set; }

        [Column("Parentesco")]
        [StringLength(250)]
        public string Relationship { get; set; }

        [Column("Identificacion")]
        [StringLength(250)]
        public string Identification { get; set; }

        [Column("FechaNacimiento")]
        public DateTime DateOfBirth { get; set; }

        [Column("Edad")]
        public int Age { get; set; }

        [Column("Sexo")]
        [StringLength(100)]
        public string Gender { get; set; }

        [Column("EstadoCivil")]
        [StringLength(100)]
        public string MaritalStatus { get; set; }

        [Column("Nacionalidad")]
        [StringLength(100)]
        public string Nacionality { get; set; }

        [Column("Escolaridad")]
        [StringLength(100)]
        public string Scholarship { get; set; }

        [Column("Telefonos")]
        [StringLength(100)]
        public string PhonesNumbers { get; set; }

        [Column("Ocupacion")]
        [StringLength(100)]
        public string Ocupation { get; set; }

        [Column("LugarDeTrabajo")]
        [StringLength(100)]
        public string WorkAddress { get; set; }

        [Column("Enfermedad")]
        [StringLength(100)]
        public string Illness { get; set; }

        [Column("Tratamiento")]
        [StringLength(250)]
        public string Treatment { get; set; }

        [Column("Observaciones")]
        [StringLength(500)]
        public string Observations { get; set; }

        [Column("EsPersonaACargo")]
        public bool IsAPersonInCharge { get; set; }

        [JsonIgnore]
        public SocialStudy SocialStudy { get; set; }
    }
}
