using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookingSystem.Flights.Dtos;
using BookingSystem.Dto;


namespace BookingSystem.Flights
{
    public interface IFlightsAppService : IApplicationService 
    {
        Task<PagedResultDto<GetFlightForViewDto>> GetAll(GetAllFlightsInput input);

        Task<GetFlightForViewDto> GetFlightForView(int id);

		Task<GetFlightForEditOutput> GetFlightForEdit(EntityDto input);

		Task CreateOrEdit(CreateOrEditFlightDto input);

		Task Delete(EntityDto input);

		Task<BookOrEditTicketDto> GetTicket(EntityDto input);

		Task BookOrEditTicket(BookOrEditTicketDto input);

		Task CancelTicket(EntityDto input);
		Task<PagedResultDto<GetBookedTicketForViewDto>> GetAllBookedTickets(GetAllBookedTicketsInput input);

		Task<PagedResultDto<FlightCityLookupTableDto>> GetAllCityForLookupTable(GetAllForLookupTableInput input);
		
		Task<PagedResultDto<FlightJetLookupTableDto>> GetAllJetForLookupTable(GetAllForLookupTableInput input);
	}
}