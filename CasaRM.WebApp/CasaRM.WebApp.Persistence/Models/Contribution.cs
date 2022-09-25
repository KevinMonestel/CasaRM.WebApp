using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("Aportes")]
    public class Contribution
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SocialStudy")]
        public int SocialStudyId { get; set; }

        [Column("NombreCompleto")]
        [StringLength(250)]
        public string FullName { get; set; }

        [Column("Parentesco")]
        [StringLength(250)]
        public string Relationship { get; set; }

        [Column("Ocupacion")]
        [StringLength(100)]
        public string Ocupation { get; set; }

        [Column("AporteMensual")]
        public decimal MonthlyContribution { get; set; }

        public SocialStudy SocialStudy { get; set; }
    }
}
