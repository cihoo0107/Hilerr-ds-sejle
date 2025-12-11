using Hilerrøds_sejle.Model;
namespace Hilerrøds_sejle.Service
{
    public interface IEventService
    {
        List<Event> GetAll();
        void Add(Event events);
        void Delete(Event events);
        void DeleteById(string Id);
        
    }
}
