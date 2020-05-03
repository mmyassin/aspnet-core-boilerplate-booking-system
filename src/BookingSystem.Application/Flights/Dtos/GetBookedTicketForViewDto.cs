using System;
using System.Collections.Generic;
using System.Text;

namespace BookingSystem.Flights.Dtos
{
    public class GetBookedTicketForViewDto : GetFlightForViewDto
    {
        public BookedTicketDto Ticket { get; set; }
    }
}
