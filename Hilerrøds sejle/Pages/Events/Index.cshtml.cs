using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Service;
using Hilerrøds_sejle.Model;
using System.Security.Cryptography.X509Certificates;

namespace Hilerrøds_sejle.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IEventService _eventservice;
        public List<Event> Events { get; private set; } 

        public IndexModel (IEventService eventservice)
        {
            _eventservice = eventservice;
            Events = new List<Event>();
        }

        public void OnGet()
        {
            Events = _eventservice.GetAll();
        }
    }
}
