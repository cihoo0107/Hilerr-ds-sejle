    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Hilerrøds_sejle.Model;
    using Hilerrøds_sejle.Service;

    namespace Hilerrøds_sejle.Pages.Medlemmer
    {
        public class OpretModel : PageModel
        {
            private readonly IMedlemRepository _repo;

            public OpretModel(IMedlemRepository repo)
            {
                _repo = repo;
                NyMedlem = new Medlem(); // vigtigt til form-binding
            }

            [BindProperty]
            public Medlem NyMedlem { get; set; }

            public void OnGet()
            {
            }

            public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _repo.Add(NyMedlem);
                return RedirectToPage("Index");
            }
        }
    }
