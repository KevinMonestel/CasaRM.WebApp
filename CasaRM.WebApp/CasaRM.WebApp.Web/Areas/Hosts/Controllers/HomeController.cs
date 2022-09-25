using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CasaRM.WebApp.Web.Areas.Host.Controllers
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

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
