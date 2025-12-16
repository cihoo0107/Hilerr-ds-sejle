    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Hilerrøds_sejle.Model;
    using Hilerrøds_sejle.Service;

    namespace Hilerrøds_sejle.Pages.Medlemmer
    {
        public class OpretModel : PageModel
        {
            private readonly IMedlemService _repo;

            public OpretModel(IMedlemService repo)
            {
                _repo = repo;
                NyMedlem = new Medlem(); // vigtigt til form-binding
            }

            [BindProperty]
            public Medlem NyMedlem { get; set; }

            public void OnGet()
            {
            }

        [TempData]
        public string? SuccessMessage { get; set; }


        public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _repo.Add(NyMedlem);

            SuccessMessage = "Medlem oprettet.";

                return RedirectToPage("Index");
            }
        }
    }
