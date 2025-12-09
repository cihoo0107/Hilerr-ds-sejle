using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Events
{
    public class OpretModel : PageModel
    {
        private IEventService _eventservice;
        public Event NewEvent { get; set; }

        public OpretModel(IEventService eventservice)
        {
            _eventservice = eventservice;
        }

        [BindProperty]
        public Event NytEvent { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _eventservice.Add(NytEvent);
            return RedirectToPage("Index");
        }
    }
}