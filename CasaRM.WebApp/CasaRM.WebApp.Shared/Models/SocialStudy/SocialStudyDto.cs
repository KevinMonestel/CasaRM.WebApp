namespace CasaRM.WebApp.Shared.Models.SocialStudy
{
    public class SocialStudyDto
    {
        public int Id { get; set; }

        public int MinorPersonDataId { get; set; }

        public int HousingSituationId { get; set; }

        public decimal TotalRevenue { get; set; }

        public decimal PerCapitaIncome { get; set; }

        public string PovertyCategory { get; set; }

        public string SupportServices { get; set; }

        public string Recomendation { get; set; }

        public string SignatureDataUrl { get; set; }
    }
}
