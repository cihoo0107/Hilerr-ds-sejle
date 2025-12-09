using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Service;
using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private IBookingService _bookingService;
        public List<Booking> Bookings { get; private set; }

        public IndexModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
            Bookings = new List<Booking>();
        }

        public void OnGet()
        {
            Bookings = _bookingService.GetAll();
       }
    }
}
