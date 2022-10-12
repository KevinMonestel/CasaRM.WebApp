namespace CasaRM.WebApp.Web.Areas.Hosts.Models.History
{
    public class HostingHistoryIndexViewModel
    {
        public HostingHistoryIndexViewModel()
        {
            HostingHistoryFormViewModel = new()
            {
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date
            };

            HostingHistoryListViewModel = Enumerable.Empty<HostingHistoryListViewModel>();
        }

        public bool WasManaged { get; set; }

        public HostingHistoryFormViewModel HostingHistoryFormViewModel { get; set; }

        public IEnumerable<HostingHistoryListViewModel> HostingHistoryListViewModel { get; set; }
    }
}
