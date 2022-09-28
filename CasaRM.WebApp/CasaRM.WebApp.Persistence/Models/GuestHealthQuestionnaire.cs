using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("CuestionariosSaludHuespedes")]
    public class GuestHealthQuestionnaire
    {
        [Key]
        public int Id { get; set; }

        [Column("Pregunta1")]
        public bool Question1 { get; set; }

        [Column("Pregunta2")]
        public bool Question2 { get; set; }

        [Column("Pregunta3")]
        public bool Question3 { get; set; }

        [Column("Pregunta4")]
        public bool Question4 { get; set; }

        [Column("Pregunta5")]
        public bool Question5 { get; set; }

        [Column("Pregunta6")]
        public bool Question6 { get; set; }

        [Column("Pregunta7")]
        public bool Question7 { get; set; }

        [Column("Pregunta8")]
        public bool Question8 { get; set; }

        [Column("Pregunta9")]
        public bool Question9 { get; set; }

        [Column("Pregunta10")]
        public bool Question10 { get; set; }

        [Column("Pregunta11")]
        public bool Question11 { get; set; }

        [Column("Pregunta12")]
        public bool Question12 { get; set; }

        [Column("Pregunta13")]
        public bool Question13 { get; set; }

        [Column("Pregunta14")]
        public bool Question14 { get; set; }

        [Column("Pregunta15")]
        public bool Question15 { get; set; }

        [Column("Pregunta16")]
        public bool Question16 { get; set; }

        [Column("Pregunta17")]
        public bool Question17 { get; set; }

        [Column("Pregunta18")]
        public bool Question18 { get; set; }

        [Column("Pregunta19")]
        public bool Question19 { get; set; }
    }
}
