using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Service;
using Hilerrøds_sejle.Model;
using System.Security.Cryptography.X509Certificates;

namespace Hilerrøds_sejle.Pages.Blogs
{
    public class IndexModel : PageModel
    {
        private IBlogService _blogservice;
        public List<Blog> Blogs { get; private set; }
        public IndexModel (IBlogService blogservice)
        {
            _blogservice = blogservice;
            Blogs = new List<Blog>();
        }
        public void OnGet()
        {
            Blogs = _blogservice.GetAll();
        }
    }
}

