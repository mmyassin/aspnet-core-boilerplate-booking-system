using Abp.Application.Services.Dto;

namespace BookingSystem.Cities.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }
    }
}