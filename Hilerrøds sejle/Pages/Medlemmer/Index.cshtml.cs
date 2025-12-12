using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Hilerrøds_sejle.Service;
namespace Hilerrøds_sejle.Pages.Medlemmer
{

    public class IndexModel : PageModel
    {
        private IMedlemService _medlemRepository;

        public List<Medlem> Medlemmer { get; private set; }

        public IndexModel(IMedlemService medlemRepository)
        {
            _medlemRepository = medlemRepository;
            Medlemmer = new List<Medlem>();
        }



        public void OnGet()
        {
            Medlemmer = _medlemRepository.GetAll();
        }
    }
}



// DUMMY TEST

//{
//    public class IndexModel : PageModel
//    {
//        public List<Medlem> Medlemmer { get; set; } = new List<Medlem>()
//        {
//            new Medlem("Niels","Niels@mail.com",001,Medlemsrolle.Formand),
//            new Medlem("Peter","Peterersej@mail.com",007,Medlemsrolle.Medlem),
//            new Medlem("Maja","Maja@mail.com",002,Medlemsrolle.Næstforkvinde),
//        };

//        public void OnGet()
//        {
//        }

//    }
//}

// DUMMY TEST