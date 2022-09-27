﻿namespace CasaRM.WebApp.Shared.Models.SocialStudy
{
    public class SocialStudyDto
    {
        public int Id { get; set; }

        public int MinorPersonDataId { get; set; }

        public int ParentDataId { get; set; }

        public int CompanionDataId { get; set; }

        public decimal TotalRevenue { get; set; }

        public decimal PerCapitaIncome { get; set; }

        public string PovertyCategory { get; set; }
    }
}
