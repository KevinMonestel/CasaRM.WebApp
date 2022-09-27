namespace CasaRM.WebApp.Shared.Models.SocialStudy
{
    public class HousingSituationDto
    {
        public int Id { get; set; }

        public string HousingTenureCondition { get; set; }

        public string HousingConstructionMaterialsWall { get; set; }

        public string HousingConstructionMaterialsFloor { get; set; }

        public int RoomsQuantity { get; set; }

        public int BedroomsQuantity { get; set; }

        public int BathroomsQuantity { get; set; }

        public string HousingConservationStatus { get; set; }

        public IEnumerable<string> BasicServices { get; set; }
    }
}
