using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BookingSystem.Flights
{
    [Table("BookedTickets")]
    public class BookedTicket : Entity, ICreationAudited
    {

        [ForeignKey("FlightId")]
        public Flight FlightFk { get; set; }
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
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
