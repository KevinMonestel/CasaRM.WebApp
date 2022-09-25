using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models;
using CasaRM.WebApp.Web.Areas.Hosts.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CasaRM.WebApp.Web.Areas.Hosts.Controllers
{
    [Area("Hosts")]
    [Authorize]
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index(string hostId)
        {
            return View();
        }
    }
}
