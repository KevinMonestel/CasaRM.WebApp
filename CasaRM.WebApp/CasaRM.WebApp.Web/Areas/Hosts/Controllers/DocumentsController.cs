using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models.Catalog;
using CasaRM.WebApp.Web.Areas.Hosts.Models.Documents;
using Microsoft.AspNetCore.Mvc;

namespace CasaRM.WebApp.Web.Areas.Hosts.Controllers
{
    [Area("Hosts")]
    public class DocumentsController : Controller
    {
        private readonly IHostDocumentsService _hostDocumentsService;

        public DocumentsController(IHostDocumentsService hostDocumentsService)
        {
            _hostDocumentsService = hostDocumentsService;
        }

        public async Task<IActionResult> Index(string host, int document)
        {
            DocumentIndexViewModel viewModel = new();

            string documentHtml = await _hostDocumentsService.GetDocumentWithFormat(host, document);

            viewModel.DocumentHtml = documentHtml;

            return View(viewModel);
        }
    }
}
