using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class RecomendationFormViewModel
    {
        [Required]
        [StringLength(250)]
        public string Recomendation { get; set; }
    }
}
