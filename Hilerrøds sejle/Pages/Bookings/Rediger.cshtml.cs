using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Bookings
{
    public class RedigerModel : PageModel
    {
        [BindProperty] 
        public Booking? BookingToEdit {get; set;}

        public IBookingService _bookingService {get; set;}
        public IBådservice _bådService {get; set;}
        public IMedlemService _medlemService {get; set;}

        public List<Medlem> Medlemmer { get; private set; } = new();
        public List<Båd> Både { get; private set; } = new();

        [BindProperty]
        public int SelectedMedlemId { get; set; }

        [BindProperty]
        public int SelectedBådId { get; set; }

        public RedigerModel (IBookingService bookingService, IBådservice bådService, IMedlemService medlemService) {
            _bookingService = bookingService;
            _bådService = bådService;
            _medlemService = medlemService;
        }

        public IActionResult OnGet(string id)
        {
            Medlemmer = _medlemService.GetAll();
            Både = _bådService.GetAll();
 
            BookingToEdit = _bookingService.GetById(id);
            if (BookingToEdit == null) {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost() {
            Booking? current = _bookingService.GetById(BookingToEdit.Id);
            if (current == null) {
                return NotFound();
            }

            var medlem = _medlemService.GetById(SelectedMedlemId);

            var båd = _bådService.GetById(SelectedBådId);

            if (medlem == null || båd == null)
            {
                ModelState.AddModelError("", "Medlem eller båd findes ikke.");
                Medlemmer = _medlemService.GetAll();
                Både = _bådService.GetAll();
                return Page();
            }

            BookingToEdit.BookingBåd = båd;
            BookingToEdit.BookingMedlem = medlem;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _bookingService.Delete(current.Id);
            _bookingService.Add(BookingToEdit);

            return RedirectToPage("Index");
        }
    }
}
