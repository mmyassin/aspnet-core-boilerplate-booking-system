using Abp.Application.Services.Dto;

namespace BookingSystem.Flights.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }
    }
}