using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Extensions;
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
            ISocialStudyService socialStudyService
            )
        {
            _hostService = hostService;
            _socialStudyService = socialStudyService;
        }

        public async Task<IActionResult> Manage(string hostId)
        {
            CreateOrUpdateSocialStudyViewModel viewModel = new();

            int socialStudyId = await _hostService.GetSocialStudyIdByHostIdAsync(hostId);

            if (!string.IsNullOrEmpty(hostId) && socialStudyId > 0)
            {
                viewModel.SocialStudyId = socialStudyId;
                viewModel.HostId = hostId;
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<JsonResult> Save(CreateOrUpdateSocialStudyViewModel viewModel)
        {
            string redirectUrl = string.Empty;
            CreateOrUpdateSocialStudyDto ceateOrUpdateSocialStudyDto = new();

            ceateOrUpdateSocialStudyDto.HostId = viewModel.HostId;
            ceateOrUpdateSocialStudyDto.SocialStudyId = viewModel.SocialStudyId;
            ceateOrUpdateSocialStudyDto.ExecutedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            ceateOrUpdateSocialStudyDto.MinorPersonDataDto = viewModel.MinorPersonDataFormViewModel.ToObject<MinorPersonDataDto>();
            ceateOrUpdateSocialStudyDto.ParentDataDto = viewModel.ParentDataFormViewModel.ToObject<ParentDataDto>();
            ceateOrUpdateSocialStudyDto.CompanionDataDto = viewModel.CompanionDataFormViewModel.ToObject<CompanionDataDto>();

            string result = await _socialStudyService.CreateOrUpdateSocialStudyAsync(ceateOrUpdateSocialStudyDto);

            if (!string.IsNullOrEmpty(result))
                redirectUrl = Url.Action("Index", "Home", new { hostId = result, area = "Hosts" });

            return new JsonResult(new
            {
                RedirectUrl = redirectUrl
            });
        }
    }
}
