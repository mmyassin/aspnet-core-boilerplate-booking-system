using Abp.Application.Services.Dto;
using System;

namespace BookingSystem.Flights.Dtos
{
    public class GetAllFlightsInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }

		public DateTime? DepartureDateFilter { get; set; }

		public DateTime? ArrivalDateFilter { get; set; }

		public int StatusFilter { get; set; }


		 public string CityNameFilter { get; set; }

		 		 public string CityName2Filter { get; set; }

		 		 public string JetJetTypeFilter { get; set; }

		 
    }
}