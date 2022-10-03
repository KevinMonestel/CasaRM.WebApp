namespace CasaRM.WebApp.Shared.Models.Catalog
{
    public class ApplicationCatalog
    {
        public IEnumerable<CatalogDto> HousingTenureConditions { get; set; }

        public IEnumerable<CatalogDto> HousingConstructionMaterialsWalls { get; set; }

        public IEnumerable<CatalogDto> HousingConstructionMaterialsFloors { get; set; }

        public IEnumerable<CatalogDto> RoomTypes { get; set; }

        public IEnumerable<CatalogDto> HousingConservationStatuses { get; set; }

        public IEnumerable<CatalogDto> BasicServices { get; set; }

        public IEnumerable<CatalogDto> HostDocuments { get; set; }
    }
}
