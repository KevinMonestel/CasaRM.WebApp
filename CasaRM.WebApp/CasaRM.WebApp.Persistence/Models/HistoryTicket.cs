using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("BoletasHistoriales")]
    public class HistoryTicket
    {
        [Key]
        public int Id { get; set; }

        [Column("CantidadCamasIndividuales")]
        public int SingleBedsQty { get; set; }

        [Column("CantidadCamasHospitalarias")]
        public int HospitalBedsQty { get; set; }

        [Column("CantidadCamasNido")]
        public int TrundleBedsQty { get; set; }

        [Column("CantidadSabanasElastico")]
        public int ElasticSheetsQty { get; set; }

        [Column("CantidadSabanas")]
        public int SheetsQty { get; set; }

        [Column("CantidadFundasAlmohadas")]
        public int PillowCasesQty { get; set; }

        [Column("CantidadCobertoresAlmohadas")]
        public int PillowCoversQty { get; set; }

        [Column("CantidadAlmohadas")]
        public int PillowsQty { get; set; }

        [Column("CantidadEdredones")]
        public int QuiltsQty { get; set; }

        [Column("CantidadCobijas")]
        public int BlanketsQty { get; set; }

        [Column("CantidadMesasDeNoche")]
        public int NightstandQty { get; set; }

        [Column("CantidadCuadrosDecorativos")]
        public int DecorativePicturesQty { get; set; }

        [Column("CantidadCortinasBlackOut")]
        public int BlackoutCurtainsQty { get; set; }

        [Column("CantidadDecoraciones")]
        public int DecorationsQty { get; set; }

        [Column("CantidadClosets")]
        public int ClosetsQty { get; set; }

        [Column("CantidadBanquetas")]
        public int SidewalkQty { get; set; }

        [Column("CantidadPannosBanno")]
        public int BathClothsQty { get; set; }

        [Column("CantidadPannosMano")]
        public int HandClothsQty { get; set; }

        [Column("CantidadTinas")]
        public int TubQty { get; set; }

        [Column("CantidadCoches")]
        public int BabyTrolleyQty { get; set; }

        [Column("CantidadEncierros")]
        public int EnclosuresQty { get; set; }

        [Column("CantidadCunas")]
        public int CradleQty { get; set; }

        [Column("CantidadKitsAseo")]
        public int ToiletKitQty { get; set; }

        [Column("RecorridoRelizado")]
        public bool JourneyMade { get; set; }

        [Column("LlavesEntregadas")]
        public bool keysDelivered { get; set; }

        [Column("Observaciones")]
        [StringLength(500)]
        public string Observations { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column("CreadoPor")]
        public string CreatedBy { get; set; }

        [Column("CreadoEn")]
        public DateTime CreatedAt { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
