using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
using Hilerrøds_sejle.Service;
namespace Hilerrøds_sejle.Service
{
    public class BlogService : IBlogService
{
    private List<Blog> _Blogs = new List<Blog>()
    {

    };

        public List<Blog> GetAll()
        {
            return _Blogs;
        }
//    public void Add(Blog blog)
//    {
//        _Blogs.Add(blog);
//    }
    }
}

