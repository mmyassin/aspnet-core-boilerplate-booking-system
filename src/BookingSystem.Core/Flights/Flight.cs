using BookingSystem.Cities;
using BookingSystem.Jets;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System.Collections.Generic;

namespace BookingSystem.Flights
{
	[Table("Flights")]
    public class Flight : FullAuditedEntity , IMustHaveTenant
    {
		public int TenantId { get; set; }
			
		[Required]
		public virtual string FlightNumber { get; set; }
		
		public virtual DateTime DepartureDate { get; set; }
		
		public virtual DateTime? ArrivalDate { get; set; }
		
		public virtual int EconomySeats { get; set; }
		
		public virtual int BusinessSeats { get; set; }
		
		public virtual decimal EconomyPrice { get; set; }
		
		public virtual decimal BusinessPrice { get; set; }
		
		public virtual FlightStatus Status { get; set; }
		

		public virtual int LocationOfDepartureId { get; set; }
		
        [ForeignKey("LocationOfDepartureId")]
		public City LocationOfDepartureFk { get; set; }
		
		public virtual int? LocationOfArrivalId { get; set; }
		
        [ForeignKey("LocationOfArrivalId")]
		public City LocationOfArrivalFk { get; set; }
		
		public virtual int? JetId { get; set; }
		
        [ForeignKey("JetId")]
		public Jet JetFk { get; set; }

		public virtual ICollection<BookedTicket> BookedTickets { get; set; }

	}
}