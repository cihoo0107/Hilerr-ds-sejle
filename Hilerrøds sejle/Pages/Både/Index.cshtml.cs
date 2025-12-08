using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Service;
using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Pages.Både
{
    public class IndexModel : PageModel
    {
        private IBådservice _bådservice;
        public List<Båd> Både { get; private set; }

        public IndexModel(IBådservice bådservice)
        {
            _bådservice = bådservice;
            Både = new List<Båd>();
        }
        
        public void OnGet()
        {
            Både = _bådservice.GetAll();
        }
    }
}
