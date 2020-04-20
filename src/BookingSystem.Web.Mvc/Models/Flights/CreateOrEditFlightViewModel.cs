using BookingSystem.Flights.Dtos;

using Abp.Extensions;

namespace BookingSystem.Web.Models.Flights
{
    public class CreateOrEditFlightModalViewModel
    {
       public CreateOrEditFlightDto Flight { get; set; }

	   		public string CityName { get; set;}

		public string CityName2 { get; set;}

		public string JetJetType { get; set;}


       
	   public bool IsEditMode => Flight.Id.HasValue;
    }
}