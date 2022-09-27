using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class IncomeCalculationFormViewModel
    {
        [Required]
        public decimal TotalRevenue { get; set; }

        [Required]
        public decimal PerCapitaIncome { get; set; }

        [Required]
        public string PovertyCategory { get; set; }
    }
}
