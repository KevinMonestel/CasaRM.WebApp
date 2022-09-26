using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models;
using CasaRM.WebApp.Web.Areas.Hosts.Models;
using CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CasaRM.WebApp.Web.Areas.Hosts.Controllers
{
    [Area("Hosts")]
    [Authorize]
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index(string host, bool? wasManaged)
        {
            HostManagmentViewModel viewModel = new();

            viewModel.HostId = host;
            viewModel.WasManaged = wasManaged.GetValueOrDefault();

            return View(viewModel);
        }
    }
}
