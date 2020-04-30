namespace BookingSystem.Flights.Dtos
{
    public class GetFlightForViewDto
    {
		public FlightDto Flight { get; set; }

		public string CityName { get; set;}

		public string CityName2 { get; set;}

		public string JetJetType { get; set;}

		public int BusinessAvailableTickets { get; set; }
		public int EconomyAvailableTickets { get; set; }


	}
}