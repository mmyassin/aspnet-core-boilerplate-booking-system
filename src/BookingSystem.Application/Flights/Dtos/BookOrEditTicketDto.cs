using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookingSystem.Flights.Dtos
{
    [AutoMapTo(typeof(BookedTicket))]
    [AutoMapFrom(typeof(BookedTicket))]
    public class BookOrEditTicketDto : EntityDto<int?>
    {
        public virtual int? FlightId { get; set; }
        public string TicketNumber { get; set; }
        public string PassengerFullName { get; set; }
        public TicketClass Class { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
        [MaxLength(14), MinLength(14)]
        public string CardNumber  { get; set; }
        [MaxLength(3), MinLength(3)]
        public string CVV { get; set; }
        public string Expiry { get; set; }
        public bool IsCanceled { get; set; }
    }
}
