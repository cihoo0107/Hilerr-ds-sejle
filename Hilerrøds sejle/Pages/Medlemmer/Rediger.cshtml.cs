using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hilerrøds_sejle.Pages.Medlemmer
{
    public class RedigerModel : PageModel
    {

        private readonly IMedlemService _repo;

        public RedigerModel(IMedlemService repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public Medlem MedlemToEdit { get; set; }

        [TempData]
        public string? SuccessMessage { get; set; }

        public IActionResult OnGet(int id)
        {
            MedlemToEdit = _repo.GetById(id);
            if (MedlemToEdit == null) return NotFound();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)

            {
                return Page();
            }

            var existing = _repo.GetById(MedlemToEdit.Id);

            if (existing == null) return NotFound();

            existing.Navn = MedlemToEdit.Navn;  
            existing.Email = MedlemToEdit.Email;
            existing.Rolle = MedlemToEdit.Rolle;
            existing.Adresse = MedlemToEdit.Adresse;
            existing.Telefonnummer = MedlemToEdit.Telefonnummer;

            _repo.Update(existing);

            SuccessMessage = "Medlem opdateret.";


            return RedirectToPage("Index");
        }
    }
}
