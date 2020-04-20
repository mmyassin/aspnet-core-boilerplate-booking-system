using System;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using BookingSystem.Web.Models.Cities;
using BookingSystem.Authorization;
using BookingSystem.Cities;
using BookingSystem.Cities.Dtos;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using BookingSystem.Controllers;

namespace BookingSystem.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Cities)]
    public class CitiesController : BookingSystemControllerBase
    {
        private readonly ICitiesAppService _citiesAppService;

        public CitiesController(ICitiesAppService citiesAppService)
        {
            _citiesAppService = citiesAppService;
        }

        public ActionResult Index()
        {
            var model = new CitiesViewModel
			{
				FilterText = ""
			};

            return View(model);
        } 

        [AbpMvcAuthorize(AppPermissions.Pages_Cities_Create, AppPermissions.Pages_Cities_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
			GetCityForEditOutput getCityForEditOutput;

			if (id.HasValue){
				getCityForEditOutput = await _citiesAppService.GetCityForEdit(new EntityDto { Id = (int) id });
			}
			else {
				getCityForEditOutput = new GetCityForEditOutput{
					City = new CreateOrEditCityDto()
				};
			}

            var viewModel = new CreateOrEditCityModalViewModel()
            {
				City = getCityForEditOutput.City,                
            };

            return PartialView("_CreateOrEditModal", viewModel);
        }

        public async Task<PartialViewResult> ViewCityModal(int id)
        {
			var getCityForViewDto = await _citiesAppService.GetCityForView(id);

            var model = new CityViewModel()
            {
                City = getCityForViewDto.City
            };

            return PartialView("_ViewCityModal", model);
        }


    }
}