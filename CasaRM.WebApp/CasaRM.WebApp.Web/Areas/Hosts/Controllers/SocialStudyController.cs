using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy;
using Microsoft.AspNetCore.Mvc;

namespace CasaRM.WebApp.Web.Areas.Hosts.Controllers
{
    [Area("Hosts")]
    public class SocialStudyController : Controller
    {
        private readonly IHostService _hostService;

        public SocialStudyController(IHostService hostService)
        {
            _hostService = hostService;
        }

        public IActionResult Manage(string hostId)
        {
            CreateUpdateHostViewModel viewModel = new();

            if (string.IsNullOrEmpty(hostId))
            {

            }

            return View(viewModel);
        }
    }
}
