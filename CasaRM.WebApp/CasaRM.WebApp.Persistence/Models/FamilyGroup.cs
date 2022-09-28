using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("GruposFamiliares")]
    public class FamilyGroup
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

        [Column("Edad")]
        public int Age { get; set; }

        [Column("EstadoCivil")]
        [StringLength(100)]
        public string MaritalStatus { get; set; }

        [Column("Escolaridad")]
        [StringLength(100)]
        public string Scholarship { get; set; }

        [Column("Ocupacion")]
        [StringLength(100)]
        public string Ocupation { get; set; }

        [Column("IngresoBrutoMensual")]
        public decimal MonthlyGrossIncome { get; set; }

        [JsonIgnore]
        public SocialStudy SocialStudy { get; set; }
    }
}
