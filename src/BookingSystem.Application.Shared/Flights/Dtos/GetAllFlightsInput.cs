using Abp.Application.Services.Dto;
using System;

namespace BookingSystem.Flights.Dtos
{
    public class GetAllFlightsInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }

		public DateTime? MaxDepartureDateFilter { get; set; }
		public DateTime? MinDepartureDateFilter { get; set; }

		public DateTime? MaxArrivalDateFilter { get; set; }
		public DateTime? MinArrivalDateFilter { get; set; }

		public int? MaxStatusFilter { get; set; }
		public int? MinStatusFilter { get; set; }


		 public string CityNameFilter { get; set; }

		 		 public string CityName2Filter { get; set; }

		 		 public string JetJetTypeFilter { get; set; }

		 
    }
}