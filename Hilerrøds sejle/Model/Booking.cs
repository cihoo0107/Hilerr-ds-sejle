using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Model
{
    public class Booking
    {
        public Båd BookingBåd { get; }
        public Medlem BookingMedlem { get; }
        public string Id {get; }
        public string Destination {get; }

        public Booking(Båd bookingBåd, Medlem bookingMedlem)
        {
            BookingBåd = bookingBåd;
            BookingMedlem = bookingMedlem;
        }

        public Booking() { }
    }
}
