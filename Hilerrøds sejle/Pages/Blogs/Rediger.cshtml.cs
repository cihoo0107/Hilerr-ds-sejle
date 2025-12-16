using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Service;

namespace Hilerrøds_sejle.Pages.Blogs
{
    public class RedigerModel : PageModel
    {
        private readonly IBlogService _blogService;

        [BindProperty]
        public Blog BlogToEdit { get; set; }
        public RedigerModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult OnGet(string id)
        {
            BlogToEdit = _blogService.GetAll().FirstOrDefault(blog => blog.Id == id);
            if (BlogToEdit == null)
            {
                return RedirectToPage("/Blogs/Index");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _blogService.Update(BlogToEdit);
            return RedirectToPage("/Blogs/Index");
        }
    }
}
