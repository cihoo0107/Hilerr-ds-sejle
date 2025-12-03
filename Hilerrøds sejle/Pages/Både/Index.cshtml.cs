using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using System.Security.Cryptography.X509Certificates;
namespace Hilerrøds_sejle.Pages.Både
{
    public class IndexModel : PageModel
    {
        public List<Båd> Både { get; set; } = new List<Båd>
        {
           new Båd("Motorbåd","X20","4120",10,4,"2005","Lambo"),
           new Båd("Sejlbåd", "Q35","3115",8,3,"2003","The Quruce"),
           new Båd("Skoda", "60","3112",4,1,"2022","Enyaq")
        };

        public void OnGet()
        {
        }
    }
}
