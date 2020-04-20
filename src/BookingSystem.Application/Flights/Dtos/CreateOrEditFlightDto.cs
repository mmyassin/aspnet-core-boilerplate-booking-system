using BookingSystem.Flights;

using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace BookingSystem.Flights.Dtos
{
	[AutoMapTo(typeof(Flight))]
	[AutoMapFrom(typeof(Flight))]
	public class CreateOrEditFlightDto : EntityDto<int?>
    {

		[Required]
		public string FlightNumber { get; set; }
		
		
		public DateTime DepartureDate { get; set; }
		
		
		public DateTime? ArrivalDate { get; set; }
		
		
		public int EconomySeats { get; set; }
		
		
		public int BusinessSeats { get; set; }
		
		
		public decimal EconomyPrice { get; set; }
		
		
		public decimal BusinessPrice { get; set; }
		
		
		public FlightStatus Status { get; set; }
		
		
		 public int LocationOfDepartureId { get; set; }
		 
		 		 public int? LocationOfArrivalId { get; set; }
		 
		 		 public int? JetId { get; set; }
		 
		 
    }
}