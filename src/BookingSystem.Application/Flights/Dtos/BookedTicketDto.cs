using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingSystem.Flights.Dtos
{
    [AutoMapFrom(typeof(BookedTicket))]
    public class BookedTicketDto : EntityDto
    {
        public virtual int? FlightId { get; set; }
        public string TicketNumber { get; set; }
        public string PassengerFullName { get; set; }
        public TicketClass Class { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string Expiry { get; set; }
        public bool IsCanceled { get; set; }
    }
}
