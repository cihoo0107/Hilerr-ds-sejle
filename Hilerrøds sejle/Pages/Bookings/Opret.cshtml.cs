using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Bookings
{
    public class OpretModel : PageModel
    {
        private readonly IBookingService _bookingService;
        private readonly IMedlemService _medlemService;

        public List<Medlem> Medlemmer { get; private set; } = new();

        [BindProperty]
        public int SelectedMedlemId { get; set; }

        public OpretModel(IBookingService bookingService, IMedlemService medlemService)
        {
            _bookingService = bookingService;
            _medlemService = medlemService;
        }

        public void OnGet()
        {
            Medlemmer = _medlemService.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var medlem = _medlemService.GetById(SelectedMedlemId);

            if (medlem == null)
            {
                ModelState.AddModelError("", "Medlem findes ikke.");
                return Page();
            }

            var båd = new Båd("Motorbåd", "X20", "4120", 10, 4, "2005", "Lambo");

            var booking = new Booking(båd, medlem);
            _bookingService.Add(booking);

            return RedirectToPage("Index");
        }
    }
}
