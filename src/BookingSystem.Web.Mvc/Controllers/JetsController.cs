using System;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using BookingSystem.Web.Models.Jets;
using BookingSystem.Web.Controllers;
using BookingSystem.Authorization;
using BookingSystem.Jets;
using BookingSystem.Jets.Dtos;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using BookingSystem.Controllers;

namespace BookingSystem.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Jets)]
    public class JetsController : BookingSystemControllerBase
    {
        private readonly IJetsAppService _jetsAppService;

        public JetsController(IJetsAppService jetsAppService)
        {
            _jetsAppService = jetsAppService;
        }

        public ActionResult Index()
        {
            var model = new JetsViewModel
			{
				FilterText = ""
			};

            return View(model);
        } 

        [AbpMvcAuthorize(AppPermissions.Pages_Jets_Create, AppPermissions.Pages_Jets_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
			GetJetForEditOutput getJetForEditOutput;

			if (id.HasValue){
				getJetForEditOutput = await _jetsAppService.GetJetForEdit(new EntityDto { Id = (int) id });
			}
			else {
				getJetForEditOutput = new GetJetForEditOutput{
					Jet = new CreateOrEditJetDto()
				};
			}

            var viewModel = new CreateOrEditJetModalViewModel()
            {
				Jet = getJetForEditOutput.Jet,                
            };

            return PartialView("_CreateOrEditModal", viewModel);
        }

        public async Task<PartialViewResult> ViewJetModal(int id)
        {
			var getJetForViewDto = await _jetsAppService.GetJetForView(id);

            var model = new JetViewModel()
            {
                Jet = getJetForViewDto.Jet
            };

            return PartialView("_ViewJetModal", model);
        }


    }
}