using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
using Hilerrøds_sejle.Service;
using System.Reflection.Metadata;
namespace Hilerrøds_sejle.Service
{

    public class BlogService : IBlogService
    {
        private List<Blog> _Blog = new List<Blog>()
    {
         new Blog("Velkommen til vores Blog", "Dette er vores første blogindlæg... "),
            new Blog("Sejltur i en dejlig sommersol", "Vi havde en skøn sejltur efter sommerfesten...")
    };

        public List<Blog> GetAll()
        {
            return _Blog;
        }
        public void Add(Blog blog)
        {
            _Blog.Add(blog);
        }
        public void Delete(Blog blog)
        {
            _Blog.Remove(blog);
        }
        public void DeleteById(string id)
        {
            var item = _Blog.FirstOrDefault(blog => blog.Id == id);
            if (item != null)
            {
                _Blog.Remove(item);
            }
        }
        public void Update(Blog updatedBlog)
        {
            var existing = _Blog.FirstOrDefault(blog => blog.Id == updatedBlog.Id);
            if (existing != null)
            {
                existing.Titel = updatedBlog.Titel;
                existing.Content = updatedBlog.Content;
            }
        }
    }
}