using BookingSystem.Flights.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystem.Web.Models.Flights
{
    public class BookOrEditTicketViewModel: GetFlightForViewDto
    {
        public BookOrEditTicketDto Ticket { get; set; }

        public bool IsEditMode => Ticket.Id.HasValue;
    }
}
