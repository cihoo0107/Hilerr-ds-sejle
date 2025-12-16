using Hilerrøds_sejle.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Hilerrøds_sejle.Model
{
    public class Booking
    {
        public string Id {get; set;}
        [ValidateNever]
        public Båd BookingBåd { get; set;}
        [ValidateNever]
        public Medlem BookingMedlem { get; set;}
        public string Destination {get; set;}
        public DateTime Tidspunkt { get; set;}
        public bool ErGennemført {get; set;}

        public Booking(Båd bookingBåd, Medlem bookingMedlem, string destination, DateTime tidspunkt, bool erGennemført)
        {
            Id = Guid.NewGuid().ToString();
            BookingBåd = bookingBåd;
            BookingMedlem = bookingMedlem;
            Destination = destination;
            Tidspunkt = tidspunkt;
            ErGennemført = erGennemført;
        }

        public Booking() { }
    }
}
