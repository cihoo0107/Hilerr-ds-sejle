using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Service;

public class BookingService : IBookingService
{
    private List<Booking> _Bookings = new List<Booking>()
    {
        new Booking(
            new Båd("Motorbåd","X20","4120",10,4,"2005","Lambo"),
            new Medlem("Niels", "Niels@mail.com", 001, Medlemsrolle.Formand, "10203040", "Købmandsgade 12"),
            "Hillerød Sø",
            DateTime.Now.AddHours(1),
            false
        ),

        new Booking(
            new Båd("Motorbåd","X20","4120",10,4,"2005","Lambo"),
            new Medlem("Niels", "Niels@mail.com", 001, Medlemsrolle.Formand, "10203040", "Købmandsgade 12"),
            "Frederiksborg Slot",
            DateTime.Now.AddHours(2),
            false
        ),
    };

    public List<Booking> GetAll() => _Bookings;

    public void Add(Booking booking)
    {
        _Bookings.Add(booking);
    }
}
