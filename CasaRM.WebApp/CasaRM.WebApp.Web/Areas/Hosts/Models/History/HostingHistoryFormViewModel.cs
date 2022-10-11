using System.ComponentModel.DataAnnotations;

namespace CasaRM.WebApp.Web.Areas.Hosts.Models.History
{
    public class HostingHistoryFormViewModel
    {
        public HostingHistoryFormViewModel()
        {
            EndDate = null;
        }

        public int Id { get; set; }

        public string HostId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        public string CreatedBy { get; set; }
    }
}
