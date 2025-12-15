using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;
namespace Hilerrøds_sejle.Pages.Medlemmer
{
    public class SletModel : PageModel
    {

        public Medlem MedlemToDelete { get; set; }

        private readonly IMedlemService _repo;

        public SletModel(IMedlemService repo)
        {
            _repo = repo;
        }

        public string? SuccessMessage { get; set; }

        public IActionResult OnGet(int id)

        {
            MedlemToDelete = _repo.GetById(id);
            if (MedlemToDelete == null) return NotFound();
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var existing = _repo.GetById(id);
            if (existing == null) return NotFound();

            
                _repo.Delete(id);

            SuccessMessage = "Medlem slettet" ;

                return RedirectToPage("Index");
            
        }
    }
}
