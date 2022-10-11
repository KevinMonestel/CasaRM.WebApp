using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.Host;
using CasaRM.WebApp.Web.Areas.Hosts.Models.History;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CasaRM.WebApp.Web.Areas.Hosts.Controllers
{
    [Authorize]
    [Area("Hosts")]
    public class HistoryController : Controller
    {
        private readonly IHostingHistoryService _hostingHistoryService;

        public HistoryController(IHostingHistoryService hostingHistoryService)
        {
            _hostingHistoryService = hostingHistoryService;
        }

        public async Task<IActionResult> Index(string host)
        {
            HostingHistoryIndexViewModel viewModel = new();

            IEnumerable<HostingHistoryDto> hostingHistoryDtos = await _hostingHistoryService.GetByHostId(host);

            viewModel.HostingHistoryFormViewModel.HostId = host;
            viewModel.HostingHistoryListViewModel = hostingHistoryDtos.ToObjectList<HostingHistoryListViewModel>();

            return View(viewModel);
        }

        public async Task<IActionResult> Manage(int history)
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> AddHistory(HostingHistoryFormViewModel viewModel)
        {
            HostingHistoryListViewModel result = new();
            HostingHistoryDto hostingHistoryDto = viewModel.ToObject<HostingHistoryDto>();

            hostingHistoryDto.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            hostingHistoryDto = await _hostingHistoryService.CreateAsync(hostingHistoryDto);

            result = hostingHistoryDto.ToObject<HostingHistoryListViewModel>();

            return new JsonResult(new
            {
                RedirectUrl = Url.Action("Manage", "History", new { area = "Hosts", history = result.Id })
            });
        }

        [HttpPost]
        public async Task<HostingHistoryDto> RemoveHistory(HostingHistoryRemoveViewModel viewModel)
        {
            HostingHistoryDto result = await _hostingHistoryService.DeleteAsync(viewModel.Id);

            return result;
        }
    }
}
