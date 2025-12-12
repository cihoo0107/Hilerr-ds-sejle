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
        private readonly IBådservice _bådService;

        public List<Medlem> Medlemmer { get; private set; } = new();
        public List<Båd> Både { get; private set; } = new();

        [BindProperty]
        public int SelectedMedlemId { get; set; }

        [BindProperty]
        public int SelectedBådId { get; set; }

        [BindProperty]
        public string Destination { get; set; }

        [BindProperty]
        public DateTime Tidspunkt { get; set; }

        [BindProperty]
        public bool ErGennemført { get; set; }

        public OpretModel(
            IBookingService bookingService,
            IMedlemService medlemService,
            IBådservice bådService)
        {
            _bookingService = bookingService;
            _medlemService = medlemService;
            _bådService = bådService;
        }

        public void OnGet()
        {
            Medlemmer = _medlemService.GetAll();
            Både = _bådService.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var medlem = _medlemService.GetById(SelectedMedlemId);

            var båd = _bådService.GetById(SelectedBådId);

            if (medlem == null || båd == null)
            {
                ModelState.AddModelError("", "Medlem eller båd findes ikke.");
                Medlemmer = _medlemService.GetAll();
                Både = _bådService.GetAll();
                return Page();
            }

            var booking = new Booking(
                båd,
                medlem,
                Destination,
                Tidspunkt,
                ErGennemført
            );

            _bookingService.Add(booking);

            return RedirectToPage("Index");
        }
    }
}
