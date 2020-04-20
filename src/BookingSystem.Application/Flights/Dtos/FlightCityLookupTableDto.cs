using Abp.Application.Services.Dto;

namespace BookingSystem.Flights.Dtos
{
    public class FlightCityLookupTableDto
    {
		public int Id { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }
    }
}