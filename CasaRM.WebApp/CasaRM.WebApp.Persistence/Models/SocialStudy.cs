using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("EstudiosSociales")]
    public class SocialStudy
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MinorPersonData")]
        [Column("DatosPersonaMenorId")]
        public int? MinorPersonDataId { get; set; }

        [ForeignKey("ParentData")]
        [Column("DatosEncargadoId")]
        public int? ParentDataId { get; set; }

        [ForeignKey("CompanionData")]
        [Column("DatosAcompannanteId")]
        public int? CompanionDataId { get; set; }

        public MinorPersonData? MinorPersonData { get; set; }

        public ParentData? ParentData { get; set; }

        public CompanionData? CompanionData { get; set; }

        public ICollection<FamilyGroup> FamilyGroup { get; set; }

        public ICollection<Contribution> Contribution { get; set; }
    }
}
