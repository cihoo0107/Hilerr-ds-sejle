using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
namespace Hilerrøds_sejle.Service;

public class EventService : IEventService
{
    private List<Event> _Events = new List<Event>()
    {
          new Event( "Sommerfest", new DateTime (2025, 5, 20, 17, 0, 0)), // Kl. 17:00
            new Event( "Vinterfest", new DateTime (2026, 12, 17, 20, 0, 0)), // Kl. 20:00
            new Event("Julefest", new DateTime(2025, 12, 22, 21, 0, 0))
    };

    public List<Event> GetAll()
    {
        return _Events;
    }
    public void Add(Event _event)
    {
        _Events.Add(_event);
    }
    public void Delete(Event _event)
    {
        _Events.Remove(_event);
    }
    public void DeleteById(string id)
    {
        var item = _Events.FirstOrDefault(e => e.Id == id);
        if (item != null)
        {
            _Events.Remove(item);
        }
    }
}