using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Model
{
    public class Booking
    {
        public string Id {get; }
        public Båd BookingBåd { get; }
        public Medlem BookingMedlem { get; }
        public string Destination {get; }
        public DateTime Tidspunkt { get; set; }
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
