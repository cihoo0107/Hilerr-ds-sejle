using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Events
{
    public class RedigerModel : PageModel
    {
        private readonly IEventService _eventService;
        
        [BindProperty]
        public Event EventToEdit { get; set; }
        public RedigerModel(IEventService eventService)
        {
            _eventService = eventService;
        }
        public IActionResult OnGet(string id)
        {
            EventToEdit = _eventService.GetAll().FirstOrDefault(e => e.Id == id);
            if (EventToEdit == null)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _eventService.Update(EventToEdit);
            return RedirectToPage("Index");
        }
    }
}
