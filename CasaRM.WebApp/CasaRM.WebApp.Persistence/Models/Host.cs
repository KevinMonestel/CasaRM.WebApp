using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("Huespedes")]
    public class Host
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("SocialStudy")]
        [Column("EstudioSocialId")]
        public int SocialStudyId { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column("CreadoPor")]
        public string CreatedBy { get; set; }

        [Column("CreadoEn")]
        public DateTime CreatedAt { get; set; }

        [Column("ActualizadoEn")]
        public DateTime UpdatedAt { get; set; }

        public SocialStudy SocialStudy { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
