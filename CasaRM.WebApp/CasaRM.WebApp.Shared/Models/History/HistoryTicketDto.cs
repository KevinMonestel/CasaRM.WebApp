namespace CasaRM.WebApp.Shared.Models.History
{
    public class HistoryTicketDto
    {
        public int Id { get; set; }

        public int SingleBedsQty { get; set; }

        public int HospitalBedsQty { get; set; }

        public int TrundleBedsQty { get; set; }

        public int ElasticSheetsQty { get; set; }

        public int SheetsQty { get; set; }

        public int PillowCasesQty { get; set; }

        public int PillowCoversQty { get; set; }

        public int PillowsQty { get; set; }

        public int QuiltsQty { get; set; }

        public int BlanketsQty { get; set; }

        public int NightstandQty { get; set; }

        public int DecorativePicturesQty { get; set; }

        public int BlackoutCurtainsQty { get; set; }

        public int DecorationsQty { get; set; }

        public int ClosetsQty { get; set; }

        public int SidewalkQty { get; set; }

        public int BathClothsQty { get; set; }

        public int HandClothsQty { get; set; }

        public int TubQty { get; set; }

        public int BabyTrolleyQty { get; set; }

        public int EnclosuresQty { get; set; }

        public int CradleQty { get; set; }

        public int ToiletKitQty { get; set; }

        public bool JourneyMade { get; set; }

        public bool keysDelivered { get; set; }

        public string Observations { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
