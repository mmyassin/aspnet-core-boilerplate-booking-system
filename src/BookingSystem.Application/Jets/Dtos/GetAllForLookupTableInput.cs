using Abp.Application.Services.Dto;

namespace BookingSystem.Jets.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }
    }
}