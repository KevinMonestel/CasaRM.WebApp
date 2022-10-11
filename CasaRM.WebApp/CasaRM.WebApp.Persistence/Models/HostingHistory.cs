using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasaRM.WebApp.Persistence.Models
{
    [Table("HistorialesHospedajes")]
    public class HostingHistory
    {
        [Key]
        public int Id { get; set; }

        [Column("HuespedId")]
        [ForeignKey("Host")]
        public Guid HostId { get; set; }

        [Column("FechaEntrada")]
        public DateTime StartDate { get; set; }

        [Column("FechaSalida")]
        public DateTime? EndDate { get; set; }

        [Column("CreadoEn")]
        public DateTime CreatedAt { get; set; }

        [Column("NumeroHabitacion")]
        public int RoomNumber { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column("CreadoPor")]
        public string CreatedBy { get; set; }

        [ForeignKey("HistoryTicketDelivery")]
        [Column("BoletaHistorialEntregaId")]
        public int? HistoryTicketDeliveryId { get; set; }

        [ForeignKey("HistoryTicketReception")]
        [Column("BoletaHistorialRecibimientoId")]
        public int? HistoryTicketReceptionId { get; set; }

        public Host Host { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public HistoryTicket? HistoryTicketDelivery { get; set; }

        public HistoryTicket? HistoryTicketReception { get; set; }
    }
}
