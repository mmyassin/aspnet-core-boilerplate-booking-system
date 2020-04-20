using System;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using BookingSystem.Web.Models.Flights;
using BookingSystem.Controllers;
using BookingSystem.Authorization;
using BookingSystem.Flights;
using BookingSystem.Flights.Dtos;
using Abp.Application.Services.Dto;
using Abp.Extensions;

namespace BookingSystem.Web.Areas.App.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Flights)]
    public class FlightsController : BookingSystemControllerBase
    {
        private readonly IFlightsAppService _flightsAppService;

        public FlightsController(IFlightsAppService flightsAppService)
        {
            _flightsAppService = flightsAppService;
        }

        public ActionResult Index()
        {
            var model = new FlightsViewModel
			{
				FilterText = ""
			};

            return View(model);
        } 

        [AbpMvcAuthorize(AppPermissions.Pages_Flights_Create, AppPermissions.Pages_Flights_Edit)]
        public async Task<PartialViewResult> CreateOrEditModal(int? id)
        {
			GetFlightForEditOutput getFlightForEditOutput;

			if (id.HasValue){
				getFlightForEditOutput = await _flightsAppService.GetFlightForEdit(new EntityDto { Id = (int) id });
			}
			else {
				getFlightForEditOutput = new GetFlightForEditOutput{
					Flight = new CreateOrEditFlightDto()
				};
				getFlightForEditOutput.Flight.DepartureDate = DateTime.Now;
				getFlightForEditOutput.Flight.ArrivalDate = DateTime.Now;
			}

            var viewModel = new CreateOrEditFlightModalViewModel()
            {
				Flight = getFlightForEditOutput.Flight,
					CityName = getFlightForEditOutput.CityName,
					CityName2 = getFlightForEditOutput.CityName2,
					JetJetType = getFlightForEditOutput.JetJetType,                
            };

            return PartialView("_CreateOrEditModal", viewModel);
        }

        public async Task<PartialViewResult> ViewFlightModal(int id)
        {
			var getFlightForViewDto = await _flightsAppService.GetFlightForView(id);

            var model = new FlightViewModel()
            {
                Flight = getFlightForViewDto.Flight
                , CityName = getFlightForViewDto.CityName 

                , CityName2 = getFlightForViewDto.CityName2 

                , JetJetType = getFlightForViewDto.JetJetType 

            };

            return PartialView("_ViewFlightModal", model);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Flights_Create, AppPermissions.Pages_Flights_Edit)]
        public PartialViewResult CityLookupTableModal(int? id, string displayName)
        {
            var viewModel = new FlightCityLookupTableViewModel()
            {
                Id = id,
                DisplayName = displayName,
                FilterText = ""
            };

            return PartialView("_FlightCityLookupTableModal", viewModel);
        }
        [AbpMvcAuthorize(AppPermissions.Pages_Flights_Create, AppPermissions.Pages_Flights_Edit)]
        public PartialViewResult JetLookupTableModal(int? id, string displayName)
        {
            var viewModel = new FlightJetLookupTableViewModel()
            {
                Id = id,
                DisplayName = displayName,
                FilterText = ""
            };

            return PartialView("_FlightJetLookupTableModal", viewModel);
        }

    }
}