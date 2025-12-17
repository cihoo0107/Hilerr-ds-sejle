using Hilerrøds_sejle.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
namespace Hilerrøds_sejle.Pages.Både
{
    public class RedigerModel : PageModel
    {

        private readonly IBådservice _bådservice;
        
        [BindProperty]
        public Båd BådToEdit { get; set; }
        public RedigerModel(IBådservice bådservice)
        {
            _bådservice = bådservice;
        }
        public IActionResult OnGet(int id)
        {
            BådToEdit = _bådservice.GetAll().FirstOrDefault(båd => båd.Id == id);
            if (BådToEdit == null)
            {
                return RedirectToPage("/Både/Index");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _bådservice.Update(BådToEdit);
            return RedirectToPage("/Både/Index");
        }
    }
}
