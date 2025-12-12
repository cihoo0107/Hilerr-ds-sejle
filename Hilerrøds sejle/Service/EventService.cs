using Hilerrøds_sejle.Model;
using Hilerrøds_sejle.Pages;
using System.Security.Cryptography.X509Certificates;
namespace Hilerrøds_sejle.Service;

public class EventService : IEventService
{
    private List<Event> _Events = new List<Event>()
    {
          new Event( "Sommerfest", new DateTime (2025, 5, 20, 17, 0, 0)), // Kl. 17:00
            new Event( "Vinterfest", new DateTime (2026, 12, 17, 20, 0, 0)), // Kl. 20:00
            new Event("Julefest", new DateTime(2025, 12, 22, 21, 0, 0)) // Kl. 21:00
    };

    public List<Event> GetAll()
    {
        return _Events;
    }
    public void Add(Event events)
    {
        _Events.Add(events);
    }
    public void Delete(Event events)
    {
        _Events.Remove(events);
    }
    public void DeleteById(string id)
    {
        var item = _Events.FirstOrDefault(e => e.Id == id);
        if (item != null)
        {
            _Events.Remove(item);
        }
    }
    public void Update(Event updatedEvents)
    {
        var existing = _Events.FirstOrDefault(e => e.Id == updatedEvents.Id);
        if (existing != null)
        {
            existing.Navn = updatedEvents.Navn;
            existing.Tidspunkt = updatedEvents.Tidspunkt;
        }
    }
}
 
