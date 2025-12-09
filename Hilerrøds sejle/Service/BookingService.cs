using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Service;

public class BookingService : IBookingService
{
    private List<Booking> _Bookings = new List<Booking>()
    { new Booking(
        new Båd("Motorbåd","X20","4120",10,4,"2005","Lambo"),
        new Medlem("Niels", "Niels@mail.com",001,Medlemsrolle.Formand)
        ),

        new Booking(
        new Båd("Motorbåd","X20","4120",10,4,"2005","Lambo"),
        new Medlem("Niels", "Niels@mail.com",001,Medlemsrolle.Formand)
        ),
    
            
    };

    public List<Booking> GetAll()
    {
        return _Bookings;
    }

    public void Add (Booking booking) {
        _Bookings.Add(booking);
    }
}
