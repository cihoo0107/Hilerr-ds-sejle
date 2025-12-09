using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Events
{
    public class OpretModel : PageModel
    {
        private IEventService _eventService;

        public OpretModel(IEventService eventservice)
        {
            _eventService = eventservice;
        }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _eventService.Add(new Event("Julefest", new DateTime(2025, 12, 22, 21, 0, 0)));


            return RedirectToPage("Index");
        }
    }
}