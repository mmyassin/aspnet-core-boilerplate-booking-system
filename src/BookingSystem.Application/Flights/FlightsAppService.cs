using BookingSystem.Cities;
using BookingSystem.Jets;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using BookingSystem.Flights.Dtos;
using Abp.Application.Services.Dto;
using BookingSystem.Authorization;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Flights
{
    [AbpAuthorize(AppPermissions.Pages_Flights)]
    public class FlightsAppService : BookingSystemAppServiceBase, IFlightsAppService
    {
		 private readonly IRepository<Flight> _flightRepository;
		 private readonly IRepository<City,int> _lookup_cityRepository;
		 private readonly IRepository<Jet,int> _lookup_jetRepository;
		 

		  public FlightsAppService(IRepository<Flight> flightRepository , IRepository<City, int> lookup_cityRepository, IRepository<Jet, int> lookup_jetRepository) 
		  {
			_flightRepository = flightRepository;
			_lookup_cityRepository = lookup_cityRepository;
		_lookup_jetRepository = lookup_jetRepository;
		
		  }

		 public async Task<PagedResultDto<GetFlightForViewDto>> GetAll(GetAllFlightsInput input)
         {
			var statusFilter = (FlightStatus) input.StatusFilter;
			
			var filteredFlights = _flightRepository.GetAll()
						.Include( e => e.LocationOfDepartureFk)
						.Include( e => e.LocationOfArrivalFk)
						.Include( e => e.JetFk)
						.WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false  || e.FlightNumber.Contains(input.Filter))
						.WhereIf(input.DepartureDateFilter != null, e => e.DepartureDate >= input.DepartureDateFilter)
						.WhereIf(input.ArrivalDateFilter != null, e => e.ArrivalDate <= input.ArrivalDateFilter)
						.WhereIf(input.StatusFilter > -1, e => e.Status == statusFilter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.CityNameFilter), e => e.LocationOfDepartureFk != null && e.LocationOfDepartureFk.Name == input.CityNameFilter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.CityName2Filter), e => e.LocationOfArrivalFk != null && e.LocationOfArrivalFk.Name == input.CityName2Filter)
						.WhereIf(!string.IsNullOrWhiteSpace(input.JetJetTypeFilter), e => e.JetFk != null && e.JetFk.JetType == input.JetJetTypeFilter);

			var pagedAndFilteredFlights = filteredFlights
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

			var flights = from o in pagedAndFilteredFlights
                         join o1 in _lookup_cityRepository.GetAll() on o.LocationOfDepartureId equals o1.Id into j1
                         from s1 in j1.DefaultIfEmpty()
                         
                         join o2 in _lookup_cityRepository.GetAll() on o.LocationOfArrivalId equals o2.Id into j2
                         from s2 in j2.DefaultIfEmpty()
                         
                         join o3 in _lookup_jetRepository.GetAll() on o.JetId equals o3.Id into j3
                         from s3 in j3.DefaultIfEmpty()
                         
                         select new GetFlightForViewDto() {
							Flight = new FlightDto
							{
                                FlightNumber = o.FlightNumber,
                                DepartureDate = o.DepartureDate,
                                ArrivalDate = o.ArrivalDate,
                                EconomySeats = o.EconomySeats,
                                BusinessSeats = o.BusinessSeats,
                                EconomyPrice = o.EconomyPrice,
                                BusinessPrice = o.BusinessPrice,
                                Status = o.Status,
                                Id = o.Id
							},
                         	CityName = s1 == null ? "" : s1.DisplayName.ToString() + ", " + s1.Code ,
                         	CityName2 = s2 == null ? "" : s2.DisplayName.ToString() + ", " + s2.Code,
                         	JetJetType = s3 == null ? "" : s3.JetType.ToString()
						};

            var totalCount = await filteredFlights.CountAsync();

            return new PagedResultDto<GetFlightForViewDto>(
                totalCount,
                await flights.ToListAsync()
            );
         }
		 
		 public async Task<GetFlightForViewDto> GetFlightForView(int id)
         {
            var flight = await _flightRepository.GetAsync(id);

            var output = new GetFlightForViewDto { Flight = ObjectMapper.Map<FlightDto>(flight) };

		    if (output.Flight.LocationOfDepartureId != null)
            {
                var _lookupCity = await _lookup_cityRepository.FirstOrDefaultAsync((int)output.Flight.LocationOfDepartureId);
                output.CityName = _lookupCity.Name.ToString();
            }

		    if (output.Flight.LocationOfArrivalId != null)
            {
                var _lookupCity = await _lookup_cityRepository.FirstOrDefaultAsync((int)output.Flight.LocationOfArrivalId);
                output.CityName2 = _lookupCity.Name.ToString();
            }

		    if (output.Flight.JetId != null)
            {
                var _lookupJet = await _lookup_jetRepository.FirstOrDefaultAsync((int)output.Flight.JetId);
                output.JetJetType = _lookupJet.JetType.ToString();
            }
			
            return output;
         }
		 
		 [AbpAuthorize(AppPermissions.Pages_Flights_Edit)]
		 public async Task<GetFlightForEditOutput> GetFlightForEdit(EntityDto input)
         {
            var flight = await _flightRepository.FirstOrDefaultAsync(input.Id);
           
		    var output = new GetFlightForEditOutput {Flight = ObjectMapper.Map<CreateOrEditFlightDto>(flight)};

		    if (output.Flight.LocationOfDepartureId != null)
            {
                var _lookupCity = await _lookup_cityRepository.FirstOrDefaultAsync((int)output.Flight.LocationOfDepartureId);
                output.CityName = _lookupCity.Name.ToString();
            }

		    if (output.Flight.LocationOfArrivalId != null)
            {
                var _lookupCity = await _lookup_cityRepository.FirstOrDefaultAsync((int)output.Flight.LocationOfArrivalId);
                output.CityName2 = _lookupCity.Name.ToString();
            }

		    if (output.Flight.JetId != null)
            {
                var _lookupJet = await _lookup_jetRepository.FirstOrDefaultAsync((int)output.Flight.JetId);
                output.JetJetType = _lookupJet.JetType.ToString();
            }
			
            return output;
         }

		 public async Task CreateOrEdit(CreateOrEditFlightDto input)
         {
            if(input.Id == null){
				await Create(input);
			}
			else{
				await Update(input);
			}
         }

		 [AbpAuthorize(AppPermissions.Pages_Flights_Create)]
		 protected virtual async Task Create(CreateOrEditFlightDto input)
         {
            var flight = ObjectMapper.Map<Flight>(input);

			
			if (AbpSession.TenantId != null)
			{
				flight.TenantId = (int) AbpSession.TenantId;
			}
		

            await _flightRepository.InsertAsync(flight);
         }

		 [AbpAuthorize(AppPermissions.Pages_Flights_Edit)]
		 protected virtual async Task Update(CreateOrEditFlightDto input)
         {
            var flight = await _flightRepository.FirstOrDefaultAsync((int)input.Id);
             ObjectMapper.Map(input, flight);
         }

		 [AbpAuthorize(AppPermissions.Pages_Flights_Delete)]
         public async Task Delete(EntityDto input)
         {
            await _flightRepository.DeleteAsync(input.Id);
         } 

		[AbpAuthorize(AppPermissions.Pages_Flights)]
         public async Task<PagedResultDto<FlightCityLookupTableDto>> GetAllCityForLookupTable(GetAllForLookupTableInput input)
         {
             var query = _lookup_cityRepository.GetAll().WhereIf(
                    !string.IsNullOrWhiteSpace(input.Filter),
                   e=> e.Name != null && e.Name.Contains(input.Filter)
                );

            var totalCount = await query.CountAsync();

            var cityList = await query
                .PageBy(input)
                .ToListAsync();

			var lookupTableDtoList = new List<FlightCityLookupTableDto>();
			foreach(var city in cityList){
				lookupTableDtoList.Add(new FlightCityLookupTableDto
				{
					Id = city.Id,
                    Code = city.Code,
					DisplayName = city.Name?.ToString()
				});
			}

            return new PagedResultDto<FlightCityLookupTableDto>(
                totalCount,
                lookupTableDtoList
            );
         }

		[AbpAuthorize(AppPermissions.Pages_Flights)]
         public async Task<PagedResultDto<FlightJetLookupTableDto>> GetAllJetForLookupTable(GetAllForLookupTableInput input)
         {
             var query = _lookup_jetRepository.GetAll().WhereIf(
                    !string.IsNullOrWhiteSpace(input.Filter),
                   e=> e.JetType != null && e.JetType.Contains(input.Filter)
                );

            var totalCount = await query.CountAsync();

            var jetList = await query
                .PageBy(input)
                .ToListAsync();

			var lookupTableDtoList = new List<FlightJetLookupTableDto>();
			foreach(var jet in jetList){
				lookupTableDtoList.Add(new FlightJetLookupTableDto
				{
					Id = jet.Id,
					DisplayName = jet.JetType?.ToString()
				});
			}

            return new PagedResultDto<FlightJetLookupTableDto>(
                totalCount,
                lookupTableDtoList
            );
         }
    }
}