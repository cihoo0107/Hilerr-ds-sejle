using Hilerrøds_sejle.Service;
using Microsoft.AspNetCore.Mvc;
using Hilerrøds_sejle.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hilerrøds_sejle.Pages.Både
{
    public class SletModel : PageModel
    {
        private readonly IBådservice _bådservice;

        [BindProperty]
        public Båd BådToDelete { get; set; }

        public SletModel(IBådservice bådservice)
        {
            _bådservice = bådservice;
        }

        public IActionResult OnGet(int id)
        {
            BådToDelete = _bådservice.GetAll().FirstOrDefault(b => b.Id == id);
            if (BådToDelete == null)
            {
                return RedirectToPage("/Både/Index");
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            var existing = _bådservice.GetById(id);
            if (existing == null) return NotFound();


            _bådservice.DeleteById(id);

            return RedirectToPage("Index");
        }

    }
}
