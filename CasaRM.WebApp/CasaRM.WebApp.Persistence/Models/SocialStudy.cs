using Microsoft.VisualBasic;
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
        public int MinorPersonDataId { get; set; }

        [ForeignKey("HousingSituation")]
        [Column("SituacionHabitacionalId")]
        public int HousingSituationId { get; set; }

        [Column("TotalIngresos")]
        public decimal TotalRevenue { get; set; }

        [Column("IngresoPerCapita")]
        public decimal PerCapitaIncome { get; set; }

        [StringLength(100)]
        [Column("CategoriaPobreza")]
        public string PovertyCategory { get; set; }

        [StringLength(250)]
        [Column("RedesApoyo")]
        public string SupportServices { get; set; }

        [StringLength(500)]
        [Column("Recomendaciones")]
        public string Recomendation { get; set; }

        [Column("DatosFirmaUrl")]
        public string SignatureDataUrl { get; set; }

        public MinorPersonData MinorPersonData { get; set; }

        public ICollection<FamilyGroup> FamilyGroup { get; set; }

        public ICollection<Contribution> Contribution { get; set; }

        public ICollection<CompanionData> CompanionData { get; set; }

        public HousingSituation HousingSituation { get; set; }
    }
}
