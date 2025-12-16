using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Bookings
{
    public class SletModel : PageModel
    {
        public Booking? BookingToDelete { get; set; }

        private readonly IBookingService _bookingService;

        public SletModel(IBookingService bookingService)
        {
             _bookingService = bookingService;
        }

        public IActionResult OnGet(string id)
        {
            BookingToDelete = _bookingService.GetById(id);
            if (BookingToDelete == null) return NotFound();
            return Page();
        }

        public IActionResult OnPost(string id)
        {
            var existing = _bookingService.GetById(id);
            if (existing == null) return NotFound();
                _bookingService.Delete(id);
                return RedirectToPage("Index");
        }
    }
}
