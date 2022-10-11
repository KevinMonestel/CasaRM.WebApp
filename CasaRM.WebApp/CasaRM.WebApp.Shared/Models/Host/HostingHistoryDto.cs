namespace CasaRM.WebApp.Shared.Models.Host
{
    public class HostingHistoryDto
    {
        public int Id { get; set; }

        public string HostId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public int RoomNumber { get; set; }

        public string CreatedBy { get; set; }
    }
}
