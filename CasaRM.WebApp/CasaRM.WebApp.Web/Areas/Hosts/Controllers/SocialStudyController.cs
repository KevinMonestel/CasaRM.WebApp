using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
using CasaRM.WebApp.Shared.Models.Catalog;
using CasaRM.WebApp.Shared.Models.SocialStudy;
using CasaRM.WebApp.Web.Areas.Hosts.Models.SocialStudy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CasaRM.WebApp.Web.Areas.Hosts.Controllers
{
    [Area("Hosts")]
    [Authorize]
    public class SocialStudyController : Controller
    {
        private readonly IHostService _hostService;
        private readonly ISocialStudyService _socialStudyService;

        public SocialStudyController(
            IHostService hostService,
            ISocialStudyService socialStudyService)
        {
            _hostService = hostService;
            _socialStudyService = socialStudyService;
        }

        public async Task<IActionResult> Manage(string host)
        {
            CreateOrUpdateSocialStudyViewModel viewModel = new();

            int socialStudyId = string.IsNullOrEmpty(host) ? 0 : await _hostService.GetSocialStudyIdByHostIdAsync(host);

            if (!string.IsNullOrEmpty(host) && socialStudyId > 0)
            {
                CreateOrUpdateSocialStudyDto fullSocialStudyData = await _socialStudyService.GetFullSocialStudyAsync(socialStudyId);

                viewModel.MinorPersonDataFormViewModel = fullSocialStudyData.MinorPersonDataDto.ToObject<MinorPersonDataFormViewModel>();
                viewModel.CompanionDataListViewModel = fullSocialStudyData.CompanionDataDto.ToObjectList<CompanionDataListViewModel>();
                viewModel.FamilyGroupListViewModel = fullSocialStudyData.FamilyGroupDto.ToObjectList<FamilyGroupListViewModel>();
                viewModel.ContributionListViewModel = fullSocialStudyData.ContributionDto.ToObjectList<ContributionListViewModel>();
                viewModel.IncomeCalculationFormViewModel = fullSocialStudyData.IncomeCalculationDto.ToObject<IncomeCalculationFormViewModel>();
                viewModel.HousingSituationFormViewModel = fullSocialStudyData.HousingSituationDto.ToObject<HousingSituationFormViewModel>();
                viewModel.SupportServicesFormViewModel = fullSocialStudyData.SupportServicesDto.ToObject<SupportServicesFormViewModel>();
                viewModel.RecomendationFormViewModel = fullSocialStudyData.RecomendationDto.ToObject<RecomendationFormViewModel>();
                viewModel.SignatureDataUrl = fullSocialStudyData.SignatureDataUrl;
                viewModel.SocialStudyId = socialStudyId;
                viewModel.HostId = host;
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<JsonResult> Save(CreateOrUpdateSocialStudyViewModel viewModel)
        {
            string redirectUrl = string.Empty;
            CreateOrUpdateSocialStudyDto createOrUpdateSocialStudyDto = new();

            createOrUpdateSocialStudyDto.HostId = viewModel.HostId;
            createOrUpdateSocialStudyDto.SocialStudyId = viewModel.SocialStudyId;
            createOrUpdateSocialStudyDto.ExecutedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            createOrUpdateSocialStudyDto.MinorPersonDataDto = viewModel.MinorPersonDataFormViewModel.ToObject<MinorPersonDataDto>();
            createOrUpdateSocialStudyDto.CompanionDataDto = viewModel.CompanionDataListViewModel.ToObjectList<CompanionDataDto>();
            createOrUpdateSocialStudyDto.FamilyGroupDto = viewModel.FamilyGroupListViewModel.ToObjectList<FamilyGroupDto>();
            createOrUpdateSocialStudyDto.ContributionDto = viewModel.ContributionListViewModel.ToObjectList<ContributionDto>();
            createOrUpdateSocialStudyDto.IncomeCalculationDto = viewModel.IncomeCalculationFormViewModel.ToObject<IncomeCalculationDto>();
            createOrUpdateSocialStudyDto.HousingSituationDto = viewModel.HousingSituationFormViewModel.ToObject<HousingSituationDto>();
            createOrUpdateSocialStudyDto.SupportServicesDto = viewModel.SupportServicesFormViewModel.ToObject<SupportServicesDto>();
            createOrUpdateSocialStudyDto.RecomendationDto = viewModel.RecomendationFormViewModel.ToObject<RecomendationDto>();

            if (!string.IsNullOrWhiteSpace(viewModel.SignatureDataUrl))
            {
                createOrUpdateSocialStudyDto.SignatureDataUrl = viewModel.SignatureDataUrl;
            }

            string result = await _socialStudyService.CreateOrUpdateSocialStudyAsync(createOrUpdateSocialStudyDto);

            if (!string.IsNullOrEmpty(result))
                redirectUrl = Url.Action("Index", "Home", new { host = result, wasManaged = true, area = "Hosts" });

            return new JsonResult(new
            {
                RedirectUrl = redirectUrl
            });
        }
    }
}
