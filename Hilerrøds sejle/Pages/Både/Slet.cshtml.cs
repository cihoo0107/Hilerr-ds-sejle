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
        public void OnGet()
        {
        }
    }
}
