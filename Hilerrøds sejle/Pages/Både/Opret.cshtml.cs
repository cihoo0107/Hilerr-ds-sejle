using Hilerrøds_sejle.Service;
using Microsoft.AspNetCore.Mvc;
using Hilerrøds_sejle.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hilerrøds_sejle.Pages.Både
{
    public class OpretModel : PageModel
    {
        private IBådservice _bådeservice;
        public Båd NewBåd { get; set; }

        public OpretModel(IBådservice bådservice)
        {
            _bådeservice = bådservice;
        }

        [BindProperty]
        public Båd NytBåd { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _bådeservice.Add(NytBåd);
            return RedirectToPage("index");
        }
    }
}
