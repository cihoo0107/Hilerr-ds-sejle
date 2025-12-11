using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Bookings
{
public class OpretModel : PageModel
{
    private readonly IBookingService _bookingService;
    private readonly IMedlemRepository _medlemService;

    public List<Medlem> Medlemmer { get; private set; } = new();

    [BindProperty]
    public int SelectedMedlemId { get; set; }

    [BindProperty]
    public string Destination { get; set; }

    [BindProperty]
    public DateTime Tidspunkt { get; set; }

    [BindProperty]
    public bool ErGennemført { get; set; }

    public OpretModel(IBookingService bookingService, IMedlemRepository medlemService)
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

        // Static boat as requested
        var båd = new Båd("Motorbåd", "X20", "4120", 10, 4, "2005", "Lambo");

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
