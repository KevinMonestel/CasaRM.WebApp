using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models;
using CasaRM.WebApp.Shared.Models.Host;
using CasaRM.WebApp.Web.Areas.Hosts.Models;
using CasaRM.WebApp.Web.Areas.Hosts.Models.Home;
using CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace CasaRM.WebApp.Web.Areas.Hosts.Controllers
{
    [Area("Hosts")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHostService _hostService;

        public HomeController(IHostService hostService)
        {
            _hostService = hostService;
        }

        public async Task<IActionResult> Index(string host, bool? wasManaged)
        {
            HostManagmentViewModel viewModel = new();

            viewModel.HostId = host;
            viewModel.WasManaged = wasManaged.GetValueOrDefault();

            return View(viewModel);
        }

        public async Task<IActionResult> Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IEnumerable<SearchHostResultsViewModel>> Search(SearchHostFormViewModel viewModel)
        {
            IEnumerable<SearchHostResultsViewModel> finds;
            SearchHostDto searchHostDto = viewModel.ToObject<SearchHostDto>();

            IEnumerable<SearchHostResultsDto> results = await _hostService.SearchHostsAsync(searchHostDto);

            finds = results.ToObjectList<SearchHostResultsViewModel>();

            foreach (SearchHostResultsViewModel find in finds)
                find.ManageUrl = Url.Action("Index", "Home", new { host = find.Code, area = "Hosts" });

            return finds;
        }
    }
}
