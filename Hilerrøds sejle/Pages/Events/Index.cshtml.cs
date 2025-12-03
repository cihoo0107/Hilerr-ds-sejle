using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
namespace Hilerrøds_sejle.Pages.Events
{
    public class IndexModel : PageModel
    {

        public List<Event> Events { get; set; } = new List<Event>
        {
            new Event("Sommerfest", new DateTime (2025, 5, 20)),
            new Event("Vinterfest", new DateTime (2026, 12, 17))
        };


        public void OnGet()
        {
        }
    }
}
