using Microsoft.Build.Framework;
using System.ComponentModel;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class GuestHealthQuestionaireFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("¿Fiebre de más de 100.4ªF (38.0 ºC) en los últimos 2 días?")]
        public bool Question1 { get; set; }

        [Required]
        [DisplayName("¿Vómitos en los últimos 2 días?")]
        public bool Question2 { get; set; }

        [Required]
        [DisplayName("¿Cuello rígido o dolor de cabeza con fiebre en los últimos 2 días?")]
        public bool Question3 { get; set; }

        [Required]
        [DisplayName("¿Diarrea en los últimos 2 días?")]
        public bool Question4 { get; set; }

        [Required]
        [DisplayName("¿En este momento tiene lesiones en la piel que “supuran” (llenas de líquido o pus)?")]
        public bool Question5 { get; set; }

        [Required]
        [DisplayName("¿Algún tipo de rash / sarpullido en la piel en este momento?")]
        public bool Question6 { get; set; }

        [Required]
        [DisplayName("¿Tiene síntomas de resfrío o gripe (mucosidad, tos, congestión)?")]
        public bool Question7 { get; set; }

        [Required]
        [DisplayName("¿Exposición a tuberculosis (TB) en los últimos 2 meses?")]
        public bool Question8 { get; set; }

        [Required]
        [DisplayName("------ Varicela")]
        public bool Question9 { get; set; }

        [Required]
        [DisplayName("------ Miembro del hogar con piojos")]
        public bool Question10 { get; set; }

        [Required]
        [DisplayName("------ Sarampión")]
        public bool Question11 { get; set; }

        [Required]
        [DisplayName("------ Paperas")]
        public bool Question12 { get; set; }

        [Required]
        [DisplayName("------ Tos convulsa")]
        public bool Question13 { get; set; }

        [Required]
        [DisplayName("¿Ha tenido varicela antes?")]
        public bool Question14 { get; set; }

        [Required]
        [DisplayName("¿Se ha vacunado contra la varicela?")]
        public bool Question15 { get; set; }

        [Required]
        [DisplayName("¿Ha tenido varicela antes?")]
        public bool Question16 { get; set; }

        [Required]
        [DisplayName("¿Se ha vacunado contra la varicela?")]
        public bool Question17 { get; set; }

        [Required]
        [DisplayName("¿Ha tenido varicela antes?")]
        public bool Question18 { get; set; }

        [Required]
        [DisplayName("¿Se ha vacunado contra la varicela?")]
        public bool Question19 { get; set; }
    }
}
