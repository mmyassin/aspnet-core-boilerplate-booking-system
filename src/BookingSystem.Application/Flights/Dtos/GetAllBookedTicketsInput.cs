using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingSystem.Flights.Dtos
{
    public class GetAllBookedTicketsInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
        public int UserId { get; set; }
    }
}
