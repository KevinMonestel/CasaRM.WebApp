using CasaRM.WebApp.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CasaRM.WebApp.Web.Areas.Reports.Controllers
{
    [Area("Reports")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IReportsService _reportsService;

        public HomeController(IReportsService reportsService)
        {
            _reportsService = reportsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Demo()
        {
            return File(await _reportsService.GenerateDemoReport(), "application/octet-stream", "Demo.xlsx");
        }
    }
}
