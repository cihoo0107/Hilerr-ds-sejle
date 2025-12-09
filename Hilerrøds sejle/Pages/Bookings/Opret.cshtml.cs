using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Bookings
{
    public class OpretModel : PageModel
    {
        private IBookingService _bookingService;

        public OpretModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }


        public void OnGet()
        {
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _bookingService.Add(
                new Booking(
                    new Båd("Motorbåd", "X20", "4120", 10, 4, "2005", "Lambo"),
                    new Medlem("Niels", "Niels@mail.com", 001, Medlemsrolle.Formand)
                )
            );
 
            return RedirectToPage("Index");
        }
    }
}
