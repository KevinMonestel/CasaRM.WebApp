using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class SupportServicesFormViewModel
    {
        [Required]
        [StringLength(250)]
        public string SupportServices { get; set; }
    }
}
