using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Metrics;

namespace Hilerrøds_sejle.Pages.Blogs
{
    public class SletModel : PageModel
    {
        private readonly IBlogService _blogService;

        [BindProperty]
        public Blog BlogToDelete { get; set; }

        public SletModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult OnGet(string id)
        {
            BlogToDelete = _blogService.GetAll().FirstOrDefault(blog => blog.Id == id);
            if (BlogToDelete == null)
            {
                return RedirectToPage("/Blog/Index");
            }

            return Page();
        }
        public IActionResult OnPost()
        {
            _blogService.DeleteById(BlogToDelete.Id);
            return RedirectToPage("/Blog/Index");

        }

    }
}

            
