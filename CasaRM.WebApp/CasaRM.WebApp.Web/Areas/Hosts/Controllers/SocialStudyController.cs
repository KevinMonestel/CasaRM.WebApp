using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

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

        public async Task<IActionResult> Manage(string hostId)
        {
            CreateUpdateHostViewModel viewModel = new();

            int socialStudyId = await _hostService.GetSocialStudyIdByHostIdAsync(hostId);

            if (!string.IsNullOrEmpty(hostId) && socialStudyId > 0)
            {
                viewModel.SocialStudyId = socialStudyId;
                viewModel.HostId = hostId;
            }

            return View(viewModel);
        }

        public async Task<JsonResult> Save(CreateUpdateHostViewModel viewModel)
        {
            return new JsonResult(new 
            {
                RedirectUrl = ""
            });
        }
    }
}
