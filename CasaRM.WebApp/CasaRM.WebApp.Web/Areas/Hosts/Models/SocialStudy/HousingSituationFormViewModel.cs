using Microsoft.Build.Framework;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy
{
    public class HousingSituationFormViewModel
    {
        [Required]
        public string HousingTenureCondition { get; set; }

        [Required]
        public string HousingConstructionMaterialsWall { get; set; }

        [Required]
        public string HousingConstructionMaterialsFloor { get; set; }

        [Required]
        public int RoomsQuantity { get; set; }

        [Required]
        public int BedroomsQuantity { get; set; }

        [Required]
        public int BathroomsQuantity { get; set; }

        [Required]
        public string HousingConservationStatus { get; set; }

        [Required]
        public IEnumerable<string> BasicServices { get; set; }
    }
}
