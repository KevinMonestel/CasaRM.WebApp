using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models.Catalog;
using CasaRM.WebApp.Shared.Models.SocialStudy;
using System.Text;

namespace CasaRM.WebApp.Services.Implementations
{
    public class HostDocumentsService : IHostDocumentsService
    {
        private readonly ApplicationCatalog _applicationCatalog;
        private readonly ISocialStudyService _socialStudyService;
        private readonly IHostService _hostService;

        public HostDocumentsService(ApplicationCatalog applicationCatalog,
            ISocialStudyService socialStudyService,
            IHostService hostService)
        {
            _applicationCatalog = applicationCatalog;
            _socialStudyService = socialStudyService;
            _hostService = hostService;
        }

        public async Task<string> GetDocumentWithFormat(string hostId, int documentId)
        {
            CatalogDto docCatalog = _applicationCatalog.HostDocuments.FirstOrDefault(x => x.Id == documentId);
            int socialStudyId = await _hostService.GetSocialStudyIdByHostIdAsync(hostId);
            CreateOrUpdateSocialStudyDto fullSocialStudyInfo = await _socialStudyService.GetFullSocialStudyAsync(socialStudyId);

            if (docCatalog is null) return string.Empty;

            StringBuilder stringBuilder = new StringBuilder(docCatalog.Description);

            stringBuilder.Replace("{NombrePaciente}", fullSocialStudyInfo.MinorPersonDataDto.FullName);
            stringBuilder.Replace("{FirmaEncargado}", $"<img width='200' height='100' src='{fullSocialStudyInfo.SignatureDataUrl}'></img>");
            stringBuilder.Replace("{FechaCreacion}", DateTime.Now.ToString("dd/MM/yyyy"));
            stringBuilder.Replace("{NombreEncargado}", fullSocialStudyInfo.CompanionDataDto.FirstOrDefault(x => x.IsAPersonInCharge)?.FullName);
            stringBuilder.Replace("{IdentificacionEncargado}", fullSocialStudyInfo.CompanionDataDto.FirstOrDefault(x => x.IsAPersonInCharge)?.Identification);

            return stringBuilder.ToString();
        }
    }
}
