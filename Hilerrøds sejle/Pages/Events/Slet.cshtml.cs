using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Events
{
    public class SletModel : PageModel
    {
        private readonly IEventService _eventService;

        [BindProperty]
        public Event EventToDelete { get; set; }

        public SletModel(IEventService eventService)
        {
            _eventService = eventService;
        }

        public IActionResult OnGet(string id)
        {
            EventToDelete = _eventService.GetAll().FirstOrDefault(e => e.Id == id);
            if (EventToDelete == null)
            {
                return RedirectToPage("/Events/Index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            _eventService.DeleteById(EventToDelete.Id);
            return RedirectToPage("/Events/Index");
        }
    }
}