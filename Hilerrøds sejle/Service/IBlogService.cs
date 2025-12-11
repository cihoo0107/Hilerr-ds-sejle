using Hilerrøds_sejle.Model;

namespace Hilerrøds_sejle.Service
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        void Add(Blog blog);
        //void Update(Blog blog);


    }
}
