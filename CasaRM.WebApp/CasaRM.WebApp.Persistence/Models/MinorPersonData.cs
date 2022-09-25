using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("DatosPersonasMenores")]
    public class MinorPersonData
    {
        [Key]
        public int Id { get; set; }

        [Column("NombreCompleto")]
        [StringLength(250)]
        public string FullName { get; set; }

        [Column("NumeroExpediente")]
        [StringLength(250)]
        public string FileNumber { get; set; }

        [Column("FechaNacimiento")]
        public DateTime DateOfBirth { get; set; }

        [Column("Edad")]
        public int Age { get; set; }

        [Column("Sexo")]
        [StringLength(100)]
        public string Gender { get; set; }

        [Column("Escolaridad")]
        [StringLength(100)]
        public string Scholarship { get; set; }

        [Column("Nacionalidad")]
        [StringLength(100)]
        public string Nacionality { get; set; }

        [Column("Diagnostico")]
        [StringLength(250)]
        public string Diagnosis { get; set; }

        [Column("ServicioAtencion")]
        [StringLength(250)]
        public string AttentionService { get; set; }

        [Column("Tratamiento")]
        [StringLength(250)]
        public string Treatment { get; set; }

        [Column("MedicoTratante")]
        [StringLength(250)]
        public string TreatingPhysician { get; set; }

        [Column("Provincia")]
        [StringLength(100)]
        public string Province { get; set; }

        [Column("Canton")]
        [StringLength(100)]
        public string Canton { get; set; }

        [Column("Distrito")]
        [StringLength(100)]
        public string District { get; set; }

        [Column("DireccionExacta")]
        [StringLength(250)]
        public string ExactDirection { get; set; }

        [Column("TipoSeguroSocial")]
        [StringLength(100)]
        public string SocialSecurityType { get; set; }

        [Column("Onservaciones")]
        [StringLength(500)]
        public string Observations { get; set; }
    }
}
