using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Blogs
{
    public class OpretModel : PageModel
    {
        private IBlogService _blogservice;
        public Blog NewBlog { get; set; }

        public OpretModel(IBlogService blogService)
        {
            _blogservice = blogService;
        }

        [BindProperty]
        public Blog NytBlog { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _blogservice.Add(NytBlog);
            return RedirectToPage("Index");
        }
    }
}