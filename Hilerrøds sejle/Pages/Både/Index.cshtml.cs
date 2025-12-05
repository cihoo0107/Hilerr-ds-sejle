using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Service;
using System.Security.Cryptography.X509Certificates;

namespace Hilerrøds_sejle.Pages.Både
{
    public class IndexModel : PageModel
    {
        private IBådservice _bådservice;
        
        public void OnGet()
        {
        }
    }
}
