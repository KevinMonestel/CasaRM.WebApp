using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.History;
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

        public async Task<IActionResult> Index(string host, bool wasManaged = false)
        {
            HostingHistoryIndexViewModel viewModel = new();

            IEnumerable<HostingHistoryDto> hostingHistoryDtos = await _hostingHistoryService.GetByHostId(host);

            viewModel.HostingHistoryFormViewModel.HostId = host;
            viewModel.HostingHistoryListViewModel = hostingHistoryDtos.ToObjectList<HostingHistoryListViewModel>();

            viewModel.WasManaged = wasManaged;

            return View(viewModel);
        }

        public async Task<IActionResult> Manage(int history, string host)
        {
            HostingHistoryManageViewModel viewModel = new();

            GetHistoryTicketsIdsResult getHistoryTicketsIds = await _hostingHistoryService.GetHistoryTicketsIdsByHistoryIdAsync(history);

            viewModel.HistoryTicketReception = getHistoryTicketsIds.HistoryTicketReceptionId.HasValue ?
                (await _hostingHistoryService.GetHistoryTicketByIdAsync(getHistoryTicketsIds.HistoryTicketReceptionId.Value)).ToObject<HistoryTicketFormViewModel>() : new();

            viewModel.HistoryTicketDelivery = getHistoryTicketsIds.HistoryTicketDeliveryId.HasValue ?
                (await _hostingHistoryService.GetHistoryTicketByIdAsync(getHistoryTicketsIds.HistoryTicketDeliveryId.Value)).ToObject<HistoryTicketFormViewModel>() : new();

            viewModel.HistoryTicketDelivery.HostId = host;
            viewModel.HistoryTicketReception.HostId = host;
            viewModel.HistoryTicketDelivery.HostingHistoryId = history;
            viewModel.HistoryTicketReception.HostingHistoryId = history;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrUpdateHistoryTicket(HistoryTicketFormViewModel viewModel)
        {
            HistoryTicketDto historyTicketDto = viewModel.ToObject<HistoryTicketDto>();

            historyTicketDto.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            HistoryTicketDto result = await _hostingHistoryService.CreateOrUpdateHistoryTicket(historyTicketDto, viewModel.HostingHistoryId, viewModel.ActionType);

            return RedirectToAction("Index", new { host = viewModel.HostId, wasManaged = true });
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
                RedirectUrl = Url.Action("Manage", "History", new { area = "Hosts", history = result.Id, host = result.HostId })
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
