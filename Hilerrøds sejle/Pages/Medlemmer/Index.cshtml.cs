using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using System.Collections.Generic;

namespace Hilerrøds_sejle.Pages.Medlemmer
{
    public class IndexModel : PageModel
    {
        public static List<Medlem> Medlemmer = new List<Medlem>();

        public void OnGet()
        {
        }
        // Opret Medlem
        //public IActionResult OnPostCreate()
    }
}
