﻿namespace CasaRM.WebApp.Shared.Models.Catalog
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

        public IEnumerable<CatalogDto> MaritalStatuses { get; set; }

        public IEnumerable<CatalogDto> Genders { get; set; }

        public IEnumerable<CatalogDto> Nationalities { get; set; }

        public IEnumerable<CatalogDto> Scholarships { get; set; }

        public IEnumerable<CatalogDto> Relationships { get; set; }

        public IEnumerable<CatalogDto> AttentionServices { get; set; }
    }
}
