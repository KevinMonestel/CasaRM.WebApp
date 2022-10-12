using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.History
{
    public class HistoryTicketFormViewModel
    {
        public int Id { get; set; }

        public int HostingHistoryId { get; set; }

        public string HostId { get; set; }

        public string ActionType { get; set; }

        [Required]
        public int SingleBedsQty { get; set; }

        [Required]
        public int HospitalBedsQty { get; set; }

        [Required]
        public int TrundleBedsQty { get; set; }

        [Required]
        public int ElasticSheetsQty { get; set; }

        [Required]
        public int SheetsQty { get; set; }

        [Required]
        public int PillowCasesQty { get; set; }

        [Required]
        public int PillowCoversQty { get; set; }

        [Required]
        public int PillowsQty { get; set; }

        [Required]
        public int QuiltsQty { get; set; }

        [Required]
        public int BlanketsQty { get; set; }

        [Required]
        public int NightstandQty { get; set; }

        [Required]
        public int DecorativePicturesQty { get; set; }

        [Required]
        public int BlackoutCurtainsQty { get; set; }

        [Required]
        public int DecorationsQty { get; set; }

        [Required]
        public int ClosetsQty { get; set; }

        [Required]
        public int SidewalkQty { get; set; }

        [Required]
        public int BathClothsQty { get; set; }

        [Required]
        public int HandClothsQty { get; set; }

        [Required]
        public int TubQty { get; set; }

        [Required]
        public int BabyTrolleyQty { get; set; }

        [Required]
        public int EnclosuresQty { get; set; }

        [Required]
        public int CradleQty { get; set; }

        [Required]
        public int ToiletKitQty { get; set; }

        [Required]
        public bool JourneyMade { get; set; }

        [Required]
        public bool keysDelivered { get; set; }

        [Required]
        [StringLength(500)]
        public string Observations { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
